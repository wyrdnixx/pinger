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

            cb3d.Checked = true;
        }
           
        private void btn_add_Click(object sender, EventArgs e)
        {
                       
                addPinger(tb_ip.Text);
             
                    
        }
     
        private void tb_ip_KeyDown(object sender, KeyEventArgs e)
        {
         
           if (e.KeyCode == Keys.Enter)
            {
                
                addPinger(tb_ip.Text);
            }
            
        }
      

        void addPinger(String address)
        {

            // check if pinger already exists
            Boolean allreadyExists = false;
            foreach (Chart chart in panel1.Controls.OfType<Chart>())
            {
                if (chart.Name == address) allreadyExists = true;
            }

            if (!allreadyExists)
            {
                string myIpString = tb_ip.Text;
                System.Net.IPAddress ipAddress = null;
                bool isValidIp = System.Net.IPAddress.TryParse(myIpString, out ipAddress);

                if (!isValidIp)
                {
                    MessageBox.Show("No valid IP Adress");
                }
                else
                {
                    addChart(address);
                    if (!timer.Enabled) startstopTimer();
                    check3dstate();
                }
            }
            

        }

        private void addChart(String address)
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
            lbl.Dock = DockStyle.Bottom;
            lbl.AutoSize = true;
            lbl.Click += new EventHandler(lbl_Click);// error here
            panel1.Controls.Add(lbl);



            chart.Dock = DockStyle.Bottom;
            chart.Height = 100;
            chart.Width = (panel1.Width - 10);
            panel1.Controls.Add(chart);

            
        }
        protected void lbl_Click(object sender, EventArgs e)
        {
            //string Name = ((System.Windows.Forms.Label)sender).Name;
           // MessageBox.Show(((System.Windows.Forms.Label)sender).Name);


            foreach (Chart chart in panel1.Controls.OfType<Chart>())
            {
                if(chart.Name == ((System.Windows.Forms.Label)sender).Name)
                {
                    panel1.Controls.Remove(chart);
                    chart.Dispose();
                }
            }


            foreach (Label lbl in panel1.Controls.OfType<Label>())
            {
                if (lbl.Name == ((System.Windows.Forms.Label)sender).Name)
                {
                    panel1.Controls.Remove(lbl);
                    lbl.Dispose();
                }
            }

            }
        private void timer_Tick(object sender, EventArgs e)
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

                pingSender.PingCompleted += (sender2, e2) => PingCompletedCallback(sender2, e2, chart,chart.Name);


                int timeout = 2000;
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                PingOptions options = new PingOptions(64, true);

                pingSender.SendAsync(chart.Name, timeout, buffer, options);               

            }

            // dieser Code wird ausgeführt, wenn der Timer abgelaufen ist
        }


        private void PingCompletedCallback(object sender, PingCompletedEventArgs e,Chart chart,  String chartname)
        {

        try
            { 

            foreach (Label lbl in panel1.Controls.OfType<Label>())
            {
                if (lbl.Name == chartname)
                {
                    lbl.Text = " (X)   " + chartname + " -> " + e.Reply.Address.ToString() + " : " + e.Reply.Status.ToString() + " @ " + e.Reply.RoundtripTime;
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
            }catch (NullReferenceException)
            {
                // in case the pinger was deleted while async task was running and this is the callback
                // Nothing
            }
        }




        private void btnstartstop_Click(object sender, EventArgs e)
        {
            startstopTimer();
        }

        private void startstopTimer()
        {
            
            if (timer.Enabled)
            {
                btnstartstop.Text = "start";
                timer.Stop();

            }
            else
            {
                btnstartstop.Text = "stop";
                timer.Start();
            }
        }

        private void cb3d_CheckedChanged(object sender, EventArgs e)
        {
            check3dstate();
        }


        private void check3dstate()
        {
            if (cb3d.Checked)
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

        //private void tb_ip_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // supress "bing"-sound on Enter-Key Pressed
        //    e.Handled = true;
        //    tb_ip.Text = tb_ip.Text + e.KeyChar;
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stop the Timer befor exit (prevent unclean shutdown and exception
            timer.Stop();
        }

        private void bntAddGw_Click(object sender, EventArgs e)
        {
            addPinger(GetDefaultGateway().ToString());
        }

        private void btnadd1111_Click(object sender, EventArgs e)
        {
            addPinger("1.1.1.1");
        }

        private void btnadd8888_Click(object sender, EventArgs e)
        {
            addPinger("8.8.8.8");
        }

        private void btnadd4444_Click(object sender, EventArgs e)
        {
            addPinger("4.4.4.4");
        }
    }

   
}
