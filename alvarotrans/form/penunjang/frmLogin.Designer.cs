namespace alvarotrans.form.penunjang
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tlsTombol = new System.Windows.Forms.ToolStrip();
            this.tsbTutup = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIdKaryawan = new System.Windows.Forms.TextBox();
            this.lblKeterangan2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIdKaryawan = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkLihat = new System.Windows.Forms.CheckBox();
            this.tlsTombol.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsTombol
            // 
            this.tlsTombol.BackColor = System.Drawing.Color.DarkGray;
            this.tlsTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTutup,
            this.ToolStripSeparator1,
            this.tsbOk});
            this.tlsTombol.Location = new System.Drawing.Point(0, 183);
            this.tlsTombol.Name = "tlsTombol";
            this.tlsTombol.Size = new System.Drawing.Size(298, 25);
            this.tlsTombol.TabIndex = 34;
            this.tlsTombol.Text = "ToolStrip1";
            // 
            // tsbTutup
            // 
            this.tsbTutup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbTutup.Image = ((System.Drawing.Image)(resources.GetObject("tsbTutup.Image")));
            this.tsbTutup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTutup.Name = "tsbTutup";
            this.tsbTutup.Size = new System.Drawing.Size(59, 22);
            this.tsbTutup.Text = "Tutup";
            this.tsbTutup.Click += new System.EventHandler(this.tsbTutup_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOk
            // 
            this.tsbOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbOk.Image = ((System.Drawing.Image)(resources.GetObject("tsbOk.Image")));
            this.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOk.Name = "tsbOk";
            this.tsbOk.Size = new System.Drawing.Size(42, 22);
            this.tsbOk.Text = "Ok";
            this.tsbOk.Click += new System.EventHandler(this.tsbOk_Click);
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.Location = new System.Drawing.Point(76, 34);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(182, 28);
            this.lblKeterangan.TabIndex = 2;
            this.lblKeterangan.Text = "Form ini digunakan untuk pengguna yang ingin login ke akun mereka.";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(76, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 39;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtIdKaryawan
            // 
            this.txtIdKaryawan.Location = new System.Drawing.Point(100, 83);
            this.txtIdKaryawan.Name = "txtIdKaryawan";
            this.txtIdKaryawan.Size = new System.Drawing.Size(158, 20);
            this.txtIdKaryawan.TabIndex = 38;
            // 
            // lblKeterangan2
            // 
            this.lblKeterangan2.AutoSize = true;
            this.lblKeterangan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan2.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan2.Location = new System.Drawing.Point(97, 155);
            this.lblKeterangan2.Name = "lblKeterangan2";
            this.lblKeterangan2.Size = new System.Drawing.Size(130, 13);
            this.lblKeterangan2.TabIndex = 37;
            this.lblKeterangan2.Text = "* Password case-sensitive";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 112);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 36;
            this.lblPassword.Text = "Password :";
            // 
            // lblIdKaryawan
            // 
            this.lblIdKaryawan.AutoSize = true;
            this.lblIdKaryawan.Location = new System.Drawing.Point(11, 86);
            this.lblIdKaryawan.Name = "lblIdKaryawan";
            this.lblIdKaryawan.Size = new System.Drawing.Size(74, 13);
            this.lblIdKaryawan.TabIndex = 35;
            this.lblIdKaryawan.Text = "ID Karyawan :";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.lblKeterangan);
            this.Panel1.Controls.Add(this.lblLogin);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(298, 71);
            this.Panel1.TabIndex = 33;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(48, 48);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // chkLihat
            // 
            this.chkLihat.AutoSize = true;
            this.chkLihat.Location = new System.Drawing.Point(100, 135);
            this.chkLihat.Name = "chkLihat";
            this.chkLihat.Size = new System.Drawing.Size(98, 17);
            this.chkLihat.TabIndex = 40;
            this.chkLihat.Text = "Lihat Password";
            this.chkLihat.UseVisualStyleBackColor = true;
            this.chkLihat.CheckedChanged += new System.EventHandler(this.chkLihat_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 208);
            this.Controls.Add(this.chkLihat);
            this.Controls.Add(this.tlsTombol);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIdKaryawan);
            this.Controls.Add(this.lblKeterangan2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblIdKaryawan);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tlsTombol.ResumeLayout(false);
            this.tlsTombol.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tlsTombol;
        internal System.Windows.Forms.ToolStripButton tsbTutup;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbOk;
        internal System.Windows.Forms.Label lblKeterangan;
        internal System.Windows.Forms.Label lblLogin;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtIdKaryawan;
        internal System.Windows.Forms.Label lblKeterangan2;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.Label lblIdKaryawan;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.CheckBox chkLihat;
    }
}