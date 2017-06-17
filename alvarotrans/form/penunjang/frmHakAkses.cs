using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C = System.Convert;
using vm = alvarotrans.form.kelas.clsHimpunan;
using alvarotrans.form.record;

namespace alvarotrans.form.penunjang
{
    public partial class frmHakAkses : Form
    {
        public frmHakAkses()
        {
            InitializeComponent();
        }

        private void HakAkses()
        {
            vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblHakAkses WHERE Jabatan ='" + cboJabatan.Text + "'");

            if (vm.tabel.Rows.Count == 0)
            {
                Pengaturan();
            }
            else
            {
                // tab Sistem.
                trvSistem.Nodes["chkPengguna"].Checked = C.ToBoolean(vm.tabel.Rows[0]["Pengguna"]);
                trvSistem.Nodes["chkPengguna"].Nodes[0].Checked = C.ToBoolean(vm.tabel.Rows[0]["DataPengguna"]);
                trvSistem.Nodes["chkPengguna"].Nodes[1].Checked = C.ToBoolean(vm.tabel.Rows[0]["InputPengguna"]);
                trvSistem.Nodes["chkHakAkses"].Checked = C.ToBoolean(vm.tabel.Rows[0]["HakAkses"]);

                // tab Master.
                // sub-tab Master: Karyawan
                trvMaster.Nodes["chkKaryawan"].Checked = C.ToBoolean(vm.tabel.Rows[0]["Karyawan"]);
                trvMaster.Nodes["chkKaryawan"].Nodes[0].Checked = C.ToBoolean(vm.tabel.Rows[0]["DataKaryawan"]);
                trvMaster.Nodes["chkKaryawan"].Nodes[1].Checked = C.ToBoolean(vm.tabel.Rows[0]["InputKaryawan"]);
                // sub-tab Master: Pelanggan
                trvMaster.Nodes["chkPelanggan"].Checked = C.ToBoolean(vm.tabel.Rows[0]["Pelanggan"]);
                trvMaster.Nodes["chkPelanggan"].Nodes[0].Checked = C.ToBoolean(vm.tabel.Rows[0]["DataPelanggan"]);
                trvMaster.Nodes["chkPelanggan"].Nodes[1].Checked = C.ToBoolean(vm.tabel.Rows[0]["InputPelanggan"]);
                // sub-tab Master: Truk
                trvMaster.Nodes["chkTruk"].Checked = C.ToBoolean(vm.tabel.Rows[0]["Truk"]);
                trvMaster.Nodes["chkTruk"].Nodes[0].Checked = C.ToBoolean(vm.tabel.Rows[0]["DataTruk"]);
                trvMaster.Nodes["chkTruk"].Nodes[1].Checked = C.ToBoolean(vm.tabel.Rows[0]["InputTruk"]);
                // sub-tab Master: Tujuan
                trvMaster.Nodes["chkTujuan"].Checked = C.ToBoolean(vm.tabel.Rows[0]["Tujuan"]);
                trvMaster.Nodes["chkTujuan"].Nodes[0].Checked = C.ToBoolean(vm.tabel.Rows[0]["DataTujuan"]);
                trvMaster.Nodes["chkTujuan"].Nodes[1].Checked = C.ToBoolean(vm.tabel.Rows[0]["Inputtujuan"]);

                // tab Transaksi.
                // sub-tab Transaksi: Daftar Tunggu
                trvTransaksi.Nodes["chkTunggu"].Checked = C.ToBoolean(vm.tabel.Rows[0]["Tunggu"]);
                // sub-tab Transaksi: Pemesanan
                trvTransaksi.Nodes["chkPesan"].Checked = C.ToBoolean(vm.tabel.Rows[0]["Pesan"]);
                trvTransaksi.Nodes["chkPesan"].Nodes[0].Checked = C.ToBoolean(vm.tabel.Rows[0]["DataPesan"]);
                trvTransaksi.Nodes["chkPesan"].Nodes[1].Checked = C.ToBoolean(vm.tabel.Rows[0]["InputPesan"]);
                trvTransaksi.Nodes["chkPesan"].Nodes[2].Checked = C.ToBoolean(vm.tabel.Rows[0]["HapusPesan"]);
                // sub-tab Transaksi: Pengiriman
                trvTransaksi.Nodes["chkKirim"].Checked = C.ToBoolean(vm.tabel.Rows[0]["Kirim"]);
                trvTransaksi.Nodes["chkKirim"].Nodes[0].Checked = C.ToBoolean(vm.tabel.Rows[0]["DataKirim"]);
                trvTransaksi.Nodes["chkKirim"].Nodes[1].Checked = C.ToBoolean(vm.tabel.Rows[0]["InputKirim"]);
                trvTransaksi.Nodes["chkKirim"].Nodes[2].Checked = C.ToBoolean(vm.tabel.Rows[0]["HapusKirim"]);
                // sub-tab Transaksi: Transport
                trvTransaksi.Nodes["chkTransport"].Checked = C.ToBoolean(vm.tabel.Rows[0]["Transport"]);
                trvTransaksi.Nodes["chkTransport"].Nodes[0].Checked = C.ToBoolean(vm.tabel.Rows[0]["DataTransport"]);
                trvTransaksi.Nodes["chkTransport"].Nodes[1].Checked = C.ToBoolean(vm.tabel.Rows[0]["InputTransport"]);
                trvTransaksi.Nodes["chkTransport"].Nodes[2].Checked = C.ToBoolean(vm.tabel.Rows[0]["HapusTransport"]);
            }
        }

