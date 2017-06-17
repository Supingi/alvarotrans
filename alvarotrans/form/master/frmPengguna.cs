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
    public partial class frmPengguna : Form
    {
        public frmPengguna()
        {
            InitializeComponent();
        }

        private void Pengaturan()
        {
            switch (vm.status)
            {
                case true:
                    btnIdPengguna.Enabled = true;
                    tsbSimpan.Enabled = true;
                    tsbUbah.Enabled = false;
                    tsbHapus.Enabled = false;
                    tsbBatal.Enabled = false;
                    vm.KosongkanIsiText(this);
                    break;
                case false:
                    btnIdPengguna.Enabled = false;
                    tsbSimpan.Enabled = false;
                    tsbUbah.Enabled = true;
                    tsbHapus.Enabled = true;
                    tsbBatal.Enabled = true;
                    break;
            }
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtIdKaryawan, "ID Karyawan") || vm.ApakahKosong(txtPassword, "Password") ||
                vm.ApakahKosong(txtUlangiPassword, "Ulangi Password"))
            {
                vm.tidakTerisi = true;
            }
            else if (txtPassword.Text != txtUlangiPassword.Text)
            {
                vm.pesan = "Password yang anda masukan tidak cocok. Silakan periksa kembali!";
                MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void frmPengguna_Load(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void btnIdPengguna_Click(object sender, EventArgs e)
        {
            frmData karyawan = new frmData();
            karyawan.Text = "Data Karyawan - Pengguna Aplikasi";
            if (karyawan.ShowDialog() == DialogResult.OK)
            {
                txtIdKaryawan.Text = karyawan.IdKaryawan;
                txtNamaKaryawan.Text = karyawan.NamaKaryawan;
                txtJabatan.Text = karyawan.Jabatan;
            }
        }

        private void txtUlangiPassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtUlangiPassword.Text))
                lblKeterangan3.Text = "* Password case-sensitive";
            else if (txtPassword.Text != txtUlangiPassword.Text)
                lblKeterangan3.Text = "Password tidak cocok.";
            else if (txtPassword.Text == txtUlangiPassword.Text)
                lblKeterangan3.Text = "Password cocok";
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.sql = "INSERT INTO tblPengguna VALUES ('" + txtIdKaryawan.Text +
                        "','" + vm.Enkripsi(txtPassword.Text) + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data pengguna aplikasi dengan ID: '" + txtIdKaryawan.Text + "' telah tersimpan.";
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
                    vm.pesan = "Apakah anda akan melakukan perubahan pada data pengguna aplikasi dengan ID: '" +
                            txtIdKaryawan.Text + "'?";

                    if (vm.PesanPeringatan(vm.pesan, "Ubah data"))
                    {
                        vm.sql = "UPDATE tblPengguna SET Password = '" + vm.Enkripsi(txtPassword.Text) +
                            "' WHERE IdKaryawan = '" + txtIdKaryawan.Text + "'";
                        vm.proses.EksekusiNonQuery(vm.sql);

                        vm.pesan = "Data pengguna aplikasi dengan ID: '" + txtIdKaryawan.Text + "' telah diubah.";
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
                vm.pesan = "Apakah anda akan melakukan penghapusan pada data pengguna aplikasi dengan ID: '" + 
                    txtIdKaryawan.Text + "'?";

                if (vm.PesanPeringatan(vm.pesan, "Hapus data"))
                {
                    vm.sql = "DELETE FROM tblPengguna WHERE IdKaryawan = '" + txtIdKaryawan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data pengguna aplikasi dengan ID: '" + txtIdKaryawan.Text + "' telah dihapus.";
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

        private void tsbRecordPengguna_Click(object sender, EventArgs e)
        {
            frmData pengguna = new frmData();
            pengguna.Text = "Data Pengguna - Pengguna Aplikasi";
            if (pengguna.ShowDialog() == DialogResult.OK)
            {
                txtIdKaryawan.Text = pengguna.IdKaryawan;
                txtNamaKaryawan.Text = pengguna.NamaKaryawan;
                txtJabatan.Text = pengguna.Jabatan;
                txtPassword.Text = pengguna.Password;
                txtUlangiPassword.Text = pengguna.Password;

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
