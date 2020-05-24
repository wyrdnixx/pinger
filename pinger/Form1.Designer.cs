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
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(156, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(12, 12);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(138, 20);
            this.tb_ip.TabIndex = 2;
            this.tb_ip.Text = "1.1.1.1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 765);
            this.panel1.TabIndex = 3;
            // 
            // btnstartstop
            // 
            this.btnstartstop.Location = new System.Drawing.Point(12, 52);
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
            this.cb3d.Location = new System.Drawing.Point(354, 17);
            this.cb3d.Name = "cb3d";
            this.cb3d.Size = new System.Drawing.Size(40, 17);
            this.cb3d.TabIndex = 5;
            this.cb3d.Text = "3D";
            this.cb3d.UseVisualStyleBackColor = true;
            this.cb3d.CheckedChanged += new System.EventHandler(this.cb3d_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(925, 858);
            this.Controls.Add(this.cb3d);
            this.Controls.Add(this.btnstartstop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pinger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnstartstop;
        private System.Windows.Forms.CheckBox cb3d;
    }
}

