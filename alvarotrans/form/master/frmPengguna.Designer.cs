namespace alvarotrans.form.master
{
    partial class frmPengguna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPengguna));
            this.lblKeterangan3 = new System.Windows.Forms.Label();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.btnIdPengguna = new System.Windows.Forms.Button();
            this.txtIdKaryawan = new System.Windows.Forms.TextBox();
            this.lblUlangiPassword = new System.Windows.Forms.Label();
            this.lblNamaKaryawan = new System.Windows.Forms.Label();
            this.lblIdKaryawan = new System.Windows.Forms.Label();
            this.pnlKeterangan = new System.Windows.Forms.Panel();
            this.lblKeterangan2 = new System.Windows.Forms.Label();
            this.lblKeterangan1 = new System.Windows.Forms.Label();
            this.picKeterangan = new System.Windows.Forms.PictureBox();
            this.lblJabatan = new System.Windows.Forms.Label();
            this.tsbTutup = new System.Windows.Forms.ToolStripButton();
            this.tlsTombol = new System.Windows.Forms.ToolStrip();
            this.tsbSimpan = new System.Windows.Forms.ToolStripButton();
            this.tsbUbah = new System.Windows.Forms.ToolStripButton();
            this.tsbHapus = new System.Windows.Forms.ToolStripButton();
            this.tsbBatal = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRecordPengguna = new System.Windows.Forms.ToolStripButton();
            this.txtJabatan = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUlangiPassword = new System.Windows.Forms.TextBox();
            this.pnlKeterangan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).BeginInit();
            this.tlsTombol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKeterangan3
            // 
            this.lblKeterangan3.AutoSize = true;
            this.lblKeterangan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan3.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan3.Location = new System.Drawing.Point(111, 228);
            this.lblKeterangan3.Name = "lblKeterangan3";
            this.lblKeterangan3.Size = new System.Drawing.Size(130, 13);
            this.lblKeterangan3.TabIndex = 85;
            this.lblKeterangan3.Text = "* Password case-sensitive";
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamaKaryawan.Location = new System.Drawing.Point(114, 117);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.ReadOnly = true;
            this.txtNamaKaryawan.Size = new System.Drawing.Size(175, 20);
            this.txtNamaKaryawan.TabIndex = 82;
            // 
            // btnIdPengguna
            // 
            this.btnIdPengguna.Location = new System.Drawing.Point(265, 90);
            this.btnIdPengguna.Name = "btnIdPengguna";
            this.btnIdPengguna.Size = new System.Drawing.Size(24, 21);
            this.btnIdPengguna.TabIndex = 86;
            this.btnIdPengguna.Text = "...";
            this.btnIdPengguna.UseVisualStyleBackColor = true;
            this.btnIdPengguna.Click += new System.EventHandler(this.btnIdPengguna_Click);
            // 
            // txtIdKaryawan
            // 
            this.txtIdKaryawan.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdKaryawan.Enabled = false;
            this.txtIdKaryawan.Location = new System.Drawing.Point(114, 91);
            this.txtIdKaryawan.Name = "txtIdKaryawan";
            this.txtIdKaryawan.Size = new System.Drawing.Size(145, 20);
            this.txtIdKaryawan.TabIndex = 81;
            // 
            // lblUlangiPassword
            // 
            this.lblUlangiPassword.AutoSize = true;
            this.lblUlangiPassword.Location = new System.Drawing.Point(12, 198);
            this.lblUlangiPassword.Name = "lblUlangiPassword";
            this.lblUlangiPassword.Size = new System.Drawing.Size(92, 13);
            this.lblUlangiPassword.TabIndex = 80;
            this.lblUlangiPassword.Text = "Ulangi Password :";
            // 
            // lblNamaKaryawan
            // 
            this.lblNamaKaryawan.AutoSize = true;
            this.lblNamaKaryawan.Location = new System.Drawing.Point(12, 120);
            this.lblNamaKaryawan.Name = "lblNamaKaryawan";
            this.lblNamaKaryawan.Size = new System.Drawing.Size(91, 13);
            this.lblNamaKaryawan.TabIndex = 78;
            this.lblNamaKaryawan.Text = "Nama Karyawan :";
            // 
            // lblIdKaryawan
            // 
            this.lblIdKaryawan.AutoSize = true;
            this.lblIdKaryawan.Location = new System.Drawing.Point(12, 94);
            this.lblIdKaryawan.Name = "lblIdKaryawan";
            this.lblIdKaryawan.Size = new System.Drawing.Size(74, 13);
            this.lblIdKaryawan.TabIndex = 77;
            this.lblIdKaryawan.Text = "ID Karyawan :";
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
            this.pnlKeterangan.Size = new System.Drawing.Size(443, 78);
            this.pnlKeterangan.TabIndex = 75;
            // 
            // lblKeterangan2
            // 
            this.lblKeterangan2.Location = new System.Drawing.Point(66, 33);
            this.lblKeterangan2.Name = "lblKeterangan2";
            this.lblKeterangan2.Size = new System.Drawing.Size(341, 27);
            this.lblKeterangan2.TabIndex = 2;
            this.lblKeterangan2.Text = "Form ini digunakan untuk menyimpan data pengguna yang berhak menggunakan aplikasi" +
    " ini.\r\n";
            // 
            // lblKeterangan1
            // 
            this.lblKeterangan1.AutoSize = true;
            this.lblKeterangan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan1.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan1.Location = new System.Drawing.Point(66, 10);
            this.lblKeterangan1.Name = "lblKeterangan1";
            this.lblKeterangan1.Size = new System.Drawing.Size(115, 16);
            this.lblKeterangan1.TabIndex = 1;
            this.lblKeterangan1.Text = "Data Pengguna";
            // 
            // picKeterangan
            // 
            this.picKeterangan.Image = ((System.Drawing.Image)(resources.GetObject("picKeterangan.Image")));
            this.picKeterangan.Location = new System.Drawing.Point(10, 10);
            this.picKeterangan.Name = "picKeterangan";
            this.picKeterangan.Size = new System.Drawing.Size(50, 50);
            this.picKeterangan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKeterangan.TabIndex = 0;
            this.picKeterangan.TabStop = false;
            // 
            // lblJabatan
            // 
            this.lblJabatan.AutoSize = true;
            this.lblJabatan.Location = new System.Drawing.Point(12, 146);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(51, 13);
            this.lblJabatan.TabIndex = 88;
            this.lblJabatan.Text = "Jabatan ;";
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
            // tlsTombol
            // 
            this.tlsTombol.BackColor = System.Drawing.Color.DarkGray;
            this.tlsTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSimpan,
            this.tsbUbah,
            this.tsbHapus,
            this.tsbBatal,
            this.ToolStripSeparator1,
            this.tsbRecordPengguna,
            this.tsbTutup});
            this.tlsTombol.Location = new System.Drawing.Point(0, 269);
            this.tlsTombol.Name = "tlsTombol";
            this.tlsTombol.Size = new System.Drawing.Size(443, 25);
            this.tlsTombol.TabIndex = 76;
            this.tlsTombol.Text = "ToolStrip1";
            // 
            // tsbSimpan
            // 
            this.tsbSimpan.Image = ((System.Drawing.Image)(resources.GetObject("tsbSimpan.Image")));
            this.tsbSimpan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSimpan.Name = "tsbSimpan";
            this.tsbSimpan.Size = new System.Drawing.Size(67, 22);
            this.tsbSimpan.Text = "Simpan";
            this.tsbSimpan.Click += new System.EventHandler(this.tsbSimpan_Click);
            // 
            // tsbUbah
            // 
            this.tsbUbah.Image = ((System.Drawing.Image)(resources.GetObject("tsbUbah.Image")));
            this.tsbUbah.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUbah.Name = "tsbUbah";
            this.tsbUbah.Size = new System.Drawing.Size(55, 22);
            this.tsbUbah.Text = "Ubah";
            this.tsbUbah.Click += new System.EventHandler(this.tsbUbah_Click);
            // 
            // tsbHapus
            // 
            this.tsbHapus.Image = ((System.Drawing.Image)(resources.GetObject("tsbHapus.Image")));
            this.tsbHapus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHapus.Name = "tsbHapus";
            this.tsbHapus.Size = new System.Drawing.Size(61, 22);
            this.tsbHapus.Text = "Hapus";
            this.tsbHapus.Click += new System.EventHandler(this.tsbHapus_Click);
            // 
            // tsbBatal
            // 
            this.tsbBatal.Image = ((System.Drawing.Image)(resources.GetObject("tsbBatal.Image")));
            this.tsbBatal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBatal.Name = "tsbBatal";
            this.tsbBatal.Size = new System.Drawing.Size(53, 22);
            this.tsbBatal.Text = "Batal";
            this.tsbBatal.Click += new System.EventHandler(this.tsbBatal_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRecordPengguna
            // 
            this.tsbRecordPengguna.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecordPengguna.Image")));
            this.tsbRecordPengguna.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecordPengguna.Name = "tsbRecordPengguna";
            this.tsbRecordPengguna.Size = new System.Drawing.Size(121, 22);
            this.tsbRecordPengguna.Text = "Record Pengguna";
            this.tsbRecordPengguna.Click += new System.EventHandler(this.tsbRecordPengguna_Click);
            // 
            // txtJabatan
            // 
            this.txtJabatan.BackColor = System.Drawing.SystemColors.Window;
            this.txtJabatan.Location = new System.Drawing.Point(114, 143);
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.ReadOnly = true;
            this.txtJabatan.Size = new System.Drawing.Size(175, 20);
            this.txtJabatan.TabIndex = 87;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 172);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 13);
            this.lblPassword.TabIndex = 79;
            this.lblPassword.Text = "Password Login :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 20);
            this.txtPassword.TabIndex = 89;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUlangiPassword
            // 
            this.txtUlangiPassword.Location = new System.Drawing.Point(114, 195);
            this.txtUlangiPassword.Name = "txtUlangiPassword";
            this.txtUlangiPassword.PasswordChar = '*';
            this.txtUlangiPassword.Size = new System.Drawing.Size(175, 20);
            this.txtUlangiPassword.TabIndex = 90;
            this.txtUlangiPassword.UseSystemPasswordChar = true;
            this.txtUlangiPassword.TextChanged += new System.EventHandler(this.txtUlangiPassword_TextChanged);
            // 
            // frmPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 294);
            this.Controls.Add(this.txtUlangiPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblKeterangan3);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.btnIdPengguna);
            this.Controls.Add(this.txtIdKaryawan);
            this.Controls.Add(this.lblUlangiPassword);
            this.Controls.Add(this.lblNamaKaryawan);
            this.Controls.Add(this.lblIdKaryawan);
            this.Controls.Add(this.pnlKeterangan);
            this.Controls.Add(this.lblJabatan);
            this.Controls.Add(this.tlsTombol);
            this.Controls.Add(this.txtJabatan);
            this.Controls.Add(this.lblPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPengguna";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informasi Pengguna";
            this.Load += new System.EventHandler(this.frmPengguna_Load);
            this.pnlKeterangan.ResumeLayout(false);
            this.pnlKeterangan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).EndInit();
            this.tlsTombol.ResumeLayout(false);
            this.tlsTombol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblKeterangan3;
        internal System.Windows.Forms.TextBox txtNamaKaryawan;
        internal System.Windows.Forms.Button btnIdPengguna;
        internal System.Windows.Forms.TextBox txtIdKaryawan;
        internal System.Windows.Forms.Label lblUlangiPassword;
        internal System.Windows.Forms.Label lblNamaKaryawan;
        internal System.Windows.Forms.Label lblIdKaryawan;
        internal System.Windows.Forms.Panel pnlKeterangan;
        internal System.Windows.Forms.Label lblKeterangan2;
        internal System.Windows.Forms.Label lblKeterangan1;
        internal System.Windows.Forms.PictureBox picKeterangan;
        private System.Windows.Forms.Label lblJabatan;
        internal System.Windows.Forms.ToolStripButton tsbTutup;
        internal System.Windows.Forms.ToolStrip tlsTombol;
        internal System.Windows.Forms.ToolStripButton tsbSimpan;
        internal System.Windows.Forms.ToolStripButton tsbUbah;
        internal System.Windows.Forms.ToolStripButton tsbHapus;
        internal System.Windows.Forms.ToolStripButton tsbBatal;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbRecordPengguna;
        internal System.Windows.Forms.TextBox txtJabatan;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUlangiPassword;
    }
}