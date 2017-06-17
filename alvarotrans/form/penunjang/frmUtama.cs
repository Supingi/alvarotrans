using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using alvarotrans.form.master;
using alvarotrans.form.record;
using alvarotrans.form.transaksi;
using C = System.Convert;
using vm = alvarotrans.form.kelas.clsHimpunan;

namespace alvarotrans.form.penunjang
{
    public partial class frmUtama : Form
    {
        private string idKaryawan { get; set; }
        private string namaKaryawan { get; set; }

        public frmUtama()
        {
            InitializeComponent();
        }

        public frmUtama(string id, string nama)
        {
            InitializeComponent();
            idKaryawan = id;
            namaKaryawan = nama;
        }

        frmLogin login = new frmLogin();
        private void HakAkses()
        {
            vm.tabel = vm.proses.EksekusiQuery("SELECT  ha.* FROM tblHakAkses ha INNER JOIN tblKaryawan k ON " +
                "ha.Jabatan = k.Jabatan AND k.IdKaryawan = '" + idKaryawan + "'");

            if (vm.tabel.Rows.Count == 0)
            {
                // tab Sistem.
                menuHakAkses.Enabled = false;
                menuPengguna.Enabled = false;
                menuDataPengguna.Enabled = false;
                menuInputPengguna.Enabled = false;

                // tab Master.
                // sub-tab Master: Karyawan
                menuKaryawan.Enabled = false;
                menuDataKaryawan.Enabled = false;
                menuInputKaryawan.Enabled = false;
                // sub-tab Master: Pelanggan
                menuPelanggan.Enabled = false;
                menuDataPelanggan.Enabled = false;
                menuInputPelanggan.Enabled = false;
                // sub-tab Master: Truk
                menuTruk.Enabled = false;
                menuDataTruk.Enabled = false;
                menuInputTruk.Enabled = false;
                // sub-tab Master: Tujuan
                menuTujuan.Enabled = false;
                menuDataTujuan.Enabled = false;
                menuInputTujuan.Enabled = false;

                // tab Transaksi.
                // sub-tab Transaksi: Daftar Tunggu
                menuTunggu.Enabled = false;
                // sub-tab Transaksi: Pemesanan
                menuPesan.Enabled = false;
                menuDataPesan.Enabled = false;
                menuInputPesan.Enabled = false;
                menuHapusPesan.Enabled = false;
                // sub-tab Transaksi: Pengiriman
                menuKirim.Enabled = false;
                menuDataKirim.Enabled = false;
                menuInputKirim.Enabled = false;
                menuHapusKirim.Enabled = false;
                // sub-tab Transaksi: Transport
                menuTransport.Enabled = false;
                menuDataTransport.Enabled = false;
                menuInputTransport.Enabled = false;
                menuHapusTransport.Enabled = false;
            }
            else
            {
                // tab Sistem.
                menuHakAkses.Enabled = C.ToBoolean(vm.tabel.Rows[0]["HakAkses"]);
                menuPengguna.Enabled = C.ToBoolean(vm.tabel.Rows[0]["Pengguna"]);
                menuDataPengguna.Enabled = C.ToBoolean(vm.tabel.Rows[0]["DataPengguna"]);
                menuInputPengguna.Enabled = C.ToBoolean(vm.tabel.Rows[0]["InputPengguna"]);

                // tab Master.
                // sub-tab Master: Karyawan
                menuKaryawan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["Karyawan"]);
                menuDataKaryawan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["DataKaryawan"]);
                menuInputKaryawan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["InputKaryawan"]);
                // sub-tab Master: Pelanggan
                menuPelanggan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["Pelanggan"]);
                menuDataPelanggan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["DataPelanggan"]);
                menuInputPelanggan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["InputPelanggan"]);
                // sub-tab Master: Truk
                menuTruk.Enabled = C.ToBoolean(vm.tabel.Rows[0]["Truk"]);
                menuDataTruk.Enabled = C.ToBoolean(vm.tabel.Rows[0]["DataTruk"]);
                menuInputTruk.Enabled = C.ToBoolean(vm.tabel.Rows[0]["InputTruk"]);
                // sub-tab Master: Tujuan
                menuTujuan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["Tujuan"]);
                menuDataTujuan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["DataTujuan"]);
                menuInputTujuan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["InputTujuan"]);

                // tab Transaksi.
                // sub-tab Transaksi: Daftar Tunggu
                menuTunggu.Enabled = C.ToBoolean(vm.tabel.Rows[0]["Tunggu"]);
                // sub-tab Transaksi: Pemesanan
                menuPesan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["Pesan"]);
                menuDataPesan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["DataPesan"]);
                menuInputPesan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["InputPesan"]);
                menuHapusPesan.Enabled = C.ToBoolean(vm.tabel.Rows[0]["HapusPesan"]);
                // sub-tab Transaksi: Pengiriman
                menuKirim.Enabled = C.ToBoolean(vm.tabel.Rows[0]["Kirim"]);
                menuDataKirim.Enabled = C.ToBoolean(vm.tabel.Rows[0]["DataKirim"]);
                menuInputKirim.Enabled = C.ToBoolean(vm.tabel.Rows[0]["InputKirim"]);
                menuHapusKirim.Enabled = C.ToBoolean(vm.tabel.Rows[0]["HapusKirim"]);
                // sub-tab Transaksi: Transport
                menuTransport.Enabled = C.ToBoolean(vm.tabel.Rows[0]["Transport"]);
                menuDataTransport.Enabled = C.ToBoolean(vm.tabel.Rows[0]["DataTransport"]);
                menuInputTransport.Enabled = C.ToBoolean(vm.tabel.Rows[0]["InputTransport"]);
                menuHapusTransport.Enabled = C.ToBoolean(vm.tabel.Rows[0]["HapusTransport"]);
            }
        }

        private void tmrUtama_Tick(object sender, EventArgs e)
        {
            tmrUtama.Interval = 1000;
            tmrUtama.Start();
            int hr = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            string bahasa = "id-ID";
            DateTimeFormatInfo formatID = DateTimeFormatInfo.GetInstance(CultureInfo.GetCultureInfo(bahasa));
            CultureInfo ci = new CultureInfo("id-ID");

            tstJam.Text = "Jam : " + hr + ":" + min + ":" + sec;
            tstTanggal.Text = "Tanggal : " +
                DateTime.Now.ToString(formatID.LongDatePattern, new CultureInfo(bahasa));
        }

        private void frmUtama_Load(object sender, EventArgs e)
        {
            HakAkses();
            tstIdKaryawan.Text = idKaryawan;
            tstNamaKaryawan.Text = namaKaryawan;
            tmrUtama.Enabled = true;
        }

        private void menuHakAkses_Click(object sender, EventArgs e)
        {
            frmHakAkses pengguna = new frmHakAkses();
            pengguna.ShowDialog();
        }

        private void menuDataPengguna_Click(object sender, EventArgs e)
        {
            frmData Pengguna = new frmData();
            Pengguna.Text = "Data Pengguna";
            Pengguna.ShowDialog();
        }

        private void menuInputPengguna_Click(object sender, EventArgs e)
        {
            frmPengguna pengguna = new frmPengguna();
            pengguna.ShowDialog();
        }

        private void menuLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin pengguna = new frmLogin();
            pengguna.txtIdKaryawan.Text = String.Empty;
            pengguna.txtPassword.Text = String.Empty;
            pengguna.Show();
        }

        private void menuUbahPassword_Click(object sender, EventArgs e)
        {
            frmUbahPassword pengguna = new frmUbahPassword();
            pengguna.txtIdKaryawan.Text = tstIdKaryawan.Text;
            pengguna.txtNamaKaryawan.Text = tstNamaKaryawan.Text;
            pengguna.ShowDialog();
        }

        private void menuKeluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi ini?", "Peringatan",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void menuDataKaryawan_Click(object sender, EventArgs e)
        {
            frmData karyawan = new frmData();
            karyawan.Text = "Data Karyawan";
            karyawan.ShowDialog();
        }

        private void menuInputKaryawan_Click(object sender, EventArgs e)
        {
            frmKaryawan karyawan = new frmKaryawan();
            karyawan.ShowDialog();
        }

        private void menuDataPelanggan_Click(object sender, EventArgs e)
        {
            frmData pelanggan = new frmData();
            pelanggan.Text = "Data Pelanggan";
            pelanggan.ShowDialog();
        }

        private void menuInputPelanggan_Click(object sender, EventArgs e)
        {
            frmPelanggan pelanggan = new frmPelanggan();
            pelanggan.ShowDialog();
        }

        private void menuDataTruk_Click(object sender, EventArgs e)
        {
            frmData truk = new frmData();
            truk.Text = "Data Truk";
            truk.ShowDialog();
        }

        private void menuInputTruk_Click(object sender, EventArgs e)
        {
            frmTruk truk = new frmTruk();
            truk.ShowDialog();
        }

        private void menuDataTujuan_Click(object sender, EventArgs e)
        {
            frmData tujuan = new frmData();
            tujuan.Text = "Data Tujuan";
            tujuan.ShowDialog();
        }

        private void menuInputTujuan_Click(object sender, EventArgs e)
        {
            frmTujuan tujuan = new frmTujuan();
            tujuan.ShowDialog();
        }

        private void menuTersedia_Click(object sender, EventArgs e)
        {
            string tanggal = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
            frmData tunggu = new frmData(tanggal);
            tunggu.Text = "Periksa Armada Tersedia";
            tunggu.dgvData.Location = new Point(9, 49);
            tunggu.dgvData.Size = new Size(827, 424);
            tunggu.lblCari.Enabled = tunggu.lblKeterangan.Enabled = tunggu.txtCari.Enabled =
                tunggu.btnCetak.Enabled = tunggu.btnHapus.Enabled = false;
            tunggu.ShowDialog();
        }

        private void menuInputTunggu_Click(object sender, EventArgs e)
        {
            frmDaftarTunggu tunggu = new frmDaftarTunggu();
            tunggu.ShowDialog();
        }

        private void menuDataPesan_Click(object sender, EventArgs e)
        {
            frmData pemesanan = new frmData();
            pemesanan.Text = "Data Pemesanan";
            pemesanan.ShowDialog();
        }

        private void menuInputPesan_Click(object sender, EventArgs e)
        {
            frmPemesanan pemesanan = new frmPemesanan(idKaryawan, namaKaryawan);
            pemesanan.ShowDialog();
        }

        private void menuHapusPesan_Click(object sender, EventArgs e)
        {
            frmData pemesanan = new frmData("2015-01-01");
            pemesanan.Text = "Hapus Data Pemesanan";
            pemesanan.dgvData.Location = new Point(9, 49);
            pemesanan.dgvData.Size = new Size(827, 424);
            pemesanan.lblCari.Enabled = pemesanan.lblKeterangan.Enabled = pemesanan.txtCari.Enabled = 
                pemesanan.btnCetak.Enabled = false;
            pemesanan.ShowDialog();
        }

        private void menuDataKirim_Click(object sender, EventArgs e)
        {
            frmData pengiriman = new frmData();
            pengiriman.Text = "Data Pengiriman";
            pengiriman.ShowDialog();
        }

        private void menuInputKirim_Click(object sender, EventArgs e)
        {
            frmPengiriman pengiriman = new frmPengiriman(idKaryawan, namaKaryawan);
            pengiriman.ShowDialog();
        }

        private void menuHapusKirim_Click(object sender, EventArgs e)
        {
            frmData pengiriman = new frmData("2015-01-01");
            pengiriman.Text = "Hapus Data Pengiriman";
            pengiriman.dgvData.Location = new Point(9, 49);
            pengiriman.dgvData.Size = new Size(827, 424);
            pengiriman.lblCari.Enabled = pengiriman.lblKeterangan.Enabled = pengiriman.txtCari.Enabled =
                pengiriman.btnCetak.Enabled = false;
            pengiriman.ShowDialog();
        }

        private void menuDataTransport_Click(object sender, EventArgs e)
        {
            frmData transport = new frmData();
            transport.Text = "Data Transport";
            transport.ShowDialog();
        }

        private void menuInputTransport_Click(object sender, EventArgs e)
        {
            frmTransport transport = new frmTransport(idKaryawan, namaKaryawan);
            transport.ShowDialog();
        }

        private void menuHapusTransport_Click(object sender, EventArgs e)
        {
            frmData transport = new frmData("2015-01-01");
            transport.Text = "Hapus Data Transport";
            transport.dgvData.Location = new Point(9, 49);
            transport.dgvData.Size = new Size(827, 424);
            transport.lblCari.Enabled = transport.lblKeterangan.Enabled = transport.txtCari.Enabled =
                transport.btnCetak.Enabled = false;
            transport.ShowDialog();
        }
    }
}