        private void Pengaturan()
        {
            // tab Sistem.
            trvSistem.Nodes["chkPengguna"].Checked = false;
            trvSistem.Nodes["chkPengguna"].Nodes[0].Checked = false;
            trvSistem.Nodes["chkPengguna"].Nodes[1].Checked = false;
            trvSistem.Nodes["chkHakAkses"].Checked = false;

            // tab Master.
            // sub-tab Master: Karyawan
            trvMaster.Nodes["chkKaryawan"].Checked = false;
            trvMaster.Nodes["chkKaryawan"].Nodes[0].Checked = false;
            trvMaster.Nodes["chkKaryawan"].Nodes[1].Checked = false;
            // sub-tab Master: Pelanggan
            trvMaster.Nodes["chkPelanggan"].Checked = false;
            trvMaster.Nodes["chkPelanggan"].Nodes[0].Checked = false;
            trvMaster.Nodes["chkPelanggan"].Nodes[1].Checked = false;
            // sub-tab Master: Truk
            trvMaster.Nodes["chkTruk"].Checked = false;
            trvMaster.Nodes["chkTruk"].Nodes[0].Checked = false;
            trvMaster.Nodes["chkTruk"].Nodes[1].Checked = false;
            // sub-tab Master: Tujuan
            trvMaster.Nodes["chkTujuan"].Checked = false;
            trvMaster.Nodes["chkTujuan"].Nodes[0].Checked = false;
            trvMaster.Nodes["chkTujuan"].Nodes[1].Checked = false;

            // tab Transaksi.
            // sub-tab Transaksi:  Daftar Tunggu
            trvTransaksi.Nodes["chkTunggu"].Checked = false;
            // sub-tab Transaksi: Pemesanan
            trvTransaksi.Nodes["chkPesan"].Checked = false;
            trvTransaksi.Nodes["chkPesan"].Nodes[0].Checked = false;
            trvTransaksi.Nodes["chkPesan"].Nodes[1].Checked = false;
            trvTransaksi.Nodes["chkPesan"].Nodes[2].Checked = false;
            // sub-tab Transaksi: Pengiriman
            trvTransaksi.Nodes["chkKirim"].Checked = false;
            trvTransaksi.Nodes["chkKirim"].Nodes[0].Checked = false;
            trvTransaksi.Nodes["chkKirim"].Nodes[1].Checked = false;
            trvTransaksi.Nodes["chkKirim"].Nodes[2].Checked = false;
            // sub-tab Transaksi: Transport
            trvTransaksi.Nodes["chkTransport"].Checked = false;
            trvTransaksi.Nodes["chkTransport"].Nodes[0].Checked = false;
            trvTransaksi.Nodes["chkTransport"].Nodes[1].Checked = false;
            trvTransaksi.Nodes["chkTransport"].Nodes[2].Checked = false;
        }

        private void Record()
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblJabatan ORDER BY Jabatan");
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
            if (vm.ApakahKosong(cboJabatan, "Jabatan"))
            {
                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void frmAkses_Load(object sender, EventArgs e)
        {
            Record();
            Pengaturan();
        }

        private void cboJabatan_KeyDown(object sender, KeyEventArgs e)
        {
            vm.InputNonAktif(e);
        }

        private void cboJabatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            vm.InputNonAktif(sender, e);
        }

