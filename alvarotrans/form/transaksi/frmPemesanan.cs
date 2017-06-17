using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using alvarotrans.form.record;
using C = System.Convert;
using dt = System.DateTime;
using vm = alvarotrans.form.kelas.clsHimpunan;

namespace alvarotrans.form.transaksi
{
    public partial class frmPemesanan : Form
    {
        private string idKaryawanOperator { get; set; }
        private string namaKaryawanOperator { get; set; }
        public frmPemesanan()
        {
            InitializeComponent();
        }

        public frmPemesanan(string id, string nama)
        {
            InitializeComponent();
            idKaryawanOperator = id;
            namaKaryawanOperator = nama;
        }

        private void HitungHari()
        {
            TimeSpan stuffing = (dtpAkhir.Value - dtpAwal.Value);
            TimeSpan pesan = (dtpAwal.Value - dt.Now);
 
            int intervalStuffing = 1 + C.ToInt32(stuffing.TotalDays);
            int intervalPesan = C.ToInt32(pesan.TotalDays);

            if (intervalStuffing < 1 || intervalPesan < 0)
            {
                txtLamaPesan.TextAlign = HorizontalAlignment.Left;
                txtLamaPesan.Text = "Error";
            }
            else
            {
                txtLamaPesan.TextAlign = HorizontalAlignment.Right;
                txtLamaPesan.Text = intervalStuffing.ToString();
            }
        }

