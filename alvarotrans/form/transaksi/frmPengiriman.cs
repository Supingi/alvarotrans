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
using vm = alvarotrans.form.kelas.clsHimpunan;

namespace alvarotrans.form.transaksi
{
    public partial class frmPengiriman : Form
    {
        private string idKaryawanOperasional { get; set; }
        private string namaKaryawanOperasional { get; set; }
        public frmPengiriman()
        {
            InitializeComponent();
        }

        public frmPengiriman(string id, string nama)
        {
            InitializeComponent();
            idKaryawanOperasional = id;
            namaKaryawanOperasional = nama;
        }

        private void KosongkanIsiTeks()
        {
            vm.KosongkanIsiText(gbxPengiriman);
            vm.KosongkanIsiText(gbxPemesanan);
            vm.KosongkanIsiText(gbxDetailDO);
            vm.KosongkanIsiText(gbxDataKendaraan);
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
                    txtIdKaryawanOperasional.Text = idKaryawanOperasional;
                    txtNamaKaryawanOperasional.Text = namaKaryawanOperasional;
                    txtNoKirim.Text = "KRM" + vm.KodeOtomatis("NoKirim", "tblKirim", "NoKirim");
                    txtTglKirim.Text = String.Format("{0:dd-MM-yyyy}", DateTime.Now);

                    btnPesan.Enabled = true;
                    txtNoDO.ReadOnly = txtPengangkut.ReadOnly = txtKomoditi.ReadOnly = false;
                    break;
                case false:
                    tsbSimpan.Enabled = false;
                    tsbBatal.Enabled = true;
                    tsbCetak.Enabled = true;

                    btnPesan.Enabled = false;
                    txtNoDO.ReadOnly = txtPengangkut.ReadOnly = txtKomoditi.ReadOnly = true;
                    break;
            }
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtNoPesan, "Kode Pemesanan") || vm.ApakahKosong(txtNoDO, "No. Delivery Order") ||
                vm.ApakahKosong(txtPengangkut, "Perusahaan Pengangkut") || vm.ApakahKosong(txtKomoditi, "Komoditi") ||
                vm.ApakahKosong(txtNoPolisi, "No. Polisi"))
            {
                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void frmPenawaran_Load(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            frmData pemesanan = new frmData();
            pemesanan.Text = "Data Pemesanan - Pengiriman";
            if (pemesanan.ShowDialog() == DialogResult.OK)
            {
                txtNoPesan.Text = pemesanan.NoPesan;
                txtNamaPelanggan.Text = pemesanan.NamaPelanggan;
                txtPerusahaan.Text = pemesanan.Perusahaan;
                txtTelepon.Text = pemesanan.Telepon;
                txtNoPolisi.Text = pemesanan.NoPolisi;
                txtMerk.Text = pemesanan.Merk;
                txtNamaSupir1.Text = pemesanan.NamaSupir1;
                txtNamaSupir2.Text = pemesanan.NamaSupir2;
            }
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.sql = "INSERT INTO tblKirim VALUES ('" + txtNoKirim.Text +
                        "','" + String.Format("{0:yyyy-MM-dd}", DateTime.Now) +
                        "','" + txtNoPesan.Text +
                        "','" + txtIdKaryawanOperasional.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.sql = "INSERT INTO tblKirimRinci VALUES ('" + txtNoKirim.Text +
                        "','" + txtPengangkut.Text + 
                        "','" + txtNoDO.Text +
                        "','" + txtKomoditi.Text +
                        "','" + txtNoPolisi.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.sql = "UPDATE tblPesanRinci SET Status = 'Proses Pengiriman' WHERE NoPesan = '" + 
                        txtNoPesan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data pengiriman dengan No. Pengiriman: '" + txtNoKirim.Text + "' telah tersimpan.";
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

        private void tsbRecord_Click(object sender, EventArgs e)
        {
            frmData kirim = new frmData();
            kirim.Text = "Data Pengiriman - Pengiriman";
            if (kirim.ShowDialog() == DialogResult.OK)
            {
                txtIdKaryawanOperasional.Text = kirim.IdKaryawan;
                txtNamaKaryawanOperasional.Text = kirim.NamaKaryawan;
                txtNoKirim.Text = kirim.NoKirim;
                txtTglKirim.Text = kirim.TglKirim;
                txtNoPesan.Text = kirim.NoPesan;
                txtNamaPelanggan.Text = kirim.NamaPelanggan;
                txtPerusahaan.Text = kirim.Perusahaan;
                txtTelepon.Text = kirim.Telepon;
                txtNoDO.Text = kirim.NoDO;
                txtPengangkut.Text = kirim.Pengangkut;
                txtKomoditi.Text = kirim.Komoditi;
                txtNoPolisi.Text = kirim.NoPolisi;
                txtMerk.Text = kirim.Merk;
                txtNamaSupir1.Text = kirim.NamaSupir1;
                txtNamaSupir2.Text = kirim.NamaSupir2;

                vm.status = false;
                Pengaturan();
            }
        }

        private void tsbCetak_Click(object sender, EventArgs e)
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT Status FROM tblKirimRinci " +
                    "WHERE NoKirim = '" + txtNoKirim.Text + "'");

                if (vm.tabel.Rows[0][0].ToString() == "Sudah Diproses")
                {
                    vm.pesan = "Data pengiriman dengan No. Pengiriman: '" + txtNoKirim.Text + "' tidak dapat dicetak. " +
                        "\n\nP.S: Kemungkinan No. Pengiriman: '" + txtNoKirim.Text + "' tidak dapat dicetak terkait " +
                        "status proses transaksi tersebut (Status Pengiriman: Sudah Diproses).";
                    MessageBox.Show(vm.pesan, "Proses cetak konfirmasi pemesanan dibatalkan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmReport pengiriman = new frmReport(txtNoKirim.Text);
                    pengiriman.Text = "Form Pengiriman Barang";
                    pengiriman.ShowDialog();
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
