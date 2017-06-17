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
using vm = alvarotrans.form.kelas.clsHimpunan;

namespace alvarotrans.form.transaksi
{
    public partial class frmDaftarTunggu : Form
    {
        public frmDaftarTunggu()
        {
            InitializeComponent();
        }

        private void Pengaturan()
        {
            switch (vm.status)
            {
                case true:
                    btnPesan.Enabled = true;
                    tsbSimpan.Enabled = true;
                    tsbUbah.Enabled = false;
                    tsbBatal.Enabled = false;
                    vm.KosongkanIsiText(this);
                    break;
                case false:
                    btnPesan.Enabled = false;
                    tsbSimpan.Enabled = false;
                    tsbUbah.Enabled = true;
                    tsbBatal.Enabled = true;
                    break;
            }
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtNoPesan, "No. Pemesanan") || vm.ApakahKosong(txtNoPolisi, "No. Polisi"))
            {
                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void frmDaftarTunggu_Load(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            frmData pemesanan = new frmData();
            pemesanan.Text = "Data Pemesanan - Daftar Tunggu";
            if (pemesanan.ShowDialog() == DialogResult.OK)
            {
                txtNoPesan.Text = pemesanan.NoPesan;
                txtAwal.Text = pemesanan.TglAwalPesan;
                txtAkhir.Text = pemesanan.TglAkhirPesan;
            }
        }

        private void btnNoPolisi_Click(object sender, EventArgs e)
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT NoPesan, TglAwalPesan, TglAkhirPesan " +
                                       "FROM tblPesanRinci WHERE NoPesan = '" + txtNoPesan.Text + "'");
                frmData truk = new frmData(vm.tabel.Rows[0][1].ToString(), vm.tabel.Rows[0][2].ToString());
                truk.Text = "Data Truk - Daftar Tunggu";
                if (truk.ShowDialog() == DialogResult.OK)
                {
                    txtNoPolisi.Text = truk.NoPolisi;
                    txtMerk.Text = truk.Merk;
                    txtTipeTrailer.Text = truk.TipeTrailer;
                }
            }
            catch(Exception)
            {
                return;
            }
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.sql = "INSERT INTO tblDaftarTunggu VALUES ('" + txtNoPesan.Text +
                        "','" + txtNoPolisi.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data daftar tunggu dengan No. Pemesanan: '" + txtNoPesan.Text + "' telah tersimpan.";
                    MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pengaturan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.pesan = "Apakah anda akan melakukan perubahan pada data daftar tunggu dengan No. Pemesanan: '" +
                            txtNoPesan.Text + "'?";

                    if (vm.PesanPeringatan(vm.pesan, "Ubah data"))
                    {
                        vm.sql = "UPDATE tblDaftarTunggu SET NoPolisi = '" + txtNoPolisi.Text +
                            "' WHERE NoPesan = '" + txtNoPesan.Text + "'";
                        vm.proses.EksekusiNonQuery(vm.sql);

                        vm.pesan = "Data daftar tunggu dengan No. Pemesanan: '" + txtNoPesan.Text + 
                            "' telah diubah.";
                        MessageBox.Show(vm.pesan, "Ubah data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    vm.status = true;
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
            frmData tunggu = new frmData();
            tunggu.Text = "Data Daftar Tunggu - Daftar Tunggu";
            if (tunggu.ShowDialog() == DialogResult.OK)
            {
                txtNoPesan.Text = tunggu.NoPesan;
                txtAwal.Text = tunggu.TglAwalPesan;
                txtAkhir.Text = tunggu.TglAkhirPesan;
                txtNoPolisi.Text = tunggu.NoPolisi;
                txtMerk.Text = tunggu.Merk;
                txtTipeTrailer.Text = tunggu.TipeTrailer;

                vm.status = false;
                Pengaturan();
            }
        }

        private void tsbTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
