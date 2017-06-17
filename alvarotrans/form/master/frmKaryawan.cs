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
    public partial class frmKaryawan : Form
    {
        public frmKaryawan()
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
                    Record();
                    txtIdKaryawan.Text = "KRY" + vm.KodeOtomatis("IdKaryawan", "tblKaryawan", "IdKaryawan");
                    dtpTglLahir.Value = dtpMulaiKerja.Value = DateTime.Now;
                    break;
                case false:
                    tsbSimpan.Enabled = false;
                    tsbUbah.Enabled = true;
                    tsbHapus.Enabled = true;
                    tsbBatal.Enabled = true;
                    break;
            }
        }

        private void Record()
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblJabatan WHERE Jabatan != 'Administrator Sistem' ORDER BY Jabatan");
                cboJabatan.DataSource = vm.tabel;
                cboJabatan.DisplayMember = "Jabatan";
                cboJabatan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtNamaKaryawan, "Nama Karyawan") || vm.ApakahKosong(txtTempatLahir, "Tempat Lahir") ||
                vm.ApakahKosong(cboAgama, "Agama") || vm.ApakahKosong(cboJenisKelamin, "Jenis Kelamin") || 
                vm.ApakahKosong(txtAlamat, "Alamat") || vm.ApakahKosong(txtTelepon, "No. Telepon") || 
                vm.ApakahKosong(cboJabatan, "Jabatan"))
            {
                vm.tidakTerisi = true;
            }
            else if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "-";
                vm.tidakTerisi = false;

                if (String.IsNullOrEmpty(txtRekening.Text) || String.IsNullOrWhiteSpace(txtRekening.Text))
                {
                    txtRekening.Text = "-";
                    vm.tidakTerisi = false;
                }
            }
            else if (String.IsNullOrEmpty(txtRekening.Text) || String.IsNullOrWhiteSpace(txtRekening.Text))
            {
                txtRekening.Text = "-";
                vm.tidakTerisi = false;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void frmKaryawan_Load(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void cboAgama_KeyDown(object sender, KeyEventArgs e)
        {
            vm.InputNonAktif(e);
        }

        private void cboAgama_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void cboJenisKelamin_KeyDown(object sender, KeyEventArgs e)
        {
            vm.InputNonAktif(e);
        }

        private void cboJenisKelamin_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void cboJabatan_KeyDown(object sender, KeyEventArgs e)
        {
            vm.InputNonAktif(e);
        }

        private void cboJabatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.sql = "INSERT INTO tblKaryawan VALUES ('" + txtIdKaryawan.Text +
                        "','" + txtNamaKaryawan.Text +
                        "','" + txtTempatLahir.Text +
                        "','" + String.Format("{0:yyyy-MM-dd}", dtpTglLahir.Value) +
                        "','" + cboAgama.Text +
                        "','" + cboJenisKelamin.Text +
                        "','" + txtAlamat.Text +
                        "','" + txtTelepon.Text +
                        "','" + txtEmail.Text +
                        "','" + cboJabatan.Text +
                        "','" + txtRekening.Text + 
                        "','" + String.Format("{0:yyyy-MM-dd}", dtpMulaiKerja.Value) + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data karyawan dengan ID: '" + txtIdKaryawan.Text + "' telah tersimpan.";
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
                    vm.pesan = "Apakah anda akan melakukan perubahan pada data karyawan dengan ID: '" + 
                        txtIdKaryawan.Text + "'?";

                    if (vm.PesanPeringatan(vm.pesan, "Ubah data"))
                    {
                        vm.sql = "UPDATE tblKaryawan SET NamaKaryawan = '" + txtNamaKaryawan.Text +
                            "', TempatLahir = '" + txtTempatLahir.Text +
                            "', TglLahir = '" + String.Format("{0:yyyy-MM-dd}", dtpTglLahir.Value) +
                            "', Agama = '" + cboAgama.Text +
                            "', JenisKelamin = '" + cboJenisKelamin.Text +
                            "', Alamat = '" + txtAlamat.Text +
                            "', Telepon = '" + txtTelepon.Text +
                            "', Email = '" + txtEmail.Text +
                            "', Jabatan = '" + cboJabatan.Text +
                            "', Rekening = '" + txtRekening.Text +
                            "', TglMulaiKerja = '" + String.Format("{0:yyyy-MM-dd}", dtpMulaiKerja.Value) +
                            "' WHERE IdKaryawan = '" + txtIdKaryawan.Text + "'";
                        vm.proses.EksekusiNonQuery(vm.sql);

                        vm.pesan = "Data karyawan dengan ID: '" + txtIdKaryawan.Text + "' telah diubah.";
                        MessageBox.Show(vm.pesan, "Ubah data",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        // 
        //Summary: 
        //  Button ini digunakan untuk mengecek data-data (Pengguna aplikasi/supir) yang terhubung dengan data pada
        private void tsbHapus_Click(object sender, EventArgs e)
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblTruk WHERE IdSupir1 = '" + txtIdKaryawan.Text +
                    "' OR IdSupir2 = '" + txtIdKaryawan.Text + "'");
                vm.pesan = "Apakah anda akan melakukan penghapusan pada data karyawan dengan ID: '" + txtIdKaryawan.Text +
                    "'?\n\nP.S: '" + txtIdKaryawan.Text + "' Terdata sebagai supir. Penghapusan data ini akan menyebabkan data truk " +
                    "tidak memiliki supir sama sekali. Apakah anda tetap akan melakukan penghapusan data?";

                if (vm.tabel.Rows.Count == 1 && vm.PesanPeringatan(vm.pesan, "Hapus data"))
                {
                    vm.sql = "DELETE FROM tblKaryawan WHERE IdKaryawan = '" + txtIdKaryawan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.sql = "UPDATE tblTruk SET IdSupir1 = NULL, IdSupir2 = NULL " +
                        "WHERE NoPolisi = '" + vm.tabel.Rows[0][0].ToString() + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data karyawan dengan ID: '" + txtIdKaryawan.Text + "' telah dihapus.";
                    MessageBox.Show(vm.pesan, "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (vm.PesanPeringatan("Apakah anda akan melakukan penghapusan pada data karyawan dengan ID: '" + 
                    txtIdKaryawan.Text + "'?", "Hapus data"))
                {
                    vm.sql = "DELETE FROM tblKaryawan WHERE IdKaryawan = '" + txtIdKaryawan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.sql = "DELETE FROM tblPengguna WHERE IdKaryawan = '" + txtIdKaryawan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data karyawan dengan ID: '" + txtIdKaryawan.Text + "' telah dihapus.";
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

        private void tsbRecordKaryawan_Click(object sender, EventArgs e)
        {
            frmData karyawan = new frmData();
            karyawan.Text = "Data Karyawan - Karyawan";
            if (karyawan.ShowDialog() == DialogResult.OK)
            {
                txtIdKaryawan.Text = karyawan.IdKaryawan;
                txtNamaKaryawan.Text = karyawan.NamaKaryawan;
                txtTempatLahir.Text = karyawan.TempatLahir;
                dtpTglLahir.Value = Convert.ToDateTime(karyawan.TglLahir);
                cboAgama.Text = karyawan.Agama;
                cboJenisKelamin.Text = karyawan.JenisKelamin;
                txtAlamat.Text = karyawan.Alamat;
                txtTelepon.Text = karyawan.Telepon;
                txtEmail.Text = karyawan.Email;
                cboJabatan.Text = karyawan.Jabatan;
                txtRekening.Text = karyawan.Rekening;
                dtpMulaiKerja.Value = Convert.ToDateTime(karyawan.TglMulaiKerja);

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
