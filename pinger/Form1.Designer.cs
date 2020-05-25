namespace pinger
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstartstop = new System.Windows.Forms.Button();
            this.cb3d = new System.Windows.Forms.CheckBox();
            this.bntAddGw = new System.Windows.Forms.Button();
            this.btnadd1111 = new System.Windows.Forms.Button();
            this.btnadd8888 = new System.Windows.Forms.Button();
            this.btnadd4444 = new System.Windows.Forms.Button();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(156, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(138, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(12, 12);
            this.tb_ip.Multiline = true;
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(138, 63);
            this.tb_ip.TabIndex = 2;
            this.tb_ip.Text = "1.1.1.1";
            this.tb_ip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ip_KeyDown);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 765);
            this.panel1.TabIndex = 3;
            // 
            // btnstartstop
            // 
            this.btnstartstop.Location = new System.Drawing.Point(156, 52);
            this.btnstartstop.Name = "btnstartstop";
            this.btnstartstop.Size = new System.Drawing.Size(138, 23);
            this.btnstartstop.TabIndex = 4;
            this.btnstartstop.Text = "start";
            this.btnstartstop.UseVisualStyleBackColor = true;
            this.btnstartstop.Click += new System.EventHandler(this.btnstartstop_Click);
            // 
            // cb3d
            // 
            this.cb3d.AutoSize = true;
            this.cb3d.Location = new System.Drawing.Point(3, 58);
            this.cb3d.Name = "cb3d";
            this.cb3d.Size = new System.Drawing.Size(40, 17);
            this.cb3d.TabIndex = 5;
            this.cb3d.Text = "3D";
            this.cb3d.UseVisualStyleBackColor = true;
            this.cb3d.CheckedChanged += new System.EventHandler(this.cb3d_CheckedChanged);
            // 
            // bntAddGw
            // 
            this.bntAddGw.Location = new System.Drawing.Point(3, 2);
            this.bntAddGw.Name = "bntAddGw";
            this.bntAddGw.Size = new System.Drawing.Size(82, 23);
            this.bntAddGw.TabIndex = 6;
            this.bntAddGw.Text = "Add Def. GW";
            this.bntAddGw.UseVisualStyleBackColor = true;
            this.bntAddGw.Click += new System.EventHandler(this.bntAddGw_Click);
            // 
            // btnadd1111
            // 
            this.btnadd1111.Location = new System.Drawing.Point(3, 31);
            this.btnadd1111.Name = "btnadd1111";
            this.btnadd1111.Size = new System.Drawing.Size(82, 23);
            this.btnadd1111.TabIndex = 7;
            this.btnadd1111.Text = "Add 1.1.1.1";
            this.btnadd1111.UseVisualStyleBackColor = true;
            this.btnadd1111.Click += new System.EventHandler(this.btnadd1111_Click);
            // 
            // btnadd8888
            // 
            this.btnadd8888.Location = new System.Drawing.Point(91, 3);
            this.btnadd8888.Name = "btnadd8888";
            this.btnadd8888.Size = new System.Drawing.Size(82, 23);
            this.btnadd8888.TabIndex = 8;
            this.btnadd8888.Text = "Add 8.8.8.8";
            this.btnadd8888.UseVisualStyleBackColor = true;
            this.btnadd8888.Click += new System.EventHandler(this.btnadd8888_Click);
            // 
            // btnadd4444
            // 
            this.btnadd4444.Location = new System.Drawing.Point(91, 31);
            this.btnadd4444.Name = "btnadd4444";
            this.btnadd4444.Size = new System.Drawing.Size(82, 23);
            this.btnadd4444.TabIndex = 9;
            this.btnadd4444.Text = "Add 4.4.4.4";
            this.btnadd4444.UseVisualStyleBackColor = true;
            this.btnadd4444.Click += new System.EventHandler(this.btnadd4444_Click);
            // 
            // lblInfoText
            // 
            this.lblInfoText.AutoSize = true;
            this.lblInfoText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblInfoText.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoText.Location = new System.Drawing.Point(833, 0);
            this.lblInfoText.MaximumSize = new System.Drawing.Size(0, 80);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(92, 13);
            this.lblInfoText.TabIndex = 10;
            this.lblInfoText.Text = "App was started...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnadd4444);
            this.panel2.Controls.Add(this.btnadd8888);
            this.panel2.Controls.Add(this.cb3d);
            this.panel2.Controls.Add(this.btnadd1111);
            this.panel2.Controls.Add(this.bntAddGw);
            this.panel2.Location = new System.Drawing.Point(314, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 75);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(925, 858);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblInfoText);
            this.Controls.Add(this.btnstartstop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pinger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnstartstop;
        private System.Windows.Forms.CheckBox cb3d;
        private System.Windows.Forms.Button bntAddGw;
        private System.Windows.Forms.Button btnadd1111;
        private System.Windows.Forms.Button btnadd8888;
        private System.Windows.Forms.Button btnadd4444;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.Panel panel2;
    }
}