        private void HitungTotalHarga()
        {
            if (String.IsNullOrEmpty(txtHarga.Text) || txtLamaPesan.Text == "Error")
            {
                txtTotalHarga.Text = "0";
            }
            else
            {
                try
                {
                    int hari = C.ToInt32(txtLamaPesan.Text);
                    long biayaSewa = C.ToInt64(txtHarga.Text);
                    long BiayaTambahan = C.ToInt64(txtBiayaTambahan.Text);
                    long totalBiayaSewa = BiayaTambahan + (biayaSewa * hari);
                    txtTotalHarga.Text = totalBiayaSewa.ToString();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void KosongkanIsiTeks()
        {
            vm.KosongkanIsiText(gbxTujuan);
            vm.KosongkanIsiText(gbxPemesanan);
            vm.KosongkanIsiText(gbxDataPelanggan);
        }


        private void PanelchkBiayaTambahan()
        {
            if (chkBiayaTambahan.Checked)
            {
                lblBiaya.Enabled = true;
                lblKetereanganBiayaTambahan.Enabled = true;
                txtBiayaTambahan.Enabled = true;
                txtKetereanganBiayaTambahan.Enabled = true;
            }
            else if (!chkBiayaTambahan.Checked)
            {
                txtBiayaTambahan.Text = "0";
                txtKetereanganBiayaTambahan.Text = "-";
                lblBiaya.Enabled = false;
                lblKetereanganBiayaTambahan.Enabled = false;
                txtBiayaTambahan.Enabled = false;
                txtKetereanganBiayaTambahan.Enabled = false;
            }
        }

        private void Pengaturan()
        {

            switch (vm.status)
            {
                case true:
                    tsbSimpan.Enabled = true;
                    tsbBatal.Enabled = false;
                    tsbCetak.Enabled = false;

                    KosongkanIsiTeks();
                    Record();
                    txtIdKaryawanOperator.Text = idKaryawanOperator;
                    txtNamaKaryawanOperator.Text = namaKaryawanOperator;
                    txtNoPesan.Text = "PSN" + vm.KodeOtomatis("NoPesan", "tblPesan", "NoPesan");
                    txtTglPesan.Text = String.Format("{0:dd-MM-yyyy}", dt.Now);
                    dtpAwal.Value = dtpAkhir.Value = dt.Now;
                    chkBiayaTambahan.Checked = false;
                    PanelchkBiayaTambahan();

                    cboJenisPesan.Enabled = dtpAwal.Enabled = dtpAkhir.Enabled = btnIdPelanggan.Enabled =
                        btnKodeTujuan.Enabled = cboTipeTrailer.Enabled = chkBiayaTambahan.Enabled = true;
                    txtKetereanganBiayaTambahan.ReadOnly = txtAlamat.ReadOnly = txtBiayaTambahan.ReadOnly = false;
                    break;
                case false:
                    tsbSimpan.Enabled = false;
                    tsbBatal.Enabled = true;
                    tsbCetak.Enabled = true;

                    vm.tabel = vm.proses.EksekusiQuery("SELECT DATEDIFF(day, TglAwalPesan, TglAkhirPesan) + 1 " +
                        "LamaPesan FROM tblPesanRinci WHERE NoPesan = '" + txtNoPesan.Text + "'");
                    txtLamaPesan.Text = vm.tabel.Rows[0][0].ToString();

                    cboJenisPesan.Enabled = dtpAwal.Enabled = dtpAkhir.Enabled = btnIdPelanggan.Enabled =
                        btnKodeTujuan.Enabled = cboTipeTrailer.Enabled = chkBiayaTambahan.Enabled = false;
                    txtKetereanganBiayaTambahan.ReadOnly = txtAlamat.ReadOnly = txtBiayaTambahan.ReadOnly = true;
                    break;
            }
        }

        private void Record()
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblTipeTrailer ORDER BY TipeTrailer");
                cboTipeTrailer.DataSource = vm.tabel;
                cboTipeTrailer.DisplayMember = "TipeTrailer";
                cboTipeTrailer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtIdPelanggan, "ID Pelanggan") || vm.ApakahKosong(cboJenisPesan, "Jenis Pemesanan") ||
                vm.ApakahKosong(txtKodeTujuan, "Kode Tujuan") || vm.ApakahKosong(txtKetereanganBiayaTambahan, "Ketereangan Biaya Tambahan") ||
                vm.ApakahKosong(txtAlamat, "Alamat Tujuan"))
            {
                vm.tidakTerisi = true;
            }
            else if (chkBiayaTambahan.Checked && (txtKetereanganBiayaTambahan.Text == "-" || txtBiayaTambahan.Text == "0" ||
                    String.IsNullOrEmpty(txtKetereanganBiayaTambahan.Text) || String.IsNullOrWhiteSpace(txtKetereanganBiayaTambahan.Text) ||
                    String.IsNullOrEmpty(txtBiayaTambahan.Text) || String.IsNullOrWhiteSpace(txtBiayaTambahan.Text)))
            {
                vm.pesan = "Deskripsi biaya tambahan tidak valid.\n\n" +
                    "P.S: Mohon ulangi proses yang dimaksud atau hapus tanda centang jika tidak dibutuhkan!";
                MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                chkBiayaTambahan.Checked = false;
                PanelchkBiayaTambahan();

                vm.tidakTerisi = true;
            }
            else if (txtLamaPesan.Text == "Error")
            {
                vm.pesan = "Terdapat kesalahan dalam input data tanggal. Mohon periksa kembali!";
                MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void frmPemesanan_Load(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void cboJenisPesan_KeyDown(object sender, KeyEventArgs e)
        {
            vm.InputNonAktif(e);
        }

        private void cboJenisPesan_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void cboJenisPesan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboJenisPesan.Text == "Export")
                lblAlamat.Text = "Alamat Stuffing :";
            else if (cboJenisPesan.Text == "Import")
                lblAlamat.Text = "Alamat Loading :";
            else
                lblAlamat.Text = "Alamat :";
        }

        private void dtpAwal_ValueChanged(object sender, EventArgs e)
        {
            HitungHari();
        }

        private void dtpAkhir_ValueChanged(object sender, EventArgs e)
        {
            HitungHari();
        }

        private void txtLamaPesan_TextChanged(object sender, EventArgs e)
        {
            HitungTotalHarga();
        }

        private void btnIdPelanggan_Click(object sender, EventArgs e)
        {
            frmData pelanggan = new frmData();
            pelanggan.Text = "Data Pelanggan - Pemesanan";
            if (pelanggan.ShowDialog() == DialogResult.OK)
            {
                txtIdPelanggan.Text = pelanggan.IdPelanggan;
                txtNamaPelanggan.Text = pelanggan.NamaPelanggan;
                txtPerusahaan.Text = pelanggan.Perusahaan;
                txtTelepon.Text = pelanggan.Telepon;
            }
        }

        private void btnKodeTujuan_Click(object sender, EventArgs e)
        {
            frmData harga = new frmData();
            harga.Text = "Data Tujuan - Pemesanan";
            if (harga.ShowDialog() == DialogResult.OK)
            {
                txtKodeTujuan.Text = harga.KodeTujuan;
                txtKotaTujuan.Text = harga.KotaTujuan;
                txtDaerahTujuan.Text = harga.DaerahTujuan;
                cboTipeTrailer.Text = harga.TipeTrailer;
                txtTrasport.Text = harga.Transport;
                txtHarga.Text = harga.Harga;
            }
        }

        private void cboTipeTrailer_KeyDown(object sender, KeyEventArgs e)
        {
            vm.InputNonAktif(e);
        }

        private void cboTipeTrailer_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void cboTipeTrailer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT t.KodeTujuan, t.KotaTujuan, t.DaerahTujuan, h.TipeTrailer, " +
                    "h.Transport, h.Harga FROM tblTujuan t INNER JOIN tblHarga h ON t.KodeTujuan = h.KodeTujuan " +
                    "WHERE t.KodeTujuan = '" + txtKodeTujuan.Text + "' AND h.TipeTrailer = '" + cboTipeTrailer.Text + "'");
                if (vm.tabel.Rows.Count == 1)
                {
                    txtKodeTujuan.Text = vm.tabel.Rows[0][0].ToString();
                    txtKotaTujuan.Text = vm.tabel.Rows[0][1].ToString();
                    txtDaerahTujuan.Text = vm.tabel.Rows[0][2].ToString();
                    cboTipeTrailer.Text = vm.tabel.Rows[0][3].ToString();
                    txtTrasport.Text = vm.tabel.Rows[0][4].ToString();
                    txtHarga.Text = vm.tabel.Rows[0][5].ToString();
                }
                else
                {
                    txtKodeTujuan.Text = txtKotaTujuan.Text = txtDaerahTujuan.Text =
                         txtTrasport.Text = txtHarga.Text = String.Empty; ;
                    cboTipeTrailer.SelectedIndex = -1;

                }
            }
            catch (Exception)
            {
                return;
            }

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            HitungTotalHarga();
        }

        private void chkBiayaTambahan_CheckedChanged(object sender, EventArgs e)
        {
            PanelchkBiayaTambahan();
        }

        private void txtHargaBiayaTambahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void txtHargaBiayaTambahan_TextChanged(object sender, EventArgs e)
        {
            HitungTotalHarga();
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if(TidakTerisi() != true)
                {
                    vm.sql = "INSERT INTO tblPesan VALUES ('" + txtNoPesan.Text +
                        "','" + String.Format("{0:yyyy-MM-dd}", dt.Now) +
                        "','" + txtIdPelanggan.Text +
                        "','" + txtIdKaryawanOperator.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.sql = "INSERT INTO tblPesanRinci VALUES ('" + txtNoPesan.Text +
                        "','" + cboJenisPesan.Text +
                        "','" + String.Format("{0:yyyy-MM-dd}", dtpAwal.Value) +
                        "','" + String.Format("{0:yyyy-MM-dd}", dtpAkhir.Value) +
                        "','" + txtKodeTujuan.Text +
                        "','" + cboTipeTrailer.Text +
                        "','" + txtAlamat.Text + 
                        "','" + txtBiayaTambahan.Text +
                        "','" + txtKetereanganBiayaTambahan.Text + 
                        "','Proses Validasi')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data pemesanan dengan No. Pemesanan: '" + txtNoPesan.Text + "' telah tersimpan.";
                    MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pengaturan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbBatal_Click(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void tsbRecordPemesanan_Click(object sender, EventArgs e)
        {
            frmData pesan = new frmData();
            pesan.Text = "Data Pemesanan - Pemesanan";
            if (pesan.ShowDialog() == DialogResult.OK)
            {
                txtIdKaryawanOperator.Text = pesan.IdKaryawan;
                txtNamaKaryawanOperator.Text = pesan.NamaKaryawan;
                txtNoPesan.Text = pesan.NoPesan;
                cboJenisPesan.Text = pesan.JenisPesan;
                txtTglPesan.Text = pesan.TglPesan;
                dtpAwal.Value = Convert.ToDateTime(pesan.TglAwalPesan);
                dtpAkhir.Value = Convert.ToDateTime(pesan.TglAkhirPesan);
                txtIdPelanggan.Text = pesan.IdPelanggan;
                txtNamaPelanggan.Text = pesan.NamaPelanggan;
                txtPerusahaan.Text = pesan.Perusahaan;
                txtTelepon.Text = pesan.Telepon;
                txtKodeTujuan.Text = pesan.KodeTujuan;
                txtKotaTujuan.Text = pesan.KotaTujuan;
                txtDaerahTujuan.Text = pesan.DaerahTujuan;
                cboTipeTrailer.Text = pesan.TipeTrailer;
                txtTrasport.Text = pesan.Transport;
                txtHarga.Text = pesan.Harga;
                txtAlamat.Text = pesan.Alamat;
                txtKetereanganBiayaTambahan.Text = pesan.KetereanganBiayaTambahan;
                txtBiayaTambahan.Text = pesan.BiayaTambahan;

                if (txtBiayaTambahan.Text == "0")
                    chkBiayaTambahan.Checked = false;
                else
                    chkBiayaTambahan.Checked = true;

                vm.status = false;
                Pengaturan();
            }
        }

        private void tsbCetak_Click(object sender, EventArgs e)
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT Status FROM tblPesanRinci WHERE NoPesan = '" + 
                    txtNoPesan.Text + "'");

                if (vm.tabel.Rows[0][0].ToString() != "Proses Validasi")
                {
                    vm.pesan = "Data pemesanan dengan No. Pemesanan: '" + txtNoPesan.Text + "' tidak dapat dicetak. " +
                        "\n\nP.S: Kemungkinan No. Pemesanan: '" + txtNoPesan.Text + "' tidak dapat dicetak terkait " +
                        "status proses transaksi tersebut (Status Pemesanan: Batal, Proses Pengiriman, Kadaluarsa, Kirim, Diterima).";
                    MessageBox.Show(vm.pesan, "Proses cetak konfirmasi pemesanan dibatalkan", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmReport konfirmasi = new frmReport(txtNoPesan.Text);
                    konfirmasi.Text = "Konfirmasi Pemesanan";
                    konfirmasi.ShowDialog();
                }
                vm.status = true;
                Pengaturan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}