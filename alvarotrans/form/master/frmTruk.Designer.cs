namespace alvarotrans.form.master
{
    partial class frmTruk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTruk));
            this.btnTipe = new System.Windows.Forms.Button();
            this.cboTipeTrailer = new System.Windows.Forms.ComboBox();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.lblMerk = new System.Windows.Forms.Label();
            this.txtNoRangka = new System.Windows.Forms.TextBox();
            this.lblNoRangka = new System.Windows.Forms.Label();
            this.txtNoPolisi = new System.Windows.Forms.TextBox();
            this.txtSTNK = new System.Windows.Forms.TextBox();
            this.txtNoKir = new System.Windows.Forms.TextBox();
            this.txtNoMesin = new System.Windows.Forms.TextBox();
            this.lblNoMesin = new System.Windows.Forms.Label();
            this.lblBPKB = new System.Windows.Forms.Label();
            this.lblNoKir = new System.Windows.Forms.Label();
            this.lblSTNK = new System.Windows.Forms.Label();
            this.lblTipeTrailer = new System.Windows.Forms.Label();
            this.lblNoPolisi = new System.Windows.Forms.Label();
            this.txtBPKB = new System.Windows.Forms.TextBox();
            this.lblKeterangan2 = new System.Windows.Forms.Label();
            this.pnlKeterangan = new System.Windows.Forms.Panel();
            this.lblKeterangan1 = new System.Windows.Forms.Label();
            this.picKeterangan = new System.Windows.Forms.PictureBox();
            this.tlsTombol = new System.Windows.Forms.ToolStrip();
            this.tsbSimpan = new System.Windows.Forms.ToolStripButton();
            this.tsbUbah = new System.Windows.Forms.ToolStripButton();
            this.tsbHapus = new System.Windows.Forms.ToolStripButton();
            this.tsbBatal = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRecordTruk = new System.Windows.Forms.ToolStripButton();
            this.tsbTutup = new System.Windows.Forms.ToolStripButton();
            this.btnIdSupir2 = new System.Windows.Forms.Button();
            this.btnIdSupir1 = new System.Windows.Forms.Button();
            this.txtIdSupir2 = new System.Windows.Forms.TextBox();
            this.lblIdKaryawanSupir2 = new System.Windows.Forms.Label();
            this.txtIdSupir1 = new System.Windows.Forms.TextBox();
            this.lblIdKaryawanSupir1 = new System.Windows.Forms.Label();
            this.txtNamaSupir2 = new System.Windows.Forms.TextBox();
            this.lblNamaKaryawanSupir2 = new System.Windows.Forms.Label();
            this.txtNamaSupir1 = new System.Windows.Forms.TextBox();
            this.lblNamaKaryawanSupir1 = new System.Windows.Forms.Label();
            this.lblTahunBuat = new System.Windows.Forms.Label();
            this.cboTahunBuat = new System.Windows.Forms.ComboBox();
            this.cboKondisi = new System.Windows.Forms.ComboBox();
            this.lblKondisi = new System.Windows.Forms.Label();
            this.pnlKeterangan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).BeginInit();
            this.tlsTombol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTipe
            // 
            this.btnTipe.Location = new System.Drawing.Point(262, 145);
            this.btnTipe.Name = "btnTipe";
            this.btnTipe.Size = new System.Drawing.Size(24, 21);
            this.btnTipe.TabIndex = 117;
            this.btnTipe.Text = "...";
            this.btnTipe.UseVisualStyleBackColor = true;
            this.btnTipe.Click += new System.EventHandler(this.btnTipe_Click);
            // 
            // cboTipeTrailer
            // 
            this.cboTipeTrailer.FormattingEnabled = true;
            this.cboTipeTrailer.Location = new System.Drawing.Point(114, 146);
            this.cboTipeTrailer.Name = "cboTipeTrailer";
            this.cboTipeTrailer.Size = new System.Drawing.Size(142, 21);
            this.cboTipeTrailer.TabIndex = 116;
            this.cboTipeTrailer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTipeTrailer_KeyDown);
            this.cboTipeTrailer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipeTrailer_KeyPress);
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(114, 120);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(172, 20);
            this.txtMerk.TabIndex = 115;
            // 
            // lblMerk
            // 
            this.lblMerk.AutoSize = true;
            this.lblMerk.Location = new System.Drawing.Point(12, 123);
            this.lblMerk.Name = "lblMerk";
            this.lblMerk.Size = new System.Drawing.Size(37, 13);
            this.lblMerk.TabIndex = 114;
            this.lblMerk.Text = "Merk :";
            // 
            // txtNoRangka
            // 
            this.txtNoRangka.Location = new System.Drawing.Point(114, 250);
            this.txtNoRangka.Name = "txtNoRangka";
            this.txtNoRangka.Size = new System.Drawing.Size(172, 20);
            this.txtNoRangka.TabIndex = 113;
            // 
            // lblNoRangka
            // 
            this.lblNoRangka.AutoSize = true;
            this.lblNoRangka.Location = new System.Drawing.Point(12, 253);
            this.lblNoRangka.Name = "lblNoRangka";
            this.lblNoRangka.Size = new System.Drawing.Size(71, 13);
            this.lblNoRangka.TabIndex = 112;
            this.lblNoRangka.Text = "No. Rangka :";
            // 
            // txtNoPolisi
            // 
            this.txtNoPolisi.BackColor = System.Drawing.SystemColors.Info;
            this.txtNoPolisi.Location = new System.Drawing.Point(114, 94);
            this.txtNoPolisi.Name = "txtNoPolisi";
            this.txtNoPolisi.Size = new System.Drawing.Size(172, 20);
            this.txtNoPolisi.TabIndex = 111;
            // 
            // txtSTNK
            // 
            this.txtSTNK.Location = new System.Drawing.Point(114, 198);
            this.txtSTNK.Name = "txtSTNK";
            this.txtSTNK.Size = new System.Drawing.Size(172, 20);
            this.txtSTNK.TabIndex = 110;
            // 
            // txtNoKir
            // 
            this.txtNoKir.Location = new System.Drawing.Point(114, 224);
            this.txtNoKir.Name = "txtNoKir";
            this.txtNoKir.Size = new System.Drawing.Size(172, 20);
            this.txtNoKir.TabIndex = 109;
            // 
            // txtNoMesin
            // 
            this.txtNoMesin.Location = new System.Drawing.Point(410, 94);
            this.txtNoMesin.Name = "txtNoMesin";
            this.txtNoMesin.Size = new System.Drawing.Size(172, 20);
            this.txtNoMesin.TabIndex = 107;
            // 
            // lblNoMesin
            // 
            this.lblNoMesin.AutoSize = true;
            this.lblNoMesin.Location = new System.Drawing.Point(306, 97);
            this.lblNoMesin.Name = "lblNoMesin";
            this.lblNoMesin.Size = new System.Drawing.Size(61, 13);
            this.lblNoMesin.TabIndex = 106;
            this.lblNoMesin.Text = "No. Mesin :";
            // 
            // lblBPKB
            // 
            this.lblBPKB.AutoSize = true;
            this.lblBPKB.Location = new System.Drawing.Point(12, 279);
            this.lblBPKB.Name = "lblBPKB";
            this.lblBPKB.Size = new System.Drawing.Size(61, 13);
            this.lblBPKB.TabIndex = 105;
            this.lblBPKB.Text = "No. BPKB :";
            // 
            // lblNoKir
            // 
            this.lblNoKir.AutoSize = true;
            this.lblNoKir.Location = new System.Drawing.Point(12, 227);
            this.lblNoKir.Name = "lblNoKir";
            this.lblNoKir.Size = new System.Drawing.Size(45, 13);
            this.lblNoKir.TabIndex = 104;
            this.lblNoKir.Text = "No. Kir :";
            // 
            // lblSTNK
            // 
            this.lblSTNK.AutoSize = true;
            this.lblSTNK.Location = new System.Drawing.Point(12, 201);
            this.lblSTNK.Name = "lblSTNK";
            this.lblSTNK.Size = new System.Drawing.Size(62, 13);
            this.lblSTNK.TabIndex = 103;
            this.lblSTNK.Text = "No. STNK :";
            // 
            // lblTipeTrailer
            // 
            this.lblTipeTrailer.AutoSize = true;
            this.lblTipeTrailer.Location = new System.Drawing.Point(12, 149);
            this.lblTipeTrailer.Name = "lblTipeTrailer";
            this.lblTipeTrailer.Size = new System.Drawing.Size(66, 13);
            this.lblTipeTrailer.TabIndex = 102;
            this.lblTipeTrailer.Text = "Tipe Trailer :";
            // 
            // lblNoPolisi
            // 
            this.lblNoPolisi.AutoSize = true;
            this.lblNoPolisi.Location = new System.Drawing.Point(12, 97);
            this.lblNoPolisi.Name = "lblNoPolisi";
            this.lblNoPolisi.Size = new System.Drawing.Size(57, 13);
            this.lblNoPolisi.TabIndex = 101;
            this.lblNoPolisi.Text = "No. Polisi :";
            // 
            // txtBPKB
            // 
            this.txtBPKB.Location = new System.Drawing.Point(114, 276);
            this.txtBPKB.Name = "txtBPKB";
            this.txtBPKB.Size = new System.Drawing.Size(172, 20);
            this.txtBPKB.TabIndex = 108;
            // 
            // lblKeterangan2
            // 
            this.lblKeterangan2.Location = new System.Drawing.Point(66, 33);
            this.lblKeterangan2.Name = "lblKeterangan2";
            this.lblKeterangan2.Size = new System.Drawing.Size(514, 27);
            this.lblKeterangan2.TabIndex = 2;
            this.lblKeterangan2.Text = "Form ini digunakan untuk menyimpan data-data truk petikemas yang dimiliki oleh CV" +
    ". Alvaro Trans Cargo.";
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
            this.pnlKeterangan.Size = new System.Drawing.Size(601, 78);
            this.pnlKeterangan.TabIndex = 99;
            // 
            // lblKeterangan1
            // 
            this.lblKeterangan1.AutoSize = true;
            this.lblKeterangan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan1.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan1.Location = new System.Drawing.Point(66, 10);
            this.lblKeterangan1.Name = "lblKeterangan1";
            this.lblKeterangan1.Size = new System.Drawing.Size(76, 16);
            this.lblKeterangan1.TabIndex = 1;
            this.lblKeterangan1.Text = "Data Truk";
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
            this.tsbRecordTruk,
            this.tsbTutup});
            this.tlsTombol.Location = new System.Drawing.Point(0, 332);
            this.tlsTombol.Name = "tlsTombol";
            this.tlsTombol.Size = new System.Drawing.Size(601, 25);
            this.tlsTombol.TabIndex = 100;
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
            // tsbRecordTruk
            // 
            this.tsbRecordTruk.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecordTruk.Image")));
            this.tsbRecordTruk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecordTruk.Name = "tsbRecordTruk";
            this.tsbRecordTruk.Size = new System.Drawing.Size(91, 22);
            this.tsbRecordTruk.Text = "Record Truk";
            this.tsbRecordTruk.Click += new System.EventHandler(this.tsbRecordTruk_Click);
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
            // btnIdSupir2
            // 
            this.btnIdSupir2.Location = new System.Drawing.Point(558, 171);
            this.btnIdSupir2.Name = "btnIdSupir2";
            this.btnIdSupir2.Size = new System.Drawing.Size(24, 21);
            this.btnIdSupir2.TabIndex = 127;
            this.btnIdSupir2.Text = "...";
            this.btnIdSupir2.UseVisualStyleBackColor = true;
            this.btnIdSupir2.Click += new System.EventHandler(this.btnIdSupir2_Click);
            // 
            // btnIdSupir1
            // 
            this.btnIdSupir1.Location = new System.Drawing.Point(558, 119);
            this.btnIdSupir1.Name = "btnIdSupir1";
            this.btnIdSupir1.Size = new System.Drawing.Size(24, 21);
            this.btnIdSupir1.TabIndex = 126;
            this.btnIdSupir1.Text = "...";
            this.btnIdSupir1.UseVisualStyleBackColor = true;
            this.btnIdSupir1.Click += new System.EventHandler(this.btnIdSupir1_Click);
            // 
            // txtIdSupir2
            // 
            this.txtIdSupir2.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdSupir2.Enabled = false;
            this.txtIdSupir2.Location = new System.Drawing.Point(410, 172);
            this.txtIdSupir2.Name = "txtIdSupir2";
            this.txtIdSupir2.Size = new System.Drawing.Size(142, 20);
            this.txtIdSupir2.TabIndex = 125;
            this.txtIdSupir2.TextChanged += new System.EventHandler(this.txtIdSupir2_TextChanged);
            // 
            // lblIdKaryawanSupir2
            // 
            this.lblIdKaryawanSupir2.AutoSize = true;
            this.lblIdKaryawanSupir2.Location = new System.Drawing.Point(306, 175);
            this.lblIdKaryawanSupir2.Name = "lblIdKaryawanSupir2";
            this.lblIdKaryawanSupir2.Size = new System.Drawing.Size(60, 13);
            this.lblIdKaryawanSupir2.TabIndex = 124;
            this.lblIdKaryawanSupir2.Text = "ID Supir 2 :";
            // 
            // txtIdSupir1
            // 
            this.txtIdSupir1.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdSupir1.Enabled = false;
            this.txtIdSupir1.Location = new System.Drawing.Point(410, 120);
            this.txtIdSupir1.Name = "txtIdSupir1";
            this.txtIdSupir1.Size = new System.Drawing.Size(142, 20);
            this.txtIdSupir1.TabIndex = 123;
            this.txtIdSupir1.TextChanged += new System.EventHandler(this.txtIdSupir1_TextChanged);
            // 
            // lblIdKaryawanSupir1
            // 
            this.lblIdKaryawanSupir1.AutoSize = true;
            this.lblIdKaryawanSupir1.Location = new System.Drawing.Point(306, 123);
            this.lblIdKaryawanSupir1.Name = "lblIdKaryawanSupir1";
            this.lblIdKaryawanSupir1.Size = new System.Drawing.Size(57, 13);
            this.lblIdKaryawanSupir1.TabIndex = 122;
            this.lblIdKaryawanSupir1.Text = "ID Supir 1:";
            // 
            // txtNamaSupir2
            // 
            this.txtNamaSupir2.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamaSupir2.Location = new System.Drawing.Point(410, 198);
            this.txtNamaSupir2.Name = "txtNamaSupir2";
            this.txtNamaSupir2.ReadOnly = true;
            this.txtNamaSupir2.Size = new System.Drawing.Size(172, 20);
            this.txtNamaSupir2.TabIndex = 121;
            // 
            // lblNamaKaryawanSupir2
            // 
            this.lblNamaKaryawanSupir2.AutoSize = true;
            this.lblNamaKaryawanSupir2.Location = new System.Drawing.Point(306, 201);
            this.lblNamaKaryawanSupir2.Name = "lblNamaKaryawanSupir2";
            this.lblNamaKaryawanSupir2.Size = new System.Drawing.Size(77, 13);
            this.lblNamaKaryawanSupir2.TabIndex = 120;
            this.lblNamaKaryawanSupir2.Text = "Nama Supir 2 :";
            // 
            // txtNamaSupir1
            // 
            this.txtNamaSupir1.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamaSupir1.Location = new System.Drawing.Point(410, 146);
            this.txtNamaSupir1.Name = "txtNamaSupir1";
            this.txtNamaSupir1.ReadOnly = true;
            this.txtNamaSupir1.Size = new System.Drawing.Size(172, 20);
            this.txtNamaSupir1.TabIndex = 119;
            // 
            // lblNamaKaryawanSupir1
            // 
            this.lblNamaKaryawanSupir1.AutoSize = true;
            this.lblNamaKaryawanSupir1.Location = new System.Drawing.Point(306, 150);
            this.lblNamaKaryawanSupir1.Name = "lblNamaKaryawanSupir1";
            this.lblNamaKaryawanSupir1.Size = new System.Drawing.Size(77, 13);
            this.lblNamaKaryawanSupir1.TabIndex = 118;
            this.lblNamaKaryawanSupir1.Text = "Nama Supir 1 :";
            // 
            // lblTahunBuat
            // 
            this.lblTahunBuat.AutoSize = true;
            this.lblTahunBuat.Location = new System.Drawing.Point(12, 175);
            this.lblTahunBuat.Name = "lblTahunBuat";
            this.lblTahunBuat.Size = new System.Drawing.Size(69, 13);
            this.lblTahunBuat.TabIndex = 128;
            this.lblTahunBuat.Text = "Tahun Buat :";
            // 
            // cboTahunBuat
            // 
            this.cboTahunBuat.FormattingEnabled = true;
            this.cboTahunBuat.Location = new System.Drawing.Point(114, 173);
            this.cboTahunBuat.Name = "cboTahunBuat";
            this.cboTahunBuat.Size = new System.Drawing.Size(142, 21);
            this.cboTahunBuat.TabIndex = 129;
            this.cboTahunBuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTahunBuat_KeyDown);
            this.cboTahunBuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTahunBuat_KeyPress);
            // 
            // cboKondisi
            // 
            this.cboKondisi.FormattingEnabled = true;
            this.cboKondisi.Items.AddRange(new object[] {
            "",
            "Baik",
            "Perbaikan",
            "Perawatan",
            "Rusak"});
            this.cboKondisi.Location = new System.Drawing.Point(410, 224);
            this.cboKondisi.Name = "cboKondisi";
            this.cboKondisi.Size = new System.Drawing.Size(142, 21);
            this.cboKondisi.TabIndex = 131;
            this.cboKondisi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboKondisi_KeyDown);
            this.cboKondisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboKondisi_KeyPress);
            // 
            // lblKondisi
            // 
            this.lblKondisi.AutoSize = true;
            this.lblKondisi.Location = new System.Drawing.Point(306, 227);
            this.lblKondisi.Name = "lblKondisi";
            this.lblKondisi.Size = new System.Drawing.Size(47, 13);
            this.lblKondisi.TabIndex = 130;
            this.lblKondisi.Text = "Kondisi :";
            // 
            // frmTruk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 357);
            this.Controls.Add(this.cboKondisi);
            this.Controls.Add(this.lblKondisi);
            this.Controls.Add(this.cboTahunBuat);
            this.Controls.Add(this.lblTahunBuat);
            this.Controls.Add(this.btnIdSupir2);
            this.Controls.Add(this.btnIdSupir1);
            this.Controls.Add(this.txtIdSupir2);
            this.Controls.Add(this.lblIdKaryawanSupir2);
            this.Controls.Add(this.txtIdSupir1);
            this.Controls.Add(this.lblIdKaryawanSupir1);
            this.Controls.Add(this.txtNamaSupir2);
            this.Controls.Add(this.lblNamaKaryawanSupir2);
            this.Controls.Add(this.txtNamaSupir1);
            this.Controls.Add(this.lblNamaKaryawanSupir1);
            this.Controls.Add(this.btnTipe);
            this.Controls.Add(this.cboTipeTrailer);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.lblMerk);
            this.Controls.Add(this.txtNoRangka);
            this.Controls.Add(this.lblNoRangka);
            this.Controls.Add(this.txtNoPolisi);
            this.Controls.Add(this.txtSTNK);
            this.Controls.Add(this.txtNoKir);
            this.Controls.Add(this.txtNoMesin);
            this.Controls.Add(this.lblNoMesin);
            this.Controls.Add(this.lblBPKB);
            this.Controls.Add(this.lblNoKir);
            this.Controls.Add(this.lblSTNK);
            this.Controls.Add(this.lblTipeTrailer);
            this.Controls.Add(this.lblNoPolisi);
            this.Controls.Add(this.txtBPKB);
            this.Controls.Add(this.pnlKeterangan);
            this.Controls.Add(this.tlsTombol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTruk";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informasi Truk";
            this.Load += new System.EventHandler(this.frmTruk_Load);
            this.pnlKeterangan.ResumeLayout(false);
            this.pnlKeterangan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).EndInit();
            this.tlsTombol.ResumeLayout(false);
            this.tlsTombol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnTipe;
        internal System.Windows.Forms.ComboBox cboTipeTrailer;
        internal System.Windows.Forms.TextBox txtMerk;
        internal System.Windows.Forms.Label lblMerk;
        internal System.Windows.Forms.TextBox txtNoRangka;
        internal System.Windows.Forms.Label lblNoRangka;
        internal System.Windows.Forms.TextBox txtNoPolisi;
        internal System.Windows.Forms.TextBox txtSTNK;
        internal System.Windows.Forms.TextBox txtNoKir;
        internal System.Windows.Forms.TextBox txtNoMesin;
        internal System.Windows.Forms.Label lblNoMesin;
        internal System.Windows.Forms.Label lblBPKB;
        internal System.Windows.Forms.Label lblNoKir;
        internal System.Windows.Forms.Label lblSTNK;
        internal System.Windows.Forms.Label lblTipeTrailer;
        internal System.Windows.Forms.Label lblNoPolisi;
        internal System.Windows.Forms.TextBox txtBPKB;
        internal System.Windows.Forms.Label lblKeterangan2;
        internal System.Windows.Forms.Panel pnlKeterangan;
        internal System.Windows.Forms.Label lblKeterangan1;
        internal System.Windows.Forms.PictureBox picKeterangan;
        internal System.Windows.Forms.ToolStrip tlsTombol;
        internal System.Windows.Forms.ToolStripButton tsbSimpan;
        internal System.Windows.Forms.ToolStripButton tsbUbah;
        internal System.Windows.Forms.ToolStripButton tsbHapus;
        internal System.Windows.Forms.ToolStripButton tsbBatal;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbRecordTruk;
        internal System.Windows.Forms.ToolStripButton tsbTutup;
        internal System.Windows.Forms.Button btnIdSupir2;
        internal System.Windows.Forms.Button btnIdSupir1;
        internal System.Windows.Forms.TextBox txtIdSupir2;
        internal System.Windows.Forms.Label lblIdKaryawanSupir2;
        internal System.Windows.Forms.TextBox txtIdSupir1;
        internal System.Windows.Forms.Label lblIdKaryawanSupir1;
        internal System.Windows.Forms.TextBox txtNamaSupir2;
        internal System.Windows.Forms.Label lblNamaKaryawanSupir2;
        internal System.Windows.Forms.TextBox txtNamaSupir1;
        internal System.Windows.Forms.Label lblNamaKaryawanSupir1;
        internal System.Windows.Forms.Label lblTahunBuat;
        private System.Windows.Forms.ComboBox cboTahunBuat;
        internal System.Windows.Forms.ComboBox cboKondisi;
        internal System.Windows.Forms.Label lblKondisi;
    }
}