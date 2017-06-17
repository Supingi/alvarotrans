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

namespace alvarotrans.form.penunjang
{
    public partial class frmUbahPassword : Form
    {
        public frmUbahPassword()
        {
            InitializeComponent();
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtPasswordLama, "Password Lama") || vm.ApakahKosong(txtPasswordBaru, "Password Baru") ||
                vm.ApakahKosong(txtUlangi, "Ulangi Password"))
            {
                txtPasswordLama.Text = txtPasswordBaru.Text = txtUlangi.Text = String.Empty;
                vm.tidakTerisi = true;
            }
            else if (txtPasswordBaru.Text != txtUlangi.Text)
            {
                vm.pesan = "Password yang anda masukan tidak cocok. Silakan periksa kembali!";
                MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPasswordLama.Text = txtPasswordBaru.Text = txtUlangi.Text = String.Empty;
                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void UbahPassword()
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblPengguna WHERE IdKaryawan =  '"
                        + txtIdKaryawan.Text + "' AND Password = '" + vm.Enkripsi(txtPasswordLama.Text) + "'");

                    if (vm.tabel.Rows.Count == 0)
                    {
                        vm.pesan = "Nilai password lama yang anda masukan salah. Silahkan periksa kembali";
                        MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPasswordLama.Text = txtPasswordBaru.Text = txtUlangi.Text = String.Empty;
                    }
                    else
                    {
                        vm.sql = "UPDATE tblPengguna SET Password = '" + vm.Enkripsi(txtPasswordBaru.Text) +
                        "' WHERE IdKaryawan = '" + txtIdKaryawan.Text + "'";
                        vm.proses.EksekusiNonQuery(vm.sql);

                        vm.pesan = "Password berhasil diubah!";
                        MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUlangi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) 
                UbahPassword();
        }

        private void txtUlangi_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUlangi.Text) || String.IsNullOrEmpty(txtPasswordBaru.Text))
                lblKeterangan3.Text = "* Password case-sensitive";
            else if (txtPasswordBaru.Text != txtUlangi.Text)
                lblKeterangan3.Text = "Password tidak cocok.";
            else if (txtPasswordBaru.Text == txtUlangi.Text)
                lblKeterangan3.Text = "Password cocok";
            
        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            UbahPassword();
        }

        private void tsbTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
