namespace alvarotrans.form.record
{
    partial class frmTipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipe));
            this.lblKeterangan2 = new System.Windows.Forms.Label();
            this.lblKeterangan1 = new System.Windows.Forms.Label();
            this.dgvPilihan = new System.Windows.Forms.DataGridView();
            this.pnlKeterangan = new System.Windows.Forms.Panel();
            this.picKeterangan = new System.Windows.Forms.PictureBox();
            this.lblKeterangan3 = new System.Windows.Forms.Label();
            this.lblPilihan = new System.Windows.Forms.Label();
            this.txtPilihan = new System.Windows.Forms.TextBox();
            this.tlsTombol = new System.Windows.Forms.ToolStrip();
            this.tsbSimpan = new System.Windows.Forms.ToolStripButton();
            this.tsbUbah = new System.Windows.Forms.ToolStripButton();
            this.tsbHapus = new System.Windows.Forms.ToolStripButton();
            this.tsbBatal = new System.Windows.Forms.ToolStripButton();
            this.tsbTutup = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilihan)).BeginInit();
            this.pnlKeterangan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).BeginInit();
            this.tlsTombol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKeterangan2
            // 
            this.lblKeterangan2.Location = new System.Drawing.Point(66, 33);
            this.lblKeterangan2.Name = "lblKeterangan2";
            this.lblKeterangan2.Size = new System.Drawing.Size(251, 47);
            this.lblKeterangan2.TabIndex = 2;
            this.lblKeterangan2.Text = ".....";
            // 
            // lblKeterangan1
            // 
            this.lblKeterangan1.AutoSize = true;
            this.lblKeterangan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan1.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan1.Location = new System.Drawing.Point(66, 10);
            this.lblKeterangan1.Name = "lblKeterangan1";
            this.lblKeterangan1.Size = new System.Drawing.Size(28, 16);
            this.lblKeterangan1.TabIndex = 1;
            this.lblKeterangan1.Text = ".....";
            // 
            // dgvPilihan
            // 
            this.dgvPilihan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilihan.Location = new System.Drawing.Point(2, 104);
            this.dgvPilihan.Name = "dgvPilihan";
            this.dgvPilihan.Size = new System.Drawing.Size(331, 302);
            this.dgvPilihan.TabIndex = 35;
            this.dgvPilihan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPilihan_CellDoubleClick);
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
            this.pnlKeterangan.Size = new System.Drawing.Size(332, 98);
            this.pnlKeterangan.TabIndex = 33;
            // 
            // picKeterangan
            // 
            this.picKeterangan.Image = ((System.Drawing.Image)(resources.GetObject("picKeterangan.Image")));
            this.picKeterangan.Location = new System.Drawing.Point(10, 10);
            this.picKeterangan.Name = "picKeterangan";
            this.picKeterangan.Size = new System.Drawing.Size(48, 48);
            this.picKeterangan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picKeterangan.TabIndex = 0;
            this.picKeterangan.TabStop = false;
            // 
            // lblKeterangan3
            // 
            this.lblKeterangan3.AutoSize = true;
            this.lblKeterangan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan3.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan3.Location = new System.Drawing.Point(102, 435);
            this.lblKeterangan3.Name = "lblKeterangan3";
            this.lblKeterangan3.Size = new System.Drawing.Size(16, 13);
            this.lblKeterangan3.TabIndex = 38;
            this.lblKeterangan3.Text = "...";
            // 
            // lblPilihan
            // 
            this.lblPilihan.AutoSize = true;
            this.lblPilihan.Location = new System.Drawing.Point(13, 415);
            this.lblPilihan.Name = "lblPilihan";
            this.lblPilihan.Size = new System.Drawing.Size(22, 13);
            this.lblPilihan.TabIndex = 37;
            this.lblPilihan.Text = "... :";
            // 
            // txtPilihan
            // 
            this.txtPilihan.Location = new System.Drawing.Point(105, 412);
            this.txtPilihan.Name = "txtPilihan";
            this.txtPilihan.Size = new System.Drawing.Size(215, 20);
            this.txtPilihan.TabIndex = 36;
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
            this.tsbTutup});
            this.tlsTombol.Location = new System.Drawing.Point(0, 458);
            this.tlsTombol.Name = "tlsTombol";
            this.tlsTombol.Size = new System.Drawing.Size(332, 25);
            this.tlsTombol.TabIndex = 34;
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
            // frmTipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 483);
            this.Controls.Add(this.dgvPilihan);
            this.Controls.Add(this.pnlKeterangan);
            this.Controls.Add(this.lblKeterangan3);
            this.Controls.Add(this.lblPilihan);
            this.Controls.Add(this.txtPilihan);
            this.Controls.Add(this.tlsTombol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipe";
            this.Activated += new System.EventHandler(this.frmTipe_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTipe_FormClosing);
            this.Load += new System.EventHandler(this.frmTipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilihan)).EndInit();
            this.pnlKeterangan.ResumeLayout(false);
            this.pnlKeterangan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeterangan)).EndInit();
            this.tlsTombol.ResumeLayout(false);
            this.tlsTombol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblKeterangan2;
        internal System.Windows.Forms.Label lblKeterangan1;
        internal System.Windows.Forms.DataGridView dgvPilihan;
        internal System.Windows.Forms.Panel pnlKeterangan;
        internal System.Windows.Forms.PictureBox picKeterangan;
        internal System.Windows.Forms.Label lblKeterangan3;
        internal System.Windows.Forms.Label lblPilihan;
        internal System.Windows.Forms.TextBox txtPilihan;
        internal System.Windows.Forms.ToolStrip tlsTombol;
        internal System.Windows.Forms.ToolStripButton tsbSimpan;
        internal System.Windows.Forms.ToolStripButton tsbUbah;
        internal System.Windows.Forms.ToolStripButton tsbHapus;
        internal System.Windows.Forms.ToolStripButton tsbBatal;
        internal System.Windows.Forms.ToolStripButton tsbTutup;
    }
}