using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pinger
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);

            panel1.Anchor = 
                 ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        }
           
        private void btn_add_Click(object sender, EventArgs e)
        {

            string myIpString = tb_ip.Text;
            System.Net.IPAddress ipAddress = null;
            bool isValidIp = System.Net.IPAddress.TryParse(myIpString, out ipAddress);

            if (!isValidIp)
            {
                MessageBox.Show("No valid IP Adress");
            } else
            {
                addChart(tb_ip.Text);
             
            }
         
        }
        private void bntAddGw_Click(object sender, EventArgs e)
        {
            addChart(GetDefaultGateway().ToString());
        }

        void addChart (String address)
        {
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = false,
                //ChartType = SeriesChartType.Line
                ChartType = SeriesChartType.SplineArea

            };

            Chart chart = new Chart();
            chart.Name = address;

            ChartArea ChartArea1 = new ChartArea();
            chart.ChartAreas.Add("ChartArea1");
            //chart.ChartAreas[0].Area3DStyle.Enable3D = true;

            series1.Name = "eins";

            chart.Series.Add(series1);

            Label lbl = new Label();
            lbl.Name = address;
            lbl.Text = address;
            //lbl.Location = new
            lbl.Dock = DockStyle.Bottom;
            panel1.Controls.Add(lbl);

            chart.Dock = DockStyle.Bottom;
            chart.Height = 100;
            chart.Width = (panel1.Width - 10);
            panel1.Controls.Add(chart);
        }


        void timer_Tick(object sender, EventArgs e)
        {
            //testping(tb_ip.Text);

            foreach (Chart chart in panel1.Controls.OfType<Chart>())
            {
                int count = chart.Series[0].Points.Count();
                if (count >= 15)
                {
                    chart.Series[0].Points.RemoveAt(0);
                }

                //PingReply pingreply = ping.Send(chart.Name);

                Ping pingSender = new Ping();
                //pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);

                pingSender.PingCompleted += (sender2, e2) => PingCompletedCallback(sender2, e2, chart);


                int timeout = 2000;
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                PingOptions options = new PingOptions(64, true);
                pingSender.SendAsync(chart.Name, timeout, buffer, options);
                



            }

            // dieser Code wird ausgeführt, wenn der Timer abgelaufen ist
        }


        private void PingCompletedCallback(object sender, PingCompletedEventArgs e, Chart chart)
        {

            //Mespanel1.Controls.OfType<Chart>()sageBox.Show(e.Reply.Address.ToString());
            //MessageBox.Show(e.Reply.Status.ToString());

            //if (e.Reply.Status != IPStatus.Success) { 
            //   tbresults.Text += Environment.NewLine + e.Reply.Status.ToString();
            //}


            foreach (Label lbl in panel1.Controls.OfType<Label>())
            {
                              

                if (lbl.Name == chart.Name)
                {
                    lbl.Text = chart.Name + " -> " + e.Reply.Address.ToString() + " : " + e.Reply.Status.ToString();
                }
            }
            
                    if (e.Reply.Status != IPStatus.Success)
                    {
                        //tbresults.Text += Environment.NewLine + e.Reply.Address.ToString() + " : "+  e.Reply.Status.ToString();
                        chart.Series[0].Points.Add(80).Color = Color.Red;
                        
                    }
                    else
                    {
                        Color col = new Color();
                        col = Color.Green;

                        if (e.Reply.RoundtripTime < 20)
                        {
                            col = Color.Green;
                        }
                        else if (e.Reply.RoundtripTime >= 20 && e.Reply.RoundtripTime <= 35)
                        {
                            col = Color.Yellow;
                        }
                        else if (e.Reply.RoundtripTime > 35)
                        {
                            col = Color.BlueViolet;
                        }
                        chart.Series[0].Points.Add(e.Reply.RoundtripTime).Color = col;
                    }                
            
        }




        private void btnstartstop_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                btnstartstop.Text = "start";
                timer.Stop();

            } else
            {
                btnstartstop.Text = "stop";
                timer.Start();
            }

        }

        private void cb3d_CheckedChanged(object sender, EventArgs e)
        {
            if( cb3d.Checked)
            {

                foreach (Chart chart in panel1.Controls.OfType<Chart>())
                {
                    chart.ChartAreas[0].Area3DStyle.Enable3D = true;
                }
            }
            else
            {
                foreach (Chart chart in panel1.Controls.OfType<Chart>())
                {
                    chart.ChartAreas[0].Area3DStyle.Enable3D = false;
                }
            }
        }

        public static IPAddress GetDefaultGateway()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .Where(a => a != null)
                // .Where(a => a.AddressFamily == AddressFamily.InterNetwork)
                // .Where(a => Array.FindIndex(a.GetAddressBytes(), b => b != 0) >= 0)
                .FirstOrDefault();
        }

  
    }

   
}