        private void cboJabatan_TextChanged(object sender, EventArgs e)
        {
            HakAkses();
        }

        private void btnJabatan_Click(object sender, EventArgs e)
        {
            frmTipe jabatan = new frmTipe();
            jabatan.Text = "Jabatan - Hak Akses";
            if (jabatan.ShowDialog() == DialogResult.OK)
            {
                Record();
            }
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            vm.tabel = vm.proses.EksekusiQuery("SELECT * FROM tblHakAkses WHERE Jabatan ='" + cboJabatan.Text + "'");

            if (TidakTerisi() != true && vm.tabel.Rows.Count == 0)
            {
                vm.sql = "INSERT INTO tblHakAkses VALUES ('" + cboJabatan.Text +
                    // tab Sistem.
                    "','" + C.ToByte(trvSistem.Nodes["chkPengguna"].Checked) +
                    "','" + C.ToByte(trvSistem.Nodes["chkPengguna"].Nodes[0].Checked) +
                    "','" + C.ToByte(trvSistem.Nodes["chkPengguna"].Nodes[1].Checked) +
                    "','" + C.ToByte(trvSistem.Nodes["chkHakAkses"].Checked) +

                    // tab Master.
                    // sub-tab Master: Karyawan
                    "','" + C.ToByte(trvMaster.Nodes["chkKaryawan"].Checked) +
                    "','" + C.ToByte(trvMaster.Nodes["chkKaryawan"].Nodes[0].Checked) +
                    "','" + C.ToByte(trvMaster.Nodes["chkKaryawan"].Nodes[1].Checked) +
                    // sub-tab Master: Pelanggan
                    "','" + C.ToByte(trvMaster.Nodes["chkPelanggan"].Checked) +
                    "','" + C.ToByte(trvMaster.Nodes["chkPelanggan"].Nodes[0].Checked) +
                    "','" + C.ToByte(trvMaster.Nodes["chkPelanggan"].Nodes[1].Checked) +
                    // sub-tab Master: Truk
                    "','" + C.ToByte(trvMaster.Nodes["chkTruk"].Checked) +
                    "','" + C.ToByte(trvMaster.Nodes["chkTruk"].Nodes[0].Checked) +
                    "','" + C.ToByte(trvMaster.Nodes["chkTruk"].Nodes[1].Checked) +
                    // sub-tab Master: Tujuan
                    "','" + C.ToByte(trvMaster.Nodes["chkTujuan"].Checked) +
                    "','" + C.ToByte(trvMaster.Nodes["chkTujuan"].Nodes[0].Checked) +
                    "','" + C.ToByte(trvMaster.Nodes["chkTujuan"].Nodes[1].Checked) +

                    // tab Transaksi.
                    // sub-tab Transaksi:  Daftar Tunggu
                    "','" + C.ToByte(trvTransaksi.Nodes["chkTunggu"].Checked) +
                    // sub-tab Transaksi: Pemesanan
                    "','" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Checked) +
                    "','" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Nodes[0].Checked) +
                    "','" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Nodes[1].Checked) +
                    "','" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Nodes[2].Checked) +
                    // sub-tab Transaksi: Pengiriman
                    "','" + C.ToByte(trvTransaksi.Nodes["chkKirim"].Checked) +
                    "','" + C.ToByte(trvTransaksi.Nodes["chkKirim"].Nodes[0].Checked) +
                    "','" + C.ToByte(trvTransaksi.Nodes["chkKirim"].Nodes[1].Checked) +
                    "','" + C.ToByte(trvTransaksi.Nodes["chkKirim"].Nodes[2].Checked) +
                    // sub-tab Transaksi: Transport
                    "','" + C.ToByte(trvTransaksi.Nodes["chkTransport"].Checked) +
                    "','" + C.ToByte(trvTransaksi.Nodes["chkTransport"].Nodes[0].Checked) +
                    "','" + C.ToByte(trvTransaksi.Nodes["chkTransport"].Nodes[1].Checked) +
                    "','" + C.ToByte(trvTransaksi.Nodes["chkTransport"].Nodes[2].Checked) + "')";
                vm.proses.EksekusiNonQuery(vm.sql);

                vm.pesan = "Data hak akses dengan Jabatan: '" + cboJabatan.Text + "' telah tersimpan.";
                MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TidakTerisi() != true && vm.tabel.Rows.Count != 0)
            {
                // tab Sistem.
                vm.sql = "UPDATE tblHakAkses SET Pengguna = '" + C.ToByte(trvSistem.Nodes["chkPengguna"].Checked) +
                    "', DataPengguna = '" + C.ToByte(trvSistem.Nodes["chkPengguna"].Nodes[0].Checked) +
                    "', InputPengguna = '" + C.ToByte(trvSistem.Nodes["chkPengguna"].Nodes[1].Checked) +
                    "', HakAkses = '" + C.ToByte(trvSistem.Nodes["chkHakAkses"].Checked) +

                    // tab Master.
                    // sub-tab Master: Karyawan
                    "', Karyawan = '" + C.ToByte(trvMaster.Nodes["chkKaryawan"].Checked) +
                    "', DataKaryawan = '" + C.ToByte(trvMaster.Nodes["chkKaryawan"].Nodes[0].Checked) +
                    "', InputKaryawan = '" + C.ToByte(trvMaster.Nodes["chkKaryawan"].Nodes[1].Checked) +
                    // sub-tab Master: Pelanggan
                    "', Pelanggan = '" + C.ToByte(trvMaster.Nodes["chkPelanggan"].Checked) +
                    "', DataPelanggan = '" + C.ToByte(trvMaster.Nodes["chkPelanggan"].Nodes[0].Checked) +
                    "', InputPelanggan = '" + C.ToByte(trvMaster.Nodes["chkPelanggan"].Nodes[1].Checked) +
                    // sub-tab Master: Truk
                    "', Truk = '" + C.ToByte(trvMaster.Nodes["chkTruk"].Checked) +
                    "', DataTruk = '" + C.ToByte(trvMaster.Nodes["chkTruk"].Nodes[0].Checked) +
                    "', InputTruk = '" + C.ToByte(trvMaster.Nodes["chkTruk"].Nodes[1].Checked) +
                    // sub-tab Master: Tujuan
                    "', Tujuan = '" + C.ToByte(trvMaster.Nodes["chkTujuan"].Checked) +
                    "', DataTujuan = '" + C.ToByte(trvMaster.Nodes["chkTujuan"].Nodes[0].Checked) +
                    "', InputTujuan = '" + C.ToByte(trvMaster.Nodes["chkTujuan"].Nodes[1].Checked) +

                    // tab Transaksi.
                    // sub-tab Transaksi:  Daftar Tunggu
                    "', DaftarTunggu = '" + C.ToByte(trvTransaksi.Nodes["chkTunggu"].Checked) +
                    // sub-tab Transaksi: Pemesanan
                    "', Pesan = '" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Checked) +
                    "', DataPesan = '" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Nodes[0].Checked) +
                    "', InputPesan = '" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Nodes[1].Checked) +
                    "', HapusPesan = '" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Nodes[2].Checked) +
                    // sub-tab Transaksi: Pengiriman
                    "', Kirim = '" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Checked) +
                    "', DataKirim = '" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Nodes[0].Checked) +
                    "', InputKirim = '" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Nodes[1].Checked) +
                    "', HapusKirim = '" + C.ToByte(trvTransaksi.Nodes["chkPesan"].Nodes[2].Checked) +
                    // sub-tab Transaksi: Transport
                    "', Transport = '" + C.ToByte(trvTransaksi.Nodes["chkTransport"].Checked) +
                    "', DataTransport = '" + C.ToByte(trvTransaksi.Nodes["chkTransport"].Nodes[0].Checked) +
                    "', InputTransport = '" + C.ToByte(trvTransaksi.Nodes["chkTransport"].Nodes[1].Checked) +
                    "', HapusTransport = '" + C.ToByte(trvTransaksi.Nodes["chkTransport"].Nodes[2].Checked) +
                    "' WHERE Jabatan = '" + cboJabatan.Text + "'";
                vm.proses.EksekusiNonQuery(vm.sql);

                vm.pesan = "Data hak akses dengan Jabatan: '" + cboJabatan.Text + "' telah diubah.";
                MessageBox.Show(vm.pesan, "Ubah data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cboJabatan.SelectedIndex = -1;
        }

        private void tsbTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
