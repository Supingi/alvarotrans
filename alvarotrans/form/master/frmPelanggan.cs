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

namespace alvarotrans.form.master
{
    public partial class frmPelanggan : Form
    {
        public frmPelanggan()
        {
            InitializeComponent();
        }

        private void Pengaturan()
        {
            switch (vm.status)
            {
                case true:
                    tsbSimpan.Enabled = true;
                    tsbUbah.Enabled = false;
                    tsbHapus.Enabled = false;
                    tsbBatal.Enabled = false;

                    vm.KosongkanIsiText(this);
                    txtIdPelanggan.Text = "PLG" + vm.KodeOtomatis("IdPelanggan", "tblPelanggan", "IdPelanggan");
                    break;
                case false:
                    tsbSimpan.Enabled = false;
                    tsbUbah.Enabled = true;
                    tsbHapus.Enabled = true;
                    tsbBatal.Enabled = true;
                    break;
            }
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtNamaPelanggan, "Nama Pelanggan") || vm.ApakahKosong(txtPerusahaan, "Perusahaan") ||
                vm.ApakahKosong(txtAlamat, "Alamat") || vm.ApakahKosong(txtTelepon, "Telepon"))
            {
                vm.tidakTerisi = true;
            }
            else if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) ||
                String.IsNullOrEmpty(txtPerusahaan.Text) || String.IsNullOrWhiteSpace(txtPerusahaan.Text) ||
                String.IsNullOrEmpty(txtFax.Text) || String.IsNullOrWhiteSpace(txtFax.Text))
            {
                if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrWhiteSpace(txtEmail.Text)) txtEmail.Text = "-";
                if (String.IsNullOrEmpty(txtPerusahaan.Text) || String.IsNullOrWhiteSpace(txtPerusahaan.Text)) txtPerusahaan.Text = "-";
                if (String.IsNullOrEmpty(txtFax.Text) || String.IsNullOrWhiteSpace(txtFax.Text)) txtFax.Text = "-";
                vm.tidakTerisi = false;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void frmPelanggan_Load(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.sql = "INSERT INTO tblPelanggan VALUES ('" + txtIdPelanggan.Text +
                        "','" + txtNamaPelanggan.Text +
                        "','" + txtPerusahaan.Text.ToUpper() +
                        "','" + txtAlamat.Text +
                        "','" + txtTelepon.Text +
                        "','" + txtEmail.Text +
                        "','" + txtFax.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data pelanggan dengan ID: '" + txtIdPelanggan.Text + "' telah tersimpan.";
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
                    vm.pesan = "Apakah anda akan melakukan perubahan pada data pelanggan dengan ID: '" + 
                        txtIdPelanggan.Text + "'?";

                    if (vm.PesanPeringatan(vm.pesan, "Ubah data"))
                    {
                        vm.sql = "UPDATE tblPelanggan SET NamaPelanggan = '" + txtNamaPelanggan.Text +
                            "', Perusahaan = '" + txtPerusahaan.Text.ToUpper() +
                            "', Alamat = '" + txtAlamat.Text +
                            "', Telepon ='" + txtTelepon.Text +
                            "', Email = '" + txtEmail.Text +
                            "', Fax = '" + txtFax.Text +
                            "' WHERE IdPelanggan = '" + txtIdPelanggan.Text + "'";
                        vm.proses.EksekusiNonQuery(vm.sql);

                        vm.pesan = "Data pelanggan dengan ID: '" + txtIdPelanggan.Text + "' telah diubah.";
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

        private void tsbHapus_Click(object sender, EventArgs e)
        {
            try
            {
                vm.pesan = "Apakah anda akan melakukan penghapusan pada data pelanggan dengan ID: '" + 
                    txtIdPelanggan.Text + "'?";

                if (vm.PesanPeringatan(vm.pesan, "Hapus data"))
                {
                    vm.sql = "DELETE FROM tblPelanggan WHERE IdPelanggan = '" + txtIdPelanggan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data pelanggan dengan ID: '" + txtIdPelanggan.Text + "' telah dihapus.";
                    MessageBox.Show(vm.pesan, "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                vm.status = true;
                Pengaturan();
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

        private void tsbRecordPelanggan_Click(object sender, EventArgs e)
        {
            frmData pelanggan = new frmData();
            pelanggan.Text = "Data Pelanggan - Pelanggan";
            if (pelanggan.ShowDialog() == DialogResult.OK)
            {
                txtIdPelanggan.Text = pelanggan.IdPelanggan;
                txtNamaPelanggan.Text = pelanggan.NamaPelanggan;
                txtPerusahaan.Text = pelanggan.Perusahaan;
                txtAlamat.Text = pelanggan.Alamat;
                txtTelepon.Text = pelanggan.Telepon;
                txtEmail.Text = pelanggan.Email;
                txtFax.Text = pelanggan.Fax;

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
