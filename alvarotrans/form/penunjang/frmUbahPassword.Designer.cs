namespace alvarotrans.form.penunjang
{
    partial class frmUbahPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUbahPassword));
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTutup = new System.Windows.Forms.ToolStripButton();
            this.lblKeterangan2 = new System.Windows.Forms.Label();
            this.txtIdKaryawan = new System.Windows.Forms.TextBox();
            this.lblUlangi = new System.Windows.Forms.Label();
            this.txtUlangi = new System.Windows.Forms.TextBox();
            this.txtPasswordLama = new System.Windows.Forms.TextBox();
            this.lblKeterangan3 = new System.Windows.Forms.Label();
            this.lblPasswordBaru = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblKeterangan1 = new System.Windows.Forms.Label();
            this.picKeterangan = new System.Windows.Forms.PictureBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPasswordBaru = new System.Windows.Forms.TextBox();
            this.lblPasswordLama = new System.Windows.Forms.Label();
            this.pnlKeterangan = new System.Windows.Forms.Panel();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).BeginInit();
            this.pnlKeterangan.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Enabled = false;
            this.txtNamaKaryawan.Location = new System.Drawing.Point(114, 117);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(175, 20);
            this.txtNamaKaryawan.TabIndex = 56;
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
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // lblKeterangan2
            // 
            this.lblKeterangan2.Location = new System.Drawing.Point(66, 33);
            this.lblKeterangan2.Name = "lblKeterangan2";
            this.lblKeterangan2.Size = new System.Drawing.Size(275, 27);
            this.lblKeterangan2.TabIndex = 2;
            this.lblKeterangan2.Text = "Form ini digunakan untuk pengguna yang ingin merubah kata sandi akun mereka.";
            // 
            // txtIdKaryawan
            // 
            this.txtIdKaryawan.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdKaryawan.Enabled = false;
            this.txtIdKaryawan.Location = new System.Drawing.Point(114, 91);
            this.txtIdKaryawan.Name = "txtIdKaryawan";
            this.txtIdKaryawan.Size = new System.Drawing.Size(175, 20);
            this.txtIdKaryawan.TabIndex = 55;
            // 
            // lblUlangi
            // 
            this.lblUlangi.AutoSize = true;
            this.lblUlangi.Location = new System.Drawing.Point(9, 198);
            this.lblUlangi.Name = "lblUlangi";
            this.lblUlangi.Size = new System.Drawing.Size(92, 13);
            this.lblUlangi.TabIndex = 52;
            this.lblUlangi.Text = "Ulangi Password :";
            // 
            // txtUlangi
            // 
            this.txtUlangi.Location = new System.Drawing.Point(114, 195);
            this.txtUlangi.Name = "txtUlangi";
            this.txtUlangi.PasswordChar = '*';
            this.txtUlangi.Size = new System.Drawing.Size(175, 20);
            this.txtUlangi.TabIndex = 51;
            this.txtUlangi.UseSystemPasswordChar = true;
            this.txtUlangi.TextChanged += new System.EventHandler(this.txtUlangi_TextChanged);
            this.txtUlangi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUlangi_KeyPress);
            // 
            // txtPasswordLama
            // 
            this.txtPasswordLama.Location = new System.Drawing.Point(114, 143);
            this.txtPasswordLama.Name = "txtPasswordLama";
            this.txtPasswordLama.PasswordChar = '*';
            this.txtPasswordLama.Size = new System.Drawing.Size(175, 20);
            this.txtPasswordLama.TabIndex = 49;
            this.txtPasswordLama.UseSystemPasswordChar = true;
            // 
            // lblKeterangan3
            // 
            this.lblKeterangan3.AutoSize = true;
            this.lblKeterangan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan3.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan3.Location = new System.Drawing.Point(111, 230);
            this.lblKeterangan3.Name = "lblKeterangan3";
            this.lblKeterangan3.Size = new System.Drawing.Size(130, 13);
            this.lblKeterangan3.TabIndex = 48;
            this.lblKeterangan3.Text = "* Password case-sensitive";
            // 
            // lblPasswordBaru
            // 
            this.lblPasswordBaru.AutoSize = true;
            this.lblPasswordBaru.Location = new System.Drawing.Point(12, 172);
            this.lblPasswordBaru.Name = "lblPasswordBaru";
            this.lblPasswordBaru.Size = new System.Drawing.Size(84, 13);
            this.lblPasswordBaru.TabIndex = 47;
            this.lblPasswordBaru.Text = "Password Baru :";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTutup,
            this.ToolStripSeparator1,
            this.tsbOk});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 266);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(354, 25);
            this.ToolStrip1.TabIndex = 45;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // lblKeterangan1
            // 
            this.lblKeterangan1.AutoSize = true;
            this.lblKeterangan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan1.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan1.Location = new System.Drawing.Point(66, 10);
            this.lblKeterangan1.Name = "lblKeterangan1";
            this.lblKeterangan1.Size = new System.Drawing.Size(117, 16);
            this.lblKeterangan1.TabIndex = 1;
            this.lblKeterangan1.Text = "Ubah Password";
            // 
            // picKeterangan
            // 
            this.picKeterangan.Image = ((System.Drawing.Image)(resources.GetObject("picKeterangan.Image")));
            this.picKeterangan.Location = new System.Drawing.Point(10, 10);
            this.picKeterangan.Name = "picKeterangan";
            this.picKeterangan.Size = new System.Drawing.Size(50, 50);
            this.picKeterangan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picKeterangan.TabIndex = 0;
            this.picKeterangan.TabStop = false;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 120);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(91, 13);
            this.lblNama.TabIndex = 54;
            this.lblNama.Text = "Nama Karyawan :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 94);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(74, 13);
            this.lblId.TabIndex = 53;
            this.lblId.Text = "ID Karyawan :";
            // 
            // txtPasswordBaru
            // 
            this.txtPasswordBaru.Location = new System.Drawing.Point(114, 169);
            this.txtPasswordBaru.Name = "txtPasswordBaru";
            this.txtPasswordBaru.PasswordChar = '*';
            this.txtPasswordBaru.Size = new System.Drawing.Size(175, 20);
            this.txtPasswordBaru.TabIndex = 50;
            this.txtPasswordBaru.UseSystemPasswordChar = true;
            // 
            // lblPasswordLama
            // 
            this.lblPasswordLama.AutoSize = true;
            this.lblPasswordLama.Location = new System.Drawing.Point(12, 146);
            this.lblPasswordLama.Name = "lblPasswordLama";
            this.lblPasswordLama.Size = new System.Drawing.Size(88, 13);
            this.lblPasswordLama.TabIndex = 46;
            this.lblPasswordLama.Text = "Password Lama :";
            // 
            // pnlKeterangan
            // 
            this.pnlKeterangan.BackColor = System.Drawing.Color.White;
            this.pnlKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKeterangan.Controls.Add(this.lblKeterangan2);
            this.pnlKeterangan.Controls.Add(this.lblKeterangan1);
            this.pnlKeterangan.Controls.Add(this.picKeterangan);
            this.pnlKeterangan.Location = new System.Drawing.Point(0, 0);
            this.pnlKeterangan.Name = "pnlKeterangan";
            this.pnlKeterangan.Size = new System.Drawing.Size(354, 78);
            this.pnlKeterangan.TabIndex = 44;
            // 
            // frmUbahPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 291);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.txtIdKaryawan);
            this.Controls.Add(this.lblUlangi);
            this.Controls.Add(this.txtUlangi);
            this.Controls.Add(this.txtPasswordLama);
            this.Controls.Add(this.lblKeterangan3);
            this.Controls.Add(this.lblPasswordBaru);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPasswordBaru);
            this.Controls.Add(this.lblPasswordLama);
            this.Controls.Add(this.pnlKeterangan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUbahPassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubah Password";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).EndInit();
            this.pnlKeterangan.ResumeLayout(false);
            this.pnlKeterangan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtNamaKaryawan;
        internal System.Windows.Forms.ToolStripButton tsbOk;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbTutup;
        internal System.Windows.Forms.Label lblKeterangan2;
        internal System.Windows.Forms.TextBox txtIdKaryawan;
        internal System.Windows.Forms.Label lblUlangi;
        internal System.Windows.Forms.TextBox txtUlangi;
        internal System.Windows.Forms.TextBox txtPasswordLama;
        internal System.Windows.Forms.Label lblKeterangan3;
        internal System.Windows.Forms.Label lblPasswordBaru;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.Label lblKeterangan1;
        internal System.Windows.Forms.PictureBox picKeterangan;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.TextBox txtPasswordBaru;
        internal System.Windows.Forms.Label lblPasswordLama;
        internal System.Windows.Forms.Panel pnlKeterangan;
    }
}