namespace alvarotrans.form.transaksi
{
    partial class frmTransport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransport));
            this.pnlKeterangan = new System.Windows.Forms.Panel();
            this.lblKeterangan2 = new System.Windows.Forms.Label();
            this.lblKeterangan1 = new System.Windows.Forms.Label();
            this.picKeterangan = new System.Windows.Forms.PictureBox();
            this.tsbTutup = new System.Windows.Forms.ToolStripButton();
            this.tlsTombol = new System.Windows.Forms.ToolStrip();
            this.tsbSimpan = new System.Windows.Forms.ToolStripButton();
            this.tsbBatal = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRecord = new System.Windows.Forms.ToolStripButton();
            this.tsbCetak = new System.Windows.Forms.ToolStripButton();
            this.gbxTransport = new System.Windows.Forms.GroupBox();
            this.txtNamaKaryawanKeuangan = new System.Windows.Forms.TextBox();
            this.txtIdKaryawanKeuangan = new System.Windows.Forms.TextBox();
            this.lblNamaKaryawanKeuangan = new System.Windows.Forms.Label();
            this.lblIdKaryawanKeuangan = new System.Windows.Forms.Label();
            this.gbxPengiriman = new System.Windows.Forms.GroupBox();
            this.txtNoKirim = new System.Windows.Forms.TextBox();
            this.txtNamaSupir2 = new System.Windows.Forms.TextBox();
            this.btnNoKirim = new System.Windows.Forms.Button();
            this.txtNamaSupir1 = new System.Windows.Forms.TextBox();
            this.lblNoKirim = new System.Windows.Forms.Label();
            this.lblNamaSupir2 = new System.Windows.Forms.Label();
            this.txtTrasport = new System.Windows.Forms.TextBox();
            this.lblNamaSupir1 = new System.Windows.Forms.Label();
            this.lblTransport = new System.Windows.Forms.Label();
            this.txtNoTransport = new System.Windows.Forms.TextBox();
            this.txtTglTransport = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblNoTransport = new System.Windows.Forms.Label();
            this.pnlKeterangan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).BeginInit();
            this.tlsTombol.SuspendLayout();
            this.gbxTransport.SuspendLayout();
            this.gbxPengiriman.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlKeterangan.Size = new System.Drawing.Size(665, 78);
            this.pnlKeterangan.TabIndex = 77;
            // 
            // lblKeterangan2
            // 
            this.lblKeterangan2.Location = new System.Drawing.Point(66, 33);
            this.lblKeterangan2.Name = "lblKeterangan2";
            this.lblKeterangan2.Size = new System.Drawing.Size(446, 27);
            this.lblKeterangan2.TabIndex = 2;
            this.lblKeterangan2.Text = "Form ini digunakan untuk mencatat data kas keluar untuk biaya transport pengirima" +
    "n barang.\r\n";
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
            this.lblKeterangan1.Text = "Data Transport";
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
            this.tsbBatal,
            this.ToolStripSeparator1,
            this.tsbRecord,
            this.tsbTutup,
            this.tsbCetak});
            this.tlsTombol.Location = new System.Drawing.Point(0, 267);
            this.tlsTombol.Name = "tlsTombol";
            this.tlsTombol.Size = new System.Drawing.Size(631, 25);
            this.tlsTombol.TabIndex = 78;
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
            // tsbRecord
            // 
            this.tsbRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecord.Image")));
            this.tsbRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecord.Name = "tsbRecord";
            this.tsbRecord.Size = new System.Drawing.Size(118, 22);
            this.tsbRecord.Text = "Record Transport";
            this.tsbRecord.Click += new System.EventHandler(this.tsbRecord_Click);
            // 
            // tsbCetak
            // 
            this.tsbCetak.Image = ((System.Drawing.Image)(resources.GetObject("tsbCetak.Image")));
            this.tsbCetak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCetak.Name = "tsbCetak";
            this.tsbCetak.Size = new System.Drawing.Size(57, 22);
            this.tsbCetak.Text = "Cetak";
            this.tsbCetak.Click += new System.EventHandler(this.tsbCetak_Click);
            // 
            // gbxTransport
            // 
            this.gbxTransport.Controls.Add(this.txtNamaKaryawanKeuangan);
            this.gbxTransport.Controls.Add(this.txtIdKaryawanKeuangan);
            this.gbxTransport.Controls.Add(this.lblNamaKaryawanKeuangan);
            this.gbxTransport.Controls.Add(this.lblIdKaryawanKeuangan);
            this.gbxTransport.Controls.Add(this.gbxPengiriman);
            this.gbxTransport.Controls.Add(this.txtNoTransport);
            this.gbxTransport.Controls.Add(this.txtTglTransport);
            this.gbxTransport.Controls.Add(this.lblTanggal);
            this.gbxTransport.Controls.Add(this.lblNoTransport);
            this.gbxTransport.Location = new System.Drawing.Point(12, 84);
            this.gbxTransport.Name = "gbxTransport";
            this.gbxTransport.Size = new System.Drawing.Size(607, 164);
            this.gbxTransport.TabIndex = 79;
            this.gbxTransport.TabStop = false;
            this.gbxTransport.Text = "Data Transport";
            // 
            // txtNamaKaryawanKeuangan
            // 
            this.txtNamaKaryawanKeuangan.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamaKaryawanKeuangan.Location = new System.Drawing.Point(108, 97);
            this.txtNamaKaryawanKeuangan.Name = "txtNamaKaryawanKeuangan";
            this.txtNamaKaryawanKeuangan.ReadOnly = true;
            this.txtNamaKaryawanKeuangan.Size = new System.Drawing.Size(175, 20);
            this.txtNamaKaryawanKeuangan.TabIndex = 188;
            // 
            // txtIdKaryawanKeuangan
            // 
            this.txtIdKaryawanKeuangan.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdKaryawanKeuangan.Enabled = false;
            this.txtIdKaryawanKeuangan.Location = new System.Drawing.Point(108, 71);
            this.txtIdKaryawanKeuangan.Name = "txtIdKaryawanKeuangan";
            this.txtIdKaryawanKeuangan.Size = new System.Drawing.Size(175, 20);
            this.txtIdKaryawanKeuangan.TabIndex = 187;
            // 
            // lblNamaKaryawanKeuangan
            // 
            this.lblNamaKaryawanKeuangan.AutoSize = true;
            this.lblNamaKaryawanKeuangan.Location = new System.Drawing.Point(6, 100);
            this.lblNamaKaryawanKeuangan.Name = "lblNamaKaryawanKeuangan";
            this.lblNamaKaryawanKeuangan.Size = new System.Drawing.Size(93, 13);
            this.lblNamaKaryawanKeuangan.TabIndex = 186;
            this.lblNamaKaryawanKeuangan.Text = "Nama Keuangan :";
            // 
            // lblIdKaryawanKeuangan
            // 
            this.lblIdKaryawanKeuangan.AutoSize = true;
            this.lblIdKaryawanKeuangan.Location = new System.Drawing.Point(6, 74);
            this.lblIdKaryawanKeuangan.Name = "lblIdKaryawanKeuangan";
            this.lblIdKaryawanKeuangan.Size = new System.Drawing.Size(76, 13);
            this.lblIdKaryawanKeuangan.TabIndex = 185;
            this.lblIdKaryawanKeuangan.Text = "ID Keuangan :";
            // 
            // gbxPengiriman
            // 
            this.gbxPengiriman.Controls.Add(this.txtNoKirim);
            this.gbxPengiriman.Controls.Add(this.txtNamaSupir2);
            this.gbxPengiriman.Controls.Add(this.btnNoKirim);
            this.gbxPengiriman.Controls.Add(this.txtNamaSupir1);
            this.gbxPengiriman.Controls.Add(this.lblNoKirim);
            this.gbxPengiriman.Controls.Add(this.lblNamaSupir2);
            this.gbxPengiriman.Controls.Add(this.txtTrasport);
            this.gbxPengiriman.Controls.Add(this.lblNamaSupir1);
            this.gbxPengiriman.Controls.Add(this.lblTransport);
            this.gbxPengiriman.Location = new System.Drawing.Point(308, 19);
            this.gbxPengiriman.Name = "gbxPengiriman";
            this.gbxPengiriman.Size = new System.Drawing.Size(288, 135);
            this.gbxPengiriman.TabIndex = 184;
            this.gbxPengiriman.TabStop = false;
            this.gbxPengiriman.Text = "Data Pengiriman";
            // 
            // txtNoKirim
            // 
            this.txtNoKirim.BackColor = System.Drawing.SystemColors.Info;
            this.txtNoKirim.Enabled = false;
            this.txtNoKirim.Location = new System.Drawing.Point(108, 23);
            this.txtNoKirim.Name = "txtNoKirim";
            this.txtNoKirim.Size = new System.Drawing.Size(145, 20);
            this.txtNoKirim.TabIndex = 172;
            // 
            // txtNamaSupir2
            // 
            this.txtNamaSupir2.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamaSupir2.Location = new System.Drawing.Point(108, 75);
            this.txtNamaSupir2.Name = "txtNamaSupir2";
            this.txtNamaSupir2.ReadOnly = true;
            this.txtNamaSupir2.Size = new System.Drawing.Size(175, 20);
            this.txtNamaSupir2.TabIndex = 183;
            // 
            // btnNoKirim
            // 
            this.btnNoKirim.Location = new System.Drawing.Point(259, 22);
            this.btnNoKirim.Name = "btnNoKirim";
            this.btnNoKirim.Size = new System.Drawing.Size(24, 21);
            this.btnNoKirim.TabIndex = 173;
            this.btnNoKirim.Text = "...";
            this.btnNoKirim.UseVisualStyleBackColor = true;
            this.btnNoKirim.Click += new System.EventHandler(this.btnNoKirim_Click);
            // 
            // txtNamaSupir1
            // 
            this.txtNamaSupir1.BackColor = System.Drawing.SystemColors.Info;
            this.txtNamaSupir1.Enabled = false;
            this.txtNamaSupir1.Location = new System.Drawing.Point(108, 49);
            this.txtNamaSupir1.Name = "txtNamaSupir1";
            this.txtNamaSupir1.Size = new System.Drawing.Size(175, 20);
            this.txtNamaSupir1.TabIndex = 182;
            // 
            // lblNoKirim
            // 
            this.lblNoKirim.AutoSize = true;
            this.lblNoKirim.Location = new System.Drawing.Point(6, 26);
            this.lblNoKirim.Name = "lblNoKirim";
            this.lblNoKirim.Size = new System.Drawing.Size(85, 13);
            this.lblNoKirim.TabIndex = 176;
            this.lblNoKirim.Text = "No. Pengiriman :";
            // 
            // lblNamaSupir2
            // 
            this.lblNamaSupir2.AutoSize = true;
            this.lblNamaSupir2.Location = new System.Drawing.Point(6, 78);
            this.lblNamaSupir2.Name = "lblNamaSupir2";
            this.lblNamaSupir2.Size = new System.Drawing.Size(77, 13);
            this.lblNamaSupir2.TabIndex = 181;
            this.lblNamaSupir2.Text = "Nama Supir 2 :";
            // 
            // txtTrasport
            // 
            this.txtTrasport.BackColor = System.Drawing.SystemColors.Window;
            this.txtTrasport.Location = new System.Drawing.Point(108, 101);
            this.txtTrasport.Name = "txtTrasport";
            this.txtTrasport.ReadOnly = true;
            this.txtTrasport.Size = new System.Drawing.Size(175, 20);
            this.txtTrasport.TabIndex = 178;
            this.txtTrasport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNamaSupir1
            // 
            this.lblNamaSupir1.AutoSize = true;
            this.lblNamaSupir1.Location = new System.Drawing.Point(6, 52);
            this.lblNamaSupir1.Name = "lblNamaSupir1";
            this.lblNamaSupir1.Size = new System.Drawing.Size(77, 13);
            this.lblNamaSupir1.TabIndex = 180;
            this.lblNamaSupir1.Text = "Nama Supir 1 :";
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(6, 104);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(52, 13);
            this.lblTransport.TabIndex = 179;
            this.lblTransport.Text = "Trasport :";
            // 
            // txtNoTransport
            // 
            this.txtNoTransport.BackColor = System.Drawing.SystemColors.Info;
            this.txtNoTransport.Enabled = false;
            this.txtNoTransport.Location = new System.Drawing.Point(108, 19);
            this.txtNoTransport.Name = "txtNoTransport";
            this.txtNoTransport.Size = new System.Drawing.Size(175, 20);
            this.txtNoTransport.TabIndex = 177;
            // 
            // txtTglTransport
            // 
            this.txtTglTransport.BackColor = System.Drawing.SystemColors.Window;
            this.txtTglTransport.Location = new System.Drawing.Point(108, 45);
            this.txtTglTransport.Name = "txtTglTransport";
            this.txtTglTransport.ReadOnly = true;
            this.txtTglTransport.Size = new System.Drawing.Size(100, 20);
            this.txtTglTransport.TabIndex = 175;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(6, 48);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(55, 13);
            this.lblTanggal.TabIndex = 174;
            this.lblTanggal.Text = "Tanggal  :";
            // 
            // lblNoTransport
            // 
            this.lblNoTransport.AutoSize = true;
            this.lblNoTransport.Location = new System.Drawing.Point(6, 22);
            this.lblNoTransport.Name = "lblNoTransport";
            this.lblNoTransport.Size = new System.Drawing.Size(78, 13);
            this.lblNoTransport.TabIndex = 171;
            this.lblNoTransport.Text = "No. Transport :";
            // 
            // frmTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 292);
            this.Controls.Add(this.gbxTransport);
            this.Controls.Add(this.pnlKeterangan);
            this.Controls.Add(this.tlsTombol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informasi Transport";
            this.Load += new System.EventHandler(this.frmTransport_Load);
            this.pnlKeterangan.ResumeLayout(false);
            this.pnlKeterangan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).EndInit();
            this.tlsTombol.ResumeLayout(false);
            this.tlsTombol.PerformLayout();
            this.gbxTransport.ResumeLayout(false);
            this.gbxTransport.PerformLayout();
            this.gbxPengiriman.ResumeLayout(false);
            this.gbxPengiriman.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pnlKeterangan;
        internal System.Windows.Forms.Label lblKeterangan2;
        internal System.Windows.Forms.Label lblKeterangan1;
        internal System.Windows.Forms.PictureBox picKeterangan;
        internal System.Windows.Forms.ToolStripButton tsbTutup;
        internal System.Windows.Forms.ToolStrip tlsTombol;
        internal System.Windows.Forms.ToolStripButton tsbSimpan;
        internal System.Windows.Forms.ToolStripButton tsbBatal;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbRecord;
        internal System.Windows.Forms.ToolStripButton tsbCetak;
        private System.Windows.Forms.GroupBox gbxTransport;
        private System.Windows.Forms.GroupBox gbxPengiriman;
        internal System.Windows.Forms.TextBox txtNamaSupir2;
        internal System.Windows.Forms.TextBox txtNamaSupir1;
        internal System.Windows.Forms.Label lblNamaSupir2;
        internal System.Windows.Forms.Label lblNamaSupir1;
        internal System.Windows.Forms.Label lblTransport;
        internal System.Windows.Forms.TextBox txtTrasport;
        internal System.Windows.Forms.TextBox txtNoTransport;
        private System.Windows.Forms.Label lblNoKirim;
        internal System.Windows.Forms.TextBox txtTglTransport;
        internal System.Windows.Forms.Label lblTanggal;
        internal System.Windows.Forms.Button btnNoKirim;
        internal System.Windows.Forms.TextBox txtNoKirim;
        internal System.Windows.Forms.Label lblNoTransport;
        internal System.Windows.Forms.TextBox txtNamaKaryawanKeuangan;
        internal System.Windows.Forms.TextBox txtIdKaryawanKeuangan;
        internal System.Windows.Forms.Label lblNamaKaryawanKeuangan;
        internal System.Windows.Forms.Label lblIdKaryawanKeuangan;
    }
}