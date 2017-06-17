namespace alvarotrans.form.record
{
    partial class frmData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmData));
            this.btnTutup = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblCari = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblSampai = new System.Windows.Forms.Label();
            this.dtpAkhir = new System.Windows.Forms.DateTimePicker();
            this.dtpAwal = new System.Windows.Forms.DateTimePicker();
            this.lblPemakaian = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(761, 479);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 49;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(62, 481);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(200, 20);
            this.txtCari.TabIndex = 48;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan.Location = new System.Drawing.Point(268, 484);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(16, 13);
            this.lblKeterangan.TabIndex = 47;
            this.lblKeterangan.Text = "...";
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(9, 484);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(31, 13);
            this.lblCari.TabIndex = 46;
            this.lblCari.Text = "Cari :";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(9, 9);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(827, 464);
            this.dgvData.TabIndex = 45;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellDoubleClick);
            // 
            // lblSampai
            // 
            this.lblSampai.AutoSize = true;
            this.lblSampai.Location = new System.Drawing.Point(153, 25);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.Size = new System.Drawing.Size(23, 13);
            this.lblSampai.TabIndex = 53;
            this.lblSampai.Text = "s/d";
            // 
            // dtpAkhir
            // 
            this.dtpAkhir.CustomFormat = "dd-MM-yyyy";
            this.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAkhir.Location = new System.Drawing.Point(182, 23);
            this.dtpAkhir.Name = "dtpAkhir";
            this.dtpAkhir.Size = new System.Drawing.Size(100, 20);
            this.dtpAkhir.TabIndex = 52;
            this.dtpAkhir.ValueChanged += new System.EventHandler(this.dtpAkhir_ValueChanged);
            // 
            // dtpAwal
            // 
            this.dtpAwal.CustomFormat = "dd-MM-yyyy";
            this.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAwal.Location = new System.Drawing.Point(47, 23);
            this.dtpAwal.Name = "dtpAwal";
            this.dtpAwal.Size = new System.Drawing.Size(100, 20);
            this.dtpAwal.TabIndex = 51;
            this.dtpAwal.ValueChanged += new System.EventHandler(this.dtpAwal_ValueChanged);
            // 
            // lblPemakaian
            // 
            this.lblPemakaian.AutoSize = true;
            this.lblPemakaian.Location = new System.Drawing.Point(9, 25);
            this.lblPemakaian.Name = "lblPemakaian";
            this.lblPemakaian.Size = new System.Drawing.Size(32, 13);
            this.lblPemakaian.TabIndex = 50;
            this.lblPemakaian.Text = "Dari :";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(378, 20);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 54;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(297, 20);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 23);
            this.btnCetak.TabIndex = 55;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 511);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.lblSampai);
            this.Controls.Add(this.dtpAkhir);
            this.Controls.Add(this.dtpAwal);
            this.Controls.Add(this.lblPemakaian);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.lblCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            this.Load += new System.EventHandler(this.frmRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnTutup;
        internal System.Windows.Forms.TextBox txtCari;
        internal System.Windows.Forms.Label lblKeterangan;
        internal System.Windows.Forms.Label lblCari;
        internal System.Windows.Forms.DataGridView dgvData;
        internal System.Windows.Forms.DateTimePicker dtpAkhir;
        internal System.Windows.Forms.DateTimePicker dtpAwal;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Label lblSampai;
        internal System.Windows.Forms.Label lblPemakaian;
        internal System.Windows.Forms.Button btnCetak;
    }
}