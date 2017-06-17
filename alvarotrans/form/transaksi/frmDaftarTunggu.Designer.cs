namespace alvarotrans.form.transaksi
{
    partial class frmDaftarTunggu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDaftarTunggu));
            this.pnlKeterangan = new System.Windows.Forms.Panel();
            this.lblKeterangan2 = new System.Windows.Forms.Label();
            this.lblKeterangan1 = new System.Windows.Forms.Label();
            this.picKeterangan = new System.Windows.Forms.PictureBox();
            this.tsbRecord = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBatal = new System.Windows.Forms.ToolStripButton();
            this.tsbUbah = new System.Windows.Forms.ToolStripButton();
            this.tlsTombol = new System.Windows.Forms.ToolStrip();
            this.tsbSimpan = new System.Windows.Forms.ToolStripButton();
            this.tsbTutup = new System.Windows.Forms.ToolStripButton();
            this.txtNoPesan = new System.Windows.Forms.TextBox();
            this.lblNoPesan = new System.Windows.Forms.Label();
            this.txtNoPolisi = new System.Windows.Forms.TextBox();
            this.lblNoPolisi = new System.Windows.Forms.Label();
            this.btnNoPolisi = new System.Windows.Forms.Button();
            this.txtAkhir = new System.Windows.Forms.TextBox();
            this.txtAwal = new System.Windows.Forms.TextBox();
            this.lblSampai = new System.Windows.Forms.Label();
            this.lblPemakaian = new System.Windows.Forms.Label();
            this.btnPesan = new System.Windows.Forms.Button();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.lblMerk = new System.Windows.Forms.Label();
            this.txtTipeTrailer = new System.Windows.Forms.TextBox();
            this.lblTipeTrailer = new System.Windows.Forms.Label();
            this.pnlKeterangan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).BeginInit();
            this.tlsTombol.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlKeterangan.Size = new System.Drawing.Size(483, 78);
            this.pnlKeterangan.TabIndex = 98;
            // 
            // lblKeterangan2
            // 
            this.lblKeterangan2.Location = new System.Drawing.Point(66, 33);
            this.lblKeterangan2.Name = "lblKeterangan2";
            this.lblKeterangan2.Size = new System.Drawing.Size(364, 27);
            this.lblKeterangan2.TabIndex = 2;
            this.lblKeterangan2.Text = "Form ini digunakan untuk menyimpan data daftar tunggu pemakaian truk CV. Alvaro T" +
    "rans Cargo. ";
            // 
            // lblKeterangan1
            // 
            this.lblKeterangan1.AutoSize = true;
            this.lblKeterangan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan1.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan1.Location = new System.Drawing.Point(66, 10);
            this.lblKeterangan1.Name = "lblKeterangan1";
            this.lblKeterangan1.Size = new System.Drawing.Size(143, 16);
            this.lblKeterangan1.TabIndex = 1;
            this.lblKeterangan1.Text = "Data Daftar Tunggu";
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
            // tsbRecord
            // 
            this.tsbRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecord.Image")));
            this.tsbRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecord.Name = "tsbRecord";
            this.tsbRecord.Size = new System.Drawing.Size(144, 22);
            this.tsbRecord.Text = "Record Daftar Tunggu";
            this.tsbRecord.Click += new System.EventHandler(this.tsbRecord_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // tsbUbah
            // 
            this.tsbUbah.Image = ((System.Drawing.Image)(resources.GetObject("tsbUbah.Image")));
            this.tsbUbah.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUbah.Name = "tsbUbah";
            this.tsbUbah.Size = new System.Drawing.Size(55, 22);
            this.tsbUbah.Text = "Ubah";
            this.tsbUbah.Click += new System.EventHandler(this.tsbUbah_Click);
            // 
            // tlsTombol
            // 
            this.tlsTombol.BackColor = System.Drawing.Color.DarkGray;
            this.tlsTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSimpan,
            this.tsbUbah,
            this.tsbBatal,
            this.ToolStripSeparator1,
            this.tsbRecord,
            this.tsbTutup});
            this.tlsTombol.Location = new System.Drawing.Point(0, 269);
            this.tlsTombol.Name = "tlsTombol";
            this.tlsTombol.Size = new System.Drawing.Size(443, 25);
            this.tlsTombol.TabIndex = 99;
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
            // txtNoPesan
            // 
            this.txtNoPesan.BackColor = System.Drawing.SystemColors.Info;
            this.txtNoPesan.Enabled = false;
            this.txtNoPesan.Location = new System.Drawing.Point(107, 91);
            this.txtNoPesan.Name = "txtNoPesan";
            this.txtNoPesan.Size = new System.Drawing.Size(142, 20);
            this.txtNoPesan.TabIndex = 101;
            // 
            // lblNoPesan
            // 
            this.lblNoPesan.AutoSize = true;
            this.lblNoPesan.Location = new System.Drawing.Point(12, 94);
            this.lblNoPesan.Name = "lblNoPesan";
            this.lblNoPesan.Size = new System.Drawing.Size(89, 13);
            this.lblNoPesan.TabIndex = 100;
            this.lblNoPesan.Text = "No. Pemesanan :";
            // 
            // txtNoPolisi
            // 
            this.txtNoPolisi.BackColor = System.Drawing.SystemColors.Info;
            this.txtNoPolisi.Enabled = false;
            this.txtNoPolisi.Location = new System.Drawing.Point(107, 143);
            this.txtNoPolisi.Name = "txtNoPolisi";
            this.txtNoPolisi.Size = new System.Drawing.Size(142, 20);
            this.txtNoPolisi.TabIndex = 113;
            // 
            // lblNoPolisi
            // 
            this.lblNoPolisi.AutoSize = true;
            this.lblNoPolisi.Location = new System.Drawing.Point(12, 146);
            this.lblNoPolisi.Name = "lblNoPolisi";
            this.lblNoPolisi.Size = new System.Drawing.Size(57, 13);
            this.lblNoPolisi.TabIndex = 112;
            this.lblNoPolisi.Text = "No. Polisi :";
            // 
            // btnNoPolisi
            // 
            this.btnNoPolisi.Location = new System.Drawing.Point(255, 142);
            this.btnNoPolisi.Name = "btnNoPolisi";
            this.btnNoPolisi.Size = new System.Drawing.Size(24, 21);
            this.btnNoPolisi.TabIndex = 114;
            this.btnNoPolisi.Text = "...";
            this.btnNoPolisi.UseVisualStyleBackColor = true;
            this.btnNoPolisi.Click += new System.EventHandler(this.btnNoPolisi_Click);
            // 
            // txtAkhir
            // 
            this.txtAkhir.BackColor = System.Drawing.SystemColors.Window;
            this.txtAkhir.Location = new System.Drawing.Point(242, 117);
            this.txtAkhir.Name = "txtAkhir";
            this.txtAkhir.ReadOnly = true;
            this.txtAkhir.Size = new System.Drawing.Size(100, 20);
            this.txtAkhir.TabIndex = 152;
            // 
            // txtAwal
            // 
            this.txtAwal.BackColor = System.Drawing.SystemColors.Window;
            this.txtAwal.Location = new System.Drawing.Point(107, 117);
            this.txtAwal.Name = "txtAwal";
            this.txtAwal.ReadOnly = true;
            this.txtAwal.Size = new System.Drawing.Size(100, 20);
            this.txtAwal.TabIndex = 154;
            // 
            // lblSampai
            // 
            this.lblSampai.AutoSize = true;
            this.lblSampai.Location = new System.Drawing.Point(213, 120);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.Size = new System.Drawing.Size(23, 13);
            this.lblSampai.TabIndex = 155;
            this.lblSampai.Text = "s/d";
            // 
            // lblPemakaian
            // 
            this.lblPemakaian.AutoSize = true;
            this.lblPemakaian.Location = new System.Drawing.Point(12, 120);
            this.lblPemakaian.Name = "lblPemakaian";
            this.lblPemakaian.Size = new System.Drawing.Size(87, 13);
            this.lblPemakaian.TabIndex = 156;
            this.lblPemakaian.Text = "Tgl. Pemakaian :";
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(255, 90);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(24, 21);
            this.btnPesan.TabIndex = 160;
            this.btnPesan.Text = "...";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // txtMerk
            // 
            this.txtMerk.BackColor = System.Drawing.SystemColors.Window;
            this.txtMerk.Location = new System.Drawing.Point(107, 169);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.ReadOnly = true;
            this.txtMerk.Size = new System.Drawing.Size(172, 20);
            this.txtMerk.TabIndex = 162;
            // 
            // lblMerk
            // 
            this.lblMerk.AutoSize = true;
            this.lblMerk.Location = new System.Drawing.Point(12, 172);
            this.lblMerk.Name = "lblMerk";
            this.lblMerk.Size = new System.Drawing.Size(37, 13);
            this.lblMerk.TabIndex = 161;
            this.lblMerk.Text = "Merk :";
            // 
            // txtTipeTrailer
            // 
            this.txtTipeTrailer.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipeTrailer.Location = new System.Drawing.Point(107, 195);
            this.txtTipeTrailer.Name = "txtTipeTrailer";
            this.txtTipeTrailer.ReadOnly = true;
            this.txtTipeTrailer.Size = new System.Drawing.Size(172, 20);
            this.txtTipeTrailer.TabIndex = 164;
            // 
            // lblTipeTrailer
            // 
            this.lblTipeTrailer.AutoSize = true;
            this.lblTipeTrailer.Location = new System.Drawing.Point(12, 198);
            this.lblTipeTrailer.Name = "lblTipeTrailer";
            this.lblTipeTrailer.Size = new System.Drawing.Size(66, 13);
            this.lblTipeTrailer.TabIndex = 163;
            this.lblTipeTrailer.Text = "Tipe Trailer :";
            // 
            // frmDaftarTunggu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 294);
            this.Controls.Add(this.txtTipeTrailer);
            this.Controls.Add(this.lblTipeTrailer);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.lblMerk);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.lblPemakaian);
            this.Controls.Add(this.lblSampai);
            this.Controls.Add(this.txtAwal);
            this.Controls.Add(this.txtAkhir);
            this.Controls.Add(this.btnNoPolisi);
            this.Controls.Add(this.txtNoPolisi);
            this.Controls.Add(this.lblNoPolisi);
            this.Controls.Add(this.txtNoPesan);
            this.Controls.Add(this.lblNoPesan);
            this.Controls.Add(this.pnlKeterangan);
            this.Controls.Add(this.tlsTombol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDaftarTunggu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informasi Daftar Tunggu";
            this.Load += new System.EventHandler(this.frmDaftarTunggu_Load);
            this.pnlKeterangan.ResumeLayout(false);
            this.pnlKeterangan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).EndInit();
            this.tlsTombol.ResumeLayout(false);
            this.tlsTombol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pnlKeterangan;
        internal System.Windows.Forms.Label lblKeterangan2;
        internal System.Windows.Forms.Label lblKeterangan1;
        internal System.Windows.Forms.PictureBox picKeterangan;
        internal System.Windows.Forms.ToolStripButton tsbRecord;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbBatal;
        internal System.Windows.Forms.ToolStripButton tsbUbah;
        internal System.Windows.Forms.ToolStrip tlsTombol;
        internal System.Windows.Forms.ToolStripButton tsbSimpan;
        internal System.Windows.Forms.ToolStripButton tsbTutup;
        internal System.Windows.Forms.TextBox txtNoPesan;
        internal System.Windows.Forms.Label lblNoPesan;
        internal System.Windows.Forms.TextBox txtNoPolisi;
        internal System.Windows.Forms.Label lblNoPolisi;
        internal System.Windows.Forms.Button btnNoPolisi;
        internal System.Windows.Forms.TextBox txtAkhir;
        internal System.Windows.Forms.TextBox txtAwal;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.Label lblPemakaian;
        internal System.Windows.Forms.Button btnPesan;
        internal System.Windows.Forms.TextBox txtMerk;
        internal System.Windows.Forms.Label lblMerk;
        internal System.Windows.Forms.TextBox txtTipeTrailer;
        internal System.Windows.Forms.Label lblTipeTrailer;
    }
}