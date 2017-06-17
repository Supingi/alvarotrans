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
    public partial class frmTujuan : Form
    {
        public frmTujuan()
        {
            InitializeComponent();
        }

        private void Record()
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT TipeTrailer, Transport, Harga FROM tblHarga WHERE KodeTujuan = '" +
                   txtKodeTujuan.Text + "' ORDER BY TipeTrailer");
                dgvTransport.DataSource = vm.tabel;

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
            if (vm.ApakahKosong(txtKotaTujuan, "Kotra Tujuan") || vm.ApakahKosong(txtDaerahTujuan, "Daerah Tujuan") ||
                vm.ApakahKosong(txtTrasport, "Transport") || vm.ApakahKosong(cboTipeTrailer, "Tipe Trailer") ||
                vm.ApakahKosong(txtHarga, "Harga"))
            {
                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private bool TidakTerisi(GroupBox groupBox)
        {
            if (vm.ApakahKosong(cboTipeTrailer, "Tipe Trailer") || vm.ApakahKosong(txtTrasport, "Transport") ||
                vm.ApakahKosong(txtHarga, "Harga"))
            {
                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
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

                    tsbTambah.Enabled = false;
                    tsbUbahTransport.Enabled = false;
                    tsbHapusTransport.Enabled = false;
                    tsbBatalTransport.Enabled = false;

                    vm.KosongkanIsiText(this);
                    vm.KosongkanIsiText(gbxTransport);
                    txtKodeTujuan.Text = "TJN" + vm.KodeOtomatis("KodeTujuan", "tblTujuan", "KodeTujuan");
                    break;
                case false:
                    tsbSimpan.Enabled = false;
                    tsbUbah.Enabled = true;
                    tsbHapus.Enabled = true;
                    tsbBatal.Enabled = true;
                    break;
            }
            Record();
        }

        private void frmTujuan_Load(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void dgvTransport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cboTipeTrailer.Text = dgvTransport.SelectedCells[0].Value.ToString();
            txtTrasport.Text = dgvTransport.SelectedCells[1].Value.ToString();
            txtHarga.Text = dgvTransport.SelectedCells[2].Value.ToString();
        }
        
        private void cboTipeTrailer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Periksa tblHarga dengan parameter KodeTujuan dan TipeTrailer.
                vm.tabel = vm.proses.EksekusiQuery("SELECT Transport, Harga FROM tblHarga WHERE KodeTujuan = '" +
                txtKodeTujuan.Text + "' AND TipeTrailer = '" + cboTipeTrailer.Text + "' ORDER BY TipeTrailer");

                if (vm.tabel.Rows.Count == 1) // Kondisi ditemukan 1.
                {
                    txtTrasport.Text = vm.tabel.Rows[0][0].ToString();
                    txtHarga.Text = vm.tabel.Rows[0][1].ToString();
                    tsbTambah.Enabled = false;
                    tsbUbahTransport.Enabled = true;
                    tsbHapusTransport.Enabled = true;
                    tsbBatalTransport.Enabled = true;
                }
                else if (vm.tabel.Rows.Count == 0) // Kondisi ditemukan 0.
                {
                    txtTrasport.Text = txtHarga.Text = String.Empty;
                    tsbTambah.Enabled = true;
                    tsbUbahTransport.Enabled = false;
                    tsbHapusTransport.Enabled = false;
                    tsbBatalTransport.Enabled = true;

                    // Periksa tblTujuan dengan parameter KodeTujuan. 
                    // Bertujuan untuk nonaktif instrumen dalam panel GroupBox.
                    vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblTujuan WHERE KodeTujuan = '" + 
                        txtKodeTujuan.Text + "'");

                    if (cboTipeTrailer.SelectedIndex == -1 || vm.tabel.Rows.Count == 0)
                    {
                        txtTrasport.Text = txtHarga.Text = String.Empty;
                        tsbTambah.Enabled = false;
                        tsbUbahTransport.Enabled = false;
                        tsbBatalTransport.Enabled = false;
                        tsbHapusTransport.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                return;
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

        private void txtTrasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void tsbTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi(gbxTransport) != true)
                {
                    vm.sql = "INSERT INTO tblHarga VALUES ('" + txtKodeTujuan.Text +
                           "','" + cboTipeTrailer.Text +
                           "','" + txtTrasport.Text +
                           "','" + txtHarga.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data harga dengan Kode Tujuan: '" + txtKodeTujuan.Text + "' dan Tipe Trailer: '" +
                        cboTipeTrailer.Text + "'telah tersimpan.";
                    MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Record();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbUbahTransport_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi(gbxTransport) != true)
                {
                    vm.pesan = "Apakah anda akan melakukan perubahan pada data harga dengan Kode Tujuan: '" + 
                        txtKodeTujuan.Text + "'?";

                    if (vm.PesanPeringatan(vm.pesan, "Ubah data"))
                    {
                        vm.sql = "UPDATE tblHarga SET Transport = '" + txtTrasport.Text +
                            "', Harga = '" + txtHarga.Text +
                            "' WHERE KodeTujuan = '" + txtKodeTujuan.Text +
                            "' AND TipeTrailer = '" + cboTipeTrailer.Text + "'";
                        vm.proses.EksekusiNonQuery(vm.sql);


                        vm.pesan = "Data harga dengan Kode Tujuan: '" + txtKodeTujuan.Text + "' telah diubah.";
                        MessageBox.Show(vm.pesan, "Ubah data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Record();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbHapusTransport_Click(object sender, EventArgs e)
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblHarga WHERE KodeTujuan = '" +
                   txtKodeTujuan.Text + "' ORDER BY TipeTrailer");

                vm.pesan = "Apakah anda akan melakukan penghapusan pada data harga dengan Kode Tujuan: '" +
                    txtKodeTujuan.Text + "'?\n\nP.S: Penghapusan data harga ini sekaligus dapat menghapus data " +
                    "tujuan pengiriman dengan Kode Tujuan '" + txtKodeTujuan.Text + "'.";

                if (vm.tabel.Rows.Count == 1 && vm.PesanPeringatan(vm.pesan, "Hapus Data"))
                {
                    vm.sql = "DELETE FROM tblTujuan WHERE KodeTujuan = '" + txtKodeTujuan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.sql = "DELETE FROM tblHarga WHERE KodeTujuan = '" + txtKodeTujuan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data tujuan dengan Kode Tujuan: '" + txtKodeTujuan.Text + "' telah dihapus.";
                    MessageBox.Show(vm.pesan, "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    vm.status = true;
                    Pengaturan();
                }
                else if (vm.tabel.Rows.Count != 1 && vm.PesanPeringatan("Apakah anda akan melakukan penghapusan pada data harga dengan Tipe Trailer: " +
                    cboTipeTrailer.Text + "' dan Kode Tujuan: '" + txtKodeTujuan.Text + "'?", "Hapus Data"))
                {
                    vm.sql = "DELETE FROM tblHarga WHERE KodeTujuan = '" + txtKodeTujuan.Text + 
                        "' AND TipeTrailer = '" + cboTipeTrailer.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data harga dengan Kode Tujuan: '" + txtKodeTujuan.Text + "' telah dihapus.";
                    MessageBox.Show(vm.pesan, "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Record();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbBatalTransport_Click(object sender, EventArgs e)
        {
            Record();
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.sql = "INSERT INTO tblTujuan VALUES ('" + txtKodeTujuan.Text +
                        "','" + txtKotaTujuan.Text +
                        "','" + txtDaerahTujuan.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.sql = "INSERT INTO tblHarga VALUES ('" + txtKodeTujuan.Text +
                        "','" + cboTipeTrailer.Text +
                        "','" + txtTrasport.Text +
                        "','" + txtHarga.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data tujuan dan data harga dengan Kode Tujuan: '" + txtKodeTujuan.Text + "' telah tersimpan.";
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
                    vm.pesan = "Apakah anda akan melakukan perubahan pada data tujuan dengan Kode Tujuan: '" +
                            txtKodeTujuan.Text + "'?";

                    if (vm.PesanPeringatan(vm.pesan, "Ubah data"))
                    {
                        vm.sql = "UPDATE tblTujuan SET KotaTujuan = '" + txtKotaTujuan.Text +
                            "', DaerahTujuan = '" + txtDaerahTujuan.Text +
                            "' WHERE KodeTujuan = '" + txtKodeTujuan.Text + "'";
                        vm.proses.EksekusiNonQuery(vm.sql);

                        vm.pesan = "Data tujuan dengan Kode Tujuan: '" + txtKodeTujuan.Text + "' telah diubah.";
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
                vm.pesan = "Apakah anda akan melakukan penghapusan pada data tujuan dengan Kode Tujuan: '" +
                    txtKodeTujuan.Text + "'?\n\nP.S: Penghapusan data tujuan ini sekaligus dapat menghapus data harga " +
                    "pengiriman dengan Kode Tujuan: '" + txtKodeTujuan.Text + "'.";
                if (vm.PesanPeringatan(vm.pesan, "Hapus data"))
                {
                    vm.sql = "DELETE FROM tblTujuan WHERE KodeTujuan = '" + txtKodeTujuan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.sql = "DELETE FROM tblHarga WHERE KodeTujuan = '" + txtKodeTujuan.Text + "'";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data tujuan dan data harga dengan Kode Tujuan: '" + txtKodeTujuan.Text + "' telah dihapus.";
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

        private void tsbRecord_Click(object sender, EventArgs e)
        {
            frmData harga = new frmData();
            harga.Text = "Data Tujuan - Tujuan";
            if (harga.ShowDialog() == DialogResult.OK)
            {
                txtKodeTujuan.Text = harga.KodeTujuan;
                txtKotaTujuan.Text = harga.KotaTujuan;
                txtDaerahTujuan.Text = harga.DaerahTujuan;

                vm.status = false;
                Pengaturan();
            }
        }


        private void tsbCetak_Click(object sender, EventArgs e)
        {
            try
            {
                frmReport pedoman = new frmReport();
                pedoman.Text = "Pedoman Harga";
                pedoman.ShowDialog();

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
