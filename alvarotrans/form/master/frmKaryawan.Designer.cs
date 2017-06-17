namespace alvarotrans.form.master
{
    partial class frmKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKaryawan));
            this.cboJabatan = new System.Windows.Forms.ComboBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.txtIdKaryawan = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.lblNamaKaryawan = new System.Windows.Forms.Label();
            this.lblJabatan = new System.Windows.Forms.Label();
            this.pnlKeterangan = new System.Windows.Forms.Panel();
            this.lblKeterangan2 = new System.Windows.Forms.Label();
            this.lblKeterangan1 = new System.Windows.Forms.Label();
            this.picKeterangan = new System.Windows.Forms.PictureBox();
            this.lblIdKaryawan = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.tlsTombol = new System.Windows.Forms.ToolStrip();
            this.tsbSimpan = new System.Windows.Forms.ToolStripButton();
            this.tsbUbah = new System.Windows.Forms.ToolStripButton();
            this.tsbHapus = new System.Windows.Forms.ToolStripButton();
            this.tsbBatal = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRecordKaryawan = new System.Windows.Forms.ToolStripButton();
            this.tsbTutup = new System.Windows.Forms.ToolStripButton();
            this.txtRekening = new System.Windows.Forms.TextBox();
            this.lblRekening = new System.Windows.Forms.Label();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.lblTempatLahir = new System.Windows.Forms.Label();
            this.dtpTglLahir = new System.Windows.Forms.DateTimePicker();
            this.lblTanggalLahir = new System.Windows.Forms.Label();
            this.lblAgama = new System.Windows.Forms.Label();
            this.cboAgama = new System.Windows.Forms.ComboBox();
            this.cboJenisKelamin = new System.Windows.Forms.ComboBox();
            this.lblJenisKelamin = new System.Windows.Forms.Label();
            this.lblMulaiKerja = new System.Windows.Forms.Label();
            this.dtpMulaiKerja = new System.Windows.Forms.DateTimePicker();
            this.pnlKeterangan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).BeginInit();
            this.tlsTombol.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboJabatan
            // 
            this.cboJabatan.FormattingEnabled = true;
            this.cboJabatan.Location = new System.Drawing.Point(396, 143);
            this.cboJabatan.Name = "cboJabatan";
            this.cboJabatan.Size = new System.Drawing.Size(137, 21);
            this.cboJabatan.TabIndex = 93;
            this.cboJabatan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboJabatan_KeyDown);
            this.cboJabatan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboJabatan_KeyPress);
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(396, 91);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(167, 20);
            this.txtTelepon.TabIndex = 92;
            this.txtTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelepon_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(396, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEmail.TabIndex = 91;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(114, 246);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(167, 68);
            this.txtAlamat.TabIndex = 90;
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Location = new System.Drawing.Point(114, 117);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(167, 20);
            this.txtNamaKaryawan.TabIndex = 89;
            // 
            // txtIdKaryawan
            // 
            this.txtIdKaryawan.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdKaryawan.Enabled = false;
            this.txtIdKaryawan.Location = new System.Drawing.Point(114, 91);
            this.txtIdKaryawan.Name = "txtIdKaryawan";
            this.txtIdKaryawan.Size = new System.Drawing.Size(167, 20);
            this.txtIdKaryawan.TabIndex = 88;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(294, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 87;
            this.lblEmail.Text = "Email :";
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Location = new System.Drawing.Point(294, 94);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(52, 13);
            this.lblTelepon.TabIndex = 86;
            this.lblTelepon.Text = "Telepon :";
            // 
            // lblNamaKaryawan
            // 
            this.lblNamaKaryawan.AutoSize = true;
            this.lblNamaKaryawan.Location = new System.Drawing.Point(12, 120);
            this.lblNamaKaryawan.Name = "lblNamaKaryawan";
            this.lblNamaKaryawan.Size = new System.Drawing.Size(91, 13);
            this.lblNamaKaryawan.TabIndex = 83;
            this.lblNamaKaryawan.Text = "Nama Karyawan :";
            // 
            // lblJabatan
            // 
            this.lblJabatan.AutoSize = true;
            this.lblJabatan.Location = new System.Drawing.Point(294, 146);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(51, 13);
            this.lblJabatan.TabIndex = 84;
            this.lblJabatan.Text = "Jabatan :";
            // 
            // pnlKeterangan
            // 
            this.pnlKeterangan.BackColor = System.Drawing.Color.White;
            this.pnlKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKeterangan.Controls.Add(this.lblKeterangan2);
            this.pnlKeterangan.Controls.Add(this.lblKeterangan1);
            this.pnlKeterangan.Controls.Add(this.picKeterangan);
            this.pnlKeterangan.Location = new System.Drawing.Point(-1, 0);
            this.pnlKeterangan.Name = "pnlKeterangan";
            this.pnlKeterangan.Size = new System.Drawing.Size(576, 78);
            this.pnlKeterangan.TabIndex = 80;
            // 
            // lblKeterangan2
            // 
            this.lblKeterangan2.Location = new System.Drawing.Point(66, 33);
            this.lblKeterangan2.Name = "lblKeterangan2";
            this.lblKeterangan2.Size = new System.Drawing.Size(416, 27);
            this.lblKeterangan2.TabIndex = 2;
            this.lblKeterangan2.Text = "Form ini digunakan untuk melihat, menyimpan serta menghapus seluruh data karyawan" +
    " CV. Alvaro Trans Cargo.\r\n";
            // 
            // lblKeterangan1
            // 
            this.lblKeterangan1.AutoSize = true;
            this.lblKeterangan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan1.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan1.Location = new System.Drawing.Point(66, 10);
            this.lblKeterangan1.Name = "lblKeterangan1";
            this.lblKeterangan1.Size = new System.Drawing.Size(112, 16);
            this.lblKeterangan1.TabIndex = 1;
            this.lblKeterangan1.Text = "Data Karyawan";
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
            // lblIdKaryawan
            // 
            this.lblIdKaryawan.AutoSize = true;
            this.lblIdKaryawan.Location = new System.Drawing.Point(12, 94);
            this.lblIdKaryawan.Name = "lblIdKaryawan";
            this.lblIdKaryawan.Size = new System.Drawing.Size(74, 13);
            this.lblIdKaryawan.TabIndex = 82;
            this.lblIdKaryawan.Text = "ID Karyawan :";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(12, 249);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(45, 13);
            this.lblAlamat.TabIndex = 85;
            this.lblAlamat.Text = "Alamat :";
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
            this.tsbRecordKaryawan,
            this.tsbTutup});
            this.tlsTombol.Location = new System.Drawing.Point(0, 330);
            this.tlsTombol.Name = "tlsTombol";
            this.tlsTombol.Size = new System.Drawing.Size(575, 25);
            this.tlsTombol.TabIndex = 81;
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
            // tsbRecordKaryawan
            // 
            this.tsbRecordKaryawan.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecordKaryawan.Image")));
            this.tsbRecordKaryawan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecordKaryawan.Name = "tsbRecordKaryawan";
            this.tsbRecordKaryawan.Size = new System.Drawing.Size(118, 22);
            this.tsbRecordKaryawan.Text = "Record Karyawan";
            this.tsbRecordKaryawan.Click += new System.EventHandler(this.tsbRecordKaryawan_Click);
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
            // txtRekening
            // 
            this.txtRekening.Location = new System.Drawing.Point(396, 170);
            this.txtRekening.Name = "txtRekening";
            this.txtRekening.Size = new System.Drawing.Size(167, 20);
            this.txtRekening.TabIndex = 96;
            // 
            // lblRekening
            // 
            this.lblRekening.AutoSize = true;
            this.lblRekening.Location = new System.Drawing.Point(294, 173);
            this.lblRekening.Name = "lblRekening";
            this.lblRekening.Size = new System.Drawing.Size(79, 13);
            this.lblRekening.TabIndex = 95;
            this.lblRekening.Text = "No. Rekening :";
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Location = new System.Drawing.Point(114, 143);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(167, 20);
            this.txtTempatLahir.TabIndex = 100;
            // 
            // lblTempatLahir
            // 
            this.lblTempatLahir.AutoSize = true;
            this.lblTempatLahir.Location = new System.Drawing.Point(12, 146);
            this.lblTempatLahir.Name = "lblTempatLahir";
            this.lblTempatLahir.Size = new System.Drawing.Size(75, 13);
            this.lblTempatLahir.TabIndex = 99;
            this.lblTempatLahir.Text = "Tempat Lahir :";
            // 
            // dtpTglLahir
            // 
            this.dtpTglLahir.CustomFormat = "dd-MM-yyyy";
            this.dtpTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTglLahir.Location = new System.Drawing.Point(114, 166);
            this.dtpTglLahir.Name = "dtpTglLahir";
            this.dtpTglLahir.Size = new System.Drawing.Size(100, 20);
            this.dtpTglLahir.TabIndex = 101;
            // 
            // lblTanggalLahir
            // 
            this.lblTanggalLahir.AutoSize = true;
            this.lblTanggalLahir.Location = new System.Drawing.Point(12, 172);
            this.lblTanggalLahir.Name = "lblTanggalLahir";
            this.lblTanggalLahir.Size = new System.Drawing.Size(78, 13);
            this.lblTanggalLahir.TabIndex = 102;
            this.lblTanggalLahir.Text = "Tanggal Lahir :";
            // 
            // lblAgama
            // 
            this.lblAgama.AutoSize = true;
            this.lblAgama.Location = new System.Drawing.Point(12, 195);
            this.lblAgama.Name = "lblAgama";
            this.lblAgama.Size = new System.Drawing.Size(46, 13);
            this.lblAgama.TabIndex = 103;
            this.lblAgama.Text = "Agama :";
            // 
            // cboAgama
            // 
            this.cboAgama.FormattingEnabled = true;
            this.cboAgama.Items.AddRange(new object[] {
            "ISLAM",
            "KATOLIK",
            "PROTESTAN",
            "HINDU",
            "BUDDHA",
            "KONGHUCU"});
            this.cboAgama.Location = new System.Drawing.Point(114, 192);
            this.cboAgama.Name = "cboAgama";
            this.cboAgama.Size = new System.Drawing.Size(100, 21);
            this.cboAgama.TabIndex = 104;
            this.cboAgama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAgama_KeyDown);
            this.cboAgama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAgama_KeyPress);
            // 
            // cboJenisKelamin
            // 
            this.cboJenisKelamin.FormattingEnabled = true;
            this.cboJenisKelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cboJenisKelamin.Location = new System.Drawing.Point(114, 219);
            this.cboJenisKelamin.Name = "cboJenisKelamin";
            this.cboJenisKelamin.Size = new System.Drawing.Size(100, 21);
            this.cboJenisKelamin.TabIndex = 106;
            this.cboJenisKelamin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboJenisKelamin_KeyDown);
            this.cboJenisKelamin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboJenisKelamin_KeyPress);
            // 
            // lblJenisKelamin
            // 
            this.lblJenisKelamin.AutoSize = true;
            this.lblJenisKelamin.Location = new System.Drawing.Point(12, 222);
            this.lblJenisKelamin.Name = "lblJenisKelamin";
            this.lblJenisKelamin.Size = new System.Drawing.Size(80, 13);
            this.lblJenisKelamin.TabIndex = 105;
            this.lblJenisKelamin.Text = "Jenis Kelamin : ";
            // 
            // lblMulaiKerja
            // 
            this.lblMulaiKerja.AutoSize = true;
            this.lblMulaiKerja.Location = new System.Drawing.Point(294, 202);
            this.lblMulaiKerja.Name = "lblMulaiKerja";
            this.lblMulaiKerja.Size = new System.Drawing.Size(65, 13);
            this.lblMulaiKerja.TabIndex = 108;
            this.lblMulaiKerja.Text = "Mulai Kerja :";
            // 
            // dtpMulaiKerja
            // 
            this.dtpMulaiKerja.CustomFormat = "dd-MM-yyyy";
            this.dtpMulaiKerja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMulaiKerja.Location = new System.Drawing.Point(396, 196);
            this.dtpMulaiKerja.Name = "dtpMulaiKerja";
            this.dtpMulaiKerja.Size = new System.Drawing.Size(100, 20);
            this.dtpMulaiKerja.TabIndex = 107;
            // 
            // frmKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 355);
            this.Controls.Add(this.lblMulaiKerja);
            this.Controls.Add(this.dtpMulaiKerja);
            this.Controls.Add(this.cboJenisKelamin);
            this.Controls.Add(this.lblJenisKelamin);
            this.Controls.Add(this.cboAgama);
            this.Controls.Add(this.lblAgama);
            this.Controls.Add(this.lblTanggalLahir);
            this.Controls.Add(this.dtpTglLahir);
            this.Controls.Add(this.txtTempatLahir);
            this.Controls.Add(this.lblTempatLahir);
            this.Controls.Add(this.txtRekening);
            this.Controls.Add(this.lblRekening);
            this.Controls.Add(this.cboJabatan);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.txtIdKaryawan);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelepon);
            this.Controls.Add(this.lblNamaKaryawan);
            this.Controls.Add(this.lblJabatan);
            this.Controls.Add(this.pnlKeterangan);
            this.Controls.Add(this.lblIdKaryawan);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.tlsTombol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKaryawan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informasi Karyawan";
            this.Load += new System.EventHandler(this.frmKaryawan_Load);
            this.pnlKeterangan.ResumeLayout(false);
            this.pnlKeterangan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).EndInit();
            this.tlsTombol.ResumeLayout(false);
            this.tlsTombol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboJabatan;
        internal System.Windows.Forms.TextBox txtTelepon;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtAlamat;
        internal System.Windows.Forms.TextBox txtNamaKaryawan;
        internal System.Windows.Forms.TextBox txtIdKaryawan;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblTelepon;
        internal System.Windows.Forms.Label lblNamaKaryawan;
        internal System.Windows.Forms.Label lblJabatan;
        internal System.Windows.Forms.Panel pnlKeterangan;
        internal System.Windows.Forms.Label lblKeterangan2;
        internal System.Windows.Forms.Label lblKeterangan1;
        internal System.Windows.Forms.PictureBox picKeterangan;
        internal System.Windows.Forms.Label lblIdKaryawan;
        internal System.Windows.Forms.Label lblAlamat;
        internal System.Windows.Forms.ToolStrip tlsTombol;
        internal System.Windows.Forms.ToolStripButton tsbSimpan;
        internal System.Windows.Forms.ToolStripButton tsbUbah;
        internal System.Windows.Forms.ToolStripButton tsbHapus;
        internal System.Windows.Forms.ToolStripButton tsbBatal;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbRecordKaryawan;
        internal System.Windows.Forms.ToolStripButton tsbTutup;
        internal System.Windows.Forms.TextBox txtRekening;
        internal System.Windows.Forms.Label lblRekening;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.Label lblTempatLahir;
        internal System.Windows.Forms.DateTimePicker dtpTglLahir;
        private System.Windows.Forms.Label lblTanggalLahir;
        private System.Windows.Forms.Label lblAgama;
        private System.Windows.Forms.ComboBox cboAgama;
        private System.Windows.Forms.ComboBox cboJenisKelamin;
        private System.Windows.Forms.Label lblJenisKelamin;
        private System.Windows.Forms.Label lblMulaiKerja;
        internal System.Windows.Forms.DateTimePicker dtpMulaiKerja;
    }
}