using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using alvarotrans.form.master;
using vm = alvarotrans.form.kelas.clsHimpunan;

namespace alvarotrans.form.record
{
    public partial class frmTipe : Form
    {
        public frmTipe()
        {
            InitializeComponent();
        }

        private void Record()
        {
            try
            {
                switch (this.Text)
                {
                    case "Jabatan - Hak Akses":
                        vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblJabatan ORDER BY Jabatan ASC");
                        dgvPilihan.DataSource = vm.tabel;
                        dgvPilihan.Columns[0].Width = 295;
                        break;
                    case "Tipe Trailer - Truk":
                        vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblTipeTrailer ORDER BY TipeTrailer ASC");
                        dgvPilihan.DataSource = vm.tabel;
                        dgvPilihan.Columns[0].Width = 295;
                        break;
                }
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
                    tsbSimpan.Enabled = true;
                    tsbUbah.Enabled = false;
                    tsbHapus.Enabled = false;
                    tsbBatal.Enabled = false;
                    Record();
                    vm.KosongkanIsiText(this);
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
            if (vm.ApakahKosong(txtPilihan, "Pilihan"))
                vm.tidakTerisi = true;
            else
                vm.tidakTerisi = false;
            return vm.tidakTerisi;
        }

        private void frmTipe_Activated(object sender, EventArgs e)
        {
            Pengaturan();
        }

        private void frmTipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmTipe_Load(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case "Jabatan - Hak Akses":
                    lblKeterangan1.Text = "Record Data Jabatan";
                    lblKeterangan2.Text = "Form ini digunakan untuk menyimpan data jabatan karyawan CV. Alvaro Trans Cargo " +
                        ", Sekaligus untuk menentukan hak akses setiap karyawan pengguna aplikasi.";
                    lblPilihan.Text = "Jabatan :";
                    lblKeterangan3.Text = "*Input jabatan.";
                    break;
                case "Tipe Trailer - Truk":
                    lblKeterangan1.Text = "Record Data Tipe Trailer";
                    lblKeterangan2.Text = "Form ini digunakan untuk menyimpan data tipe trailer yang digunakan pada truk";
                    lblPilihan.Text = "Tipe Trailer :";
                    lblKeterangan3.Text = "*Input tipe Trailer.";
                    break;
            }
            vm.status = true;
            Pengaturan();
        }

        private void dgvPilihan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtPilihan.Text = dgvPilihan.SelectedCells[0].Value.ToString();
                vm.status = false;
                Pengaturan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    switch (this.Text)
                    {
                        case "Jabatan - Hak Akses":
                            vm.sql = "INSERT INTO tblJabatan VALUES ('" + txtPilihan.Text + "')";
                            vm.proses.EksekusiNonQuery(vm.sql);
                            break;
                        case "Tipe Trailer - Truk":
                            vm.sql = "INSERT INTO tblTipeTrailer VALUES ('" + txtPilihan.Text + "')";
                            vm.proses.EksekusiNonQuery(vm.sql);
                            break;
                    }
                    vm.pesan = "Data baru: '" + txtPilihan.Text + "' telah tersimpan.";
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
                    vm.pesan = "Apakah anda akan melakukan perubahan pada data: '" + 
                        dgvPilihan.SelectedCells[0].Value.ToString() + "' dengan: '"+ txtPilihan.Text + "'?";
                    
                    if (vm.PesanPeringatan(vm.pesan, "Ubah data"))
                    {
                        switch (this.Text)
                        
                        {
                            case "Jabatan - Hak Akses":
                                vm.sql = "UPDATE tblKaryawan SET Jabatan = '" + txtPilihan.Text +
                                    "' WHERE Jabatan = '" + dgvPilihan.SelectedCells[0].Value + "'";
                                vm.proses.EksekusiNonQuery(vm.sql);

                                vm.sql = "UPDATE tblHakAkses SET Jabatan = '" + txtPilihan.Text +
                                    "' WHERE Jabatan = '" + dgvPilihan.SelectedCells[0].Value + "'";
                                vm.proses.EksekusiNonQuery(vm.sql);

                                vm.sql = "UPDATE tblJabatan SET Jabatan = '" + txtPilihan.Text +
                                    "' WHERE Jabatan = '" + dgvPilihan.SelectedCells[0].Value + "'";
                                vm.proses.EksekusiNonQuery(vm.sql);
                                break;
                            case "Tipe Trailer - Truk":
                                vm.sql = "UPDATE tblTruk SET TipeTrailer = '" + txtPilihan.Text +
                                    "' WHERE TipeTrailer = '" + dgvPilihan.SelectedCells[0].Value + "'";
                                vm.proses.EksekusiNonQuery(vm.sql);

                                vm.sql = "UPDATE tblTipeTrailer SET TipeTrailer = '" + txtPilihan.Text +
                                    "' WHERE TipeTrailer = '" + dgvPilihan.SelectedCells[0].Value + "'";
                                vm.proses.EksekusiNonQuery(vm.sql);
                                break;
                        }
                        vm.pesan = "Data: '" + dgvPilihan.SelectedCells[0].Value.ToString() + 
                            "' telah berhasil diubah dengan: '" + txtPilihan.Text + "'";
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
                vm.pesan = "Apakah anda akan melakukan penghapusan pada data: '" +
                   dgvPilihan.SelectedCells[0].Value.ToString() + "'?";

                if (vm.PesanPeringatan(vm.pesan, "Hapus data"))
                {
                    switch (this.Text)
                    {
                        case "Jabatan - Hak Akses":
                            vm.sql = "DELETE FROM tblHakAkses WHERE Jabatan = '" + txtPilihan.Text + "'";
                            vm.proses.EksekusiNonQuery(vm.sql);

                            vm.sql = "DELETE FROM tblJabatan WHERE Jabatan = '" + txtPilihan.Text + "'";
                            vm.proses.EksekusiNonQuery(vm.sql);
                            break;
                        case "Tipe Trailer - Truk":
                            vm.sql = "DELETE FROM tblTipeTrailer WHERE TipeTrailer = '" + txtPilihan.Text + "'";
                            vm.proses.EksekusiNonQuery(vm.sql);
                            break;
                    }
                    vm.pesan = "Data: '" + dgvPilihan.SelectedCells[0].Value.ToString() + "' telah dihapus.";
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

        private void tsbTutup_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
