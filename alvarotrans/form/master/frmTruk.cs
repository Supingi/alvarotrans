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
    public partial class frmTruk : Form
    {
        public frmTruk()
        {
            InitializeComponent();
        }

        private void Record()
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblTipeTrailer ORDER BY TipeTrailer");
                cboTipeTrailer.DataSource = vm.tabel;
                cboTipeTrailer.DisplayMember = "TipeTrailer";
                cboTipeTrailer.SelectedIndex = -1;

                cboTahunBuat.Items.Clear();
                for (int i = 1990; i <= 9999; i++)
                {
                    if(i > DateTime.Now.Year)
                    {
                        break;
                    }
                    cboTahunBuat.Items.Add(i);
                }
                cboTahunBuat.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Pengaturan()
        {
            switch (vm.status)
            {
                case true:
                    txtNoPolisi.Enabled = true;
                    tsbSimpan.Enabled = true;
                    tsbUbah.Enabled = false;
                    tsbHapus.Enabled = false;
                    tsbBatal.Enabled = false;
                    Record();
                    vm.KosongkanIsiText(this);
                    break;
                case false:
                    txtNoPolisi.Enabled = false;
                    tsbSimpan.Enabled = false;
                    tsbUbah.Enabled = true;
                    tsbHapus.Enabled = true;
                    tsbBatal.Enabled = true;
                    break;
            }
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtNoPolisi, "No. Polisi") || vm.ApakahKosong(txtMerk, "Merk")||
                vm.ApakahKosong(cboTipeTrailer, "Tipe Trailer")|| vm.ApakahKosong(cboTahunBuat, "Tahun Buat") ||
                vm.ApakahKosong(txtSTNK, "STNK") || vm.ApakahKosong(txtNoKir, "No. Kir") || 
                vm.ApakahKosong(txtNoRangka, "No. Rangka") ||  vm.ApakahKosong(txtBPKB, "BPKB") || 
                vm.ApakahKosong(txtNoMesin, "No. Mesin") || vm.ApakahKosong(cboKondisi, "Kondisi"))
            {
                vm.tidakTerisi = true;
            }
            else if ((txtIdSupir1.Text == txtIdSupir2.Text && txtIdSupir1.Text != String.Empty && txtIdSupir2.Text != String.Empty) ||
                ((txtIdSupir1.Text != String.Empty && txtIdSupir2.Text == String.Empty) || (txtIdSupir1.Text == String.Empty && txtIdSupir2.Text != String.Empty)))
            {
                vm.pesan = "Data supir yang diinput tidak dapat diisi hanya dengan satu supir " +
                    "atau dengan data yang sama dikedua kolom informasi supir yang disediakan.\n\n" +
                    "P.S: Kosongkan kedua data supir jika hanya terdapat satu supir yang tersisah.";
                MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                vm.tidakTerisi = true;
            }
            else if (txtIdSupir1.Text == String.Empty && txtIdSupir2.Text == String.Empty)
            {
                vm.tidakTerisi = false;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private string NamaSupir(string idKaryawan)
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT NamaKaryawan FROM tblKaryawan WHERE IdKaryawan = '" +
                    idKaryawan + "'");
                return vm.tabel.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return null; ;
            }
        }

        private void frmTruk_Load(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void btnTipe_Click(object sender, EventArgs e)
        {
            frmTipe truk = new frmTipe();
            truk.Text = "Tipe Trailer - Truk";
            if (truk.ShowDialog() == DialogResult.OK)
            {
                Record();
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

        private void cboTahunBuat_KeyDown(object sender, KeyEventArgs e)
        {
            vm.InputNonAktif(e);
        }

        private void cboTahunBuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void btnIdSupir1_Click(object sender, EventArgs e)
        {
            frmData supir = new frmData();
            supir.Text = "Data Karyawan - Supir 1";
            if (supir.ShowDialog() == DialogResult.OK)
            {
                txtIdSupir1.Text = supir.IdKaryawan;
                txtNamaSupir1.Text = supir.NamaKaryawan;
            }
        }

        private void txtIdSupir1_TextChanged(object sender, EventArgs e)
        {
            txtNamaSupir1.Text = NamaSupir(txtIdSupir1.Text);
        }

        private void btnIdSupir2_Click(object sender, EventArgs e)
        {
            frmData supir = new frmData();
            supir.Text = "Data Karyawan - Supir 2";
            if (supir.ShowDialog() == DialogResult.OK)
            {
                txtIdSupir2.Text = supir.IdKaryawan;
                txtNamaSupir2.Text = supir.NamaKaryawan;
            }
        }

        private void txtIdSupir2_TextChanged(object sender, EventArgs e)
        {
            txtNamaSupir2.Text = NamaSupir(txtIdSupir2.Text);
        }

        private void cboKondisi_KeyDown(object sender, KeyEventArgs e)
        {
            vm.InputNonAktif(e);
        }

        private void cboKondisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.sql = "INSERT INTO tblTruk VALUES ('" + txtNoPolisi.Text.ToUpper() +
                        "','" + txtMerk.Text.ToUpper() +
                        "','" + cboTipeTrailer.Text +
                        "','" + cboTahunBuat.Text +
                        "','" + txtSTNK.Text +
                        "','" + txtNoKir.Text +
                        "','" + txtNoRangka.Text +
                        "','" + txtBPKB.Text +
                        "','" + txtNoMesin.Text + 
                        "','" + txtIdSupir1.Text + 
                        "','" + txtIdSupir2.Text + 
                        "','" + cboKondisi.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data truk dengan No. Polisi: '" + txtNoPolisi.Text + "' telah tersimpan.";
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
                    vm.pesan = "Apakah anda akan melakukan perubahan pada data truk dengan No. Polisi: '" +
                            txtNoPolisi.Text + "'?";

                    if (vm.PesanPeringatan(vm.pesan, "Ubah data"))
                    {
                        vm.sql = "UPDATE tblTruk SET Merk = '" + txtMerk.Text.ToUpper() +
                            "', TipeTrailer = '" + cboTipeTrailer.Text +
                            "', TahunBuat = '" + cboTahunBuat.Text +
                            "', NoSTNK = '" + txtSTNK.Text +
                            "', NoKir = '" + txtNoKir.Text +
                            "', NoRangka ='" + txtNoRangka.Text +
                            "', NoBPKB = '" + txtBPKB.Text +
                            "', NoMesin = '" + txtNoMesin.Text +
                            "', IdSupir1 = '" + txtIdSupir1.Text +
                            "', IdSupir2 = '" + txtIdSupir2.Text +
                            "', Kondisi = '" + cboKondisi.Text +
                            "' WHERE NoPolisi = '" + txtNoPolisi.Text + "'";
                        vm.proses.EksekusiNonQuery(vm.sql);

                        vm.pesan = "Data truk dengan No. Polisi: '" + txtNoPolisi.Text + "' telah diubah.";
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
                vm.pesan = "Apakah anda akan melakukan penghapusan pada data truk dengan No. Polisi: '" + 
                    txtNoPolisi.Text + "'?";

                if (vm.PesanPeringatan(vm.pesan, "Hapus data"))
                {
                    vm.sql = "DELETE FROM tblTruk WHERE NoPolisi = '" + txtNoPolisi.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data truk dengan No. Polisi: '" + txtNoPolisi.Text + "' telah dihapus.";
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

        private void tsbRecordTruk_Click(object sender, EventArgs e)
        {
            frmData truk = new frmData();
            truk.Text = "Data Truk - Truk";
            if (truk.ShowDialog() == DialogResult.OK)
            {
                txtNoPolisi.Text = truk.NoPolisi;
                txtMerk.Text = truk.Merk;
                cboTipeTrailer.Text = truk.TipeTrailer;
                cboTahunBuat.Text = truk.TahunBuat;
                txtSTNK.Text = truk.STNK;
                txtNoKir.Text = truk.NoKir;
                txtNoRangka.Text = truk.NoRangka;
                txtBPKB.Text = truk.BPKB;
                txtNoMesin.Text = truk.NoMesin;
                txtIdSupir1.Text = truk.IdSupir1;
                txtIdSupir2.Text = truk.IdSupir2;
                cboKondisi.Text = truk.Kondisi;

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
