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
using Microsoft.VisualBasic;
using vm = alvarotrans.form.kelas.clsHimpunan;

namespace alvarotrans.form.penunjang
{
    public partial class frmLogin : Form
    {
        private string idKaryawan { get; set; }
        private string namaKaryawan { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login(string id, string password)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblPengguna WHERE IdKaryawan = '"
                        + id.ToUpper() + "' AND Password = '" + vm.Enkripsi(password) + "'");

                    if (vm.tabel.Rows.Count == 0)
                    {
                        MessageBox.Show("ID Karyawan atau Password yang anda masukan tidak tepat. " +
                        "Silahkan periksa kembali!", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        vm.KosongkanIsiText(this);
                        txtIdKaryawan.Focus();
                    }
                    else
                    {
                        vm.tabel = vm.proses.EksekusiQuery("SELECT IdKaryawan, NamaKaryawan " +
                            "FROM tblKaryawan WHERE IdKaryawan = '" + id.ToUpper() + "'");
                        idKaryawan = vm.tabel.Rows[0][0].ToString();
                        namaKaryawan = vm.tabel.Rows[0][1].ToString();

                        frmUtama utama = new frmUtama(idKaryawan, namaKaryawan);
                        utama.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtIdKaryawan, "ID Karyawan") || vm.ApakahKosong(txtPassword, "Password"))
            {
                vm.KosongkanIsiText(this);
                txtIdKaryawan.Focus();
                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
                Login(txtIdKaryawan.Text, txtPassword.Text);
        }

        private void chkLihat_CheckedChanged(object sender, EventArgs e)
        {
            if(chkLihat.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else if (!chkLihat.Checked)
                txtPassword.UseSystemPasswordChar = true;
        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            Login(txtIdKaryawan.Text, txtPassword.Text);
        }

        private void tsbTutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
