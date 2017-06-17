using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using alvarotrans.form.kelas;
using alvarotrans.form.master;
using vm = alvarotrans.form.kelas.clsHimpunan;

namespace alvarotrans.form.record
{
    public partial class frmData : Form
    {
        #region Property frmData
        public string Agama { get; private set; }
        public string Alamat { get; private set; }
        public string KetereanganBiayaTambahan { get; private set; }
        public string BiayaTambahan { get; private set; }
        public string BPKB { get; private set; }
        public string DaerahTujuan { get; private set; }
        public string Email { get; private set; }
        public string Fax { get; private set; }
        public string Harga { get; private set; }
        public string HargaBiayaTambahan { get; private set; }
        public string IdSupir1 { get; private set; }
        public string IdSupir2 { get; private set; }
        public string IdKaryawan { get; private set; }
        public string IdKaryawanOperasional { get; private set; }
        public string IdPelanggan { get; private set; }
        public string Jabatan { get; private set; }
        public string JenisKelamin { get; private set; }
        public string JenisPesan { get; private set; }
        public string KodePenawaran { get; private set; }
        public string KodeTujuan { get; private set; }
        public string KotaTujuan { get; private set; }
        public string Komoditi { get; private set; }
        public string Merk { get; private set; }
        public string NamaSupir1 { get; private set; }
        public string NamaSupir2 { get; private set; }
        public string NamaKaryawan { get; private set; }
        public string NamaKaryawanOperasional { get; private set; }
        public string NamaPelanggan { get; private set; }
        public string NoDO { get; private set; }
        public string NoKir { get; private set; }
        public string NoKirim { get; private set; }
        public string NoMesin { get; private set; }
        public string NoPesan { get; private set; }
        public string NoPolisi { get; private set; }
        public string NoRangka { get; private set; }
        public string NoTransport { get; private set; }
        public string TahunBuat { get; private set; }
        public string Telepon { get; private set; }
        public string TempatLahir { get; private set; }
        public string TglAkhirPesan { get; private set; }
        public string TglAwalPesan { get; private set; }
        public string TglKirim { get; private set; }
        public string TglLahir { get; private set; }
        public string TglMulaiKerja { get; private set; }
        public string TglPesan { get; private set; }
        public string TglTransport { get; private set; }
        public string TipeTrailer { get; private set; }
        public string Transport { get; private set; }
        private string Parameter { get; set; }
        public string Password { get; private set; }
        public string Perusahaan { get; private set; }
        public string Pengangkut { get; private set; }
        public string Rekening { get; private set; }
        public string Kondisi { get; private set; }
        public string STNK { get; private set; }
        #endregion

        public frmData()
        {
            InitializeComponent();
        }

        public frmData(params string[] parameter)
        {
            InitializeComponent();

            Parameter = TglAwalPesan = TglAkhirPesan = String.Empty;

            if (parameter.Length == 1)
            {
                Parameter = parameter[0];
            }
            else
            {
                TglAwalPesan = parameter[0];
                TglAkhirPesan = parameter[1];
            }
        }

        private void CariRangeTanggal(string awal, string akhir)
        {
            try
            {
                vm.tabel = vm.proses.EksekusiQuery(QwerySql(awal, akhir));
                dgvData.DataSource = vm.tabel;
                KendaliTombol(vm.tabel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void KendaliTombol(DataTable jumlahBaris)
        {
            if (jumlahBaris.Rows.Count == 0)
            {
                switch (this.Text)
                {
                    case "Hapus Data Pemesanan":
                    case "Hapus Data Pengiriman":
                    case "Hapus Data Transport":
                        dgvData.DataSource = vm.tabel;
                        btnHapus.Enabled = false;
                        break;
                }
            }
            else
            {
                switch (this.Text)
                {
                    case "Hapus Data Pemesanan":
                    case "Hapus Data Pengiriman":
                    case "Hapus Data Transport":
                        dgvData.DataSource = vm.tabel;
                        btnHapus.Enabled = true;
                        break;
                }
            }
        }

        private string QwerySql(params string[] klausaTambahan)
        {
            switch (this.Text)
            {
                // tab Sistem.
                case "Data Pengguna":
                case "Data Pengguna - Pengguna Aplikasi":
                    vm.sql = "SELECT k.IdKaryawan, k.NamaKaryawan, k.Jabatan, p.Password " +
                        "FROM tblKaryawan k " +
                        "INNER JOIN tblPengguna p ON k.IdKaryawan = p.IdKaryawan " +
                        klausaTambahan[0];
                    break;

                // tab Master.
                // sub-tab Master: Karyawan
                case "Data Karyawan - Pengguna Aplikasi":
                    vm.sql = "SELECT k.IdKaryawan, k.NamaKaryawan, k.Jabatan " +
                        "FROM tblKaryawan k " +
                        "WHERE NOT EXISTS (SELECT p.* FROM tblPengguna p WHERE k.IdKaryawan = p.IdKaryawan) " +
                        klausaTambahan[0];
                    break;
                case "Data Karyawan":
                case "Data Karyawan - Karyawan":
                    vm.sql = "SELECT * FROM tblKaryawan " + klausaTambahan[0];
                    break;
                case "Data Karyawan - Supir 1":
                case "Data Karyawan - Supir 2":
                    vm.sql = "SELECT k.* FROM tblKaryawan k " +
                        "WHERE NOT EXISTS (SELECT t.* FROM tblTruk t WHERE k.IdKaryawan = t.IdSupir1 " +
                        "OR k.IdKaryawan = t.IdSupir2) AND k.Jabatan = 'Supir' " + klausaTambahan[0];
                    break;
                // sub-tab Master: Pelanggan
                case "Data Pelanggan":
                case "Data Pelanggan - Pelanggan":
                case "Data Pelanggan - Pemesanan":
                    vm.sql = "SELECT * FROM tblPelanggan " + klausaTambahan[0];
                    break;
                // sub-tab Master: Truk
                case "Data Truk":
                case "Data Truk - Truk":
                    vm.sql = "SELECT Kondisi, NoPolisi, Merk, TipeTrailer, TahunBuat, " +
                        "NoSTNK, NoKir, NoRangka, NoBPKB, NoMesin, IdSupir1, IdSupir2 " +
                        "FROM tblTruk " + klausaTambahan[0] + "ORDER BY TahunBuat DESC";
                    break;
                case "Data Truk - Daftar Tunggu":
                    vm.sql = "SELECT t.Kondisi, t.NoPolisi, t.Merk, t.TipeTrailer " +
                        "FROM tblTruk t INNER JOIN tblPesanRinci pr ON t.TipeTrailer = pr.TipeTrailer " +
                        klausaTambahan[0] + "UNION " +
                        "SELECT t.Kondisi, t.NoPolisi, t.Merk, t.TipeTrailer FROM tblTruk t " +
                        "INNER JOIN tblDaftarTunggu dt ON t.NoPolisi = dt.NoPolisi " +
                        "INNER JOIN tblPesanRinci pr ON dt.NoPesan = pr.NoPesan AND t.TipeTrailer = pr.TipeTrailer " +
                        "WHERE NOT EXISTS (SELECT * from tblPesanRinci pr " +
                        "WHERE pr.TglAwalPesan >= '" + klausaTambahan[1] + "' " +
                        "AND pr.TglAkhirPesan <= '" + klausaTambahan[2] + "') " + klausaTambahan[3];
                    break;
                // sub-tab Master: Tujuan
                case "Data Tujuan":
                case "Data Tujuan - Tujuan":
                case "Data Tujuan - Pemesanan":
                    vm.sql = "SELECT t.KodeTujuan, t.KotaTujuan, t.DaerahTujuan, " +
                        "h.TipeTrailer, h.Transport, h.Harga FROM tblTujuan t " +
                        "INNER JOIN tblHarga h ON t.KodeTujuan = h.KodeTujuan " + klausaTambahan[0] + 
                        "ORDER BY t.DaerahTujuan, h.TipeTrailer";
                    break;

                // tab Transaksi.
                // sub-tab Transaksi: Daftar Tunggu
                case "Periksa Armada Tersedia":
                    vm.sql = "SELECT t.Kondisi, t.NoPolisi, t.Merk, t.TipeTrailer " +
                        "FROM tblTruk t WHERE NOT EXISTS (SELECT * FROM tblDaftarTunggu dt WHERE t.NoPolisi = dt.NoPolisi) " +
                        "UNION SELECT t.Kondisi, t.NoPolisi, t.Merk, t.TipeTrailer " +
                        "FROM tblTruk t INNER JOIN tblDaftarTunggu dt ON t.NoPolisi = dt.NoPolisi " +
                        "INNER JOIN tblPesanRinci pr ON dt.NoPesan = pr.NoPesan " +
                        "WHERE NOT EXISTS (SELECT * from tblPesanRinci pr " +
                        "WHERE pr.TglAwalPesan >= '" + klausaTambahan[0] + "' " +
                        "AND pr.TglAkhirPesan <= '" + klausaTambahan[1] + "')";
                        break;
                case "Data Daftar Tunggu - Daftar Tunggu":
                    vm.sql = "SELECT dt.NoPesan, FORMAT(pr.TglAwalPesan, 'dd-MM-yyyy') TglAwalPesan, " +
                        "FORMAT(pr.TglAkhirPesan, 'dd-MM-yyyy') TglAkhirPesan, dt.NoPolisi, t.Merk, t.TipeTrailer " +
                        "FROM tblDaftarTunggu dt " +
                        "INNER JOIN tblPesanRinci pr ON dt.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblTruk t ON dt.NoPolisi = t.NoPolisi " + klausaTambahan[0] +
                        "ORDER BY dt.NoPesan";
                    break;
                // sub-tab Transaksi: Pemesanan
                case "Hapus Data Pemesanan":
                    vm.sql = "SELECT pr.Status, p.NoPesan, pr.JenisPesan, " +
                        "FORMAT(p.TglPesan, 'dd-MM-yyyy') TglPesan, pr.TglAwalPesan, pr.TglAkhirPesan, " +
                        "pr.KetereanganBiayaTambahan, pl.IdPelanggan, pl.NamaPelanggan, pl.Perusahaan, " +
                        "pl.Telepon, t.KodeTujuan, t.KotaTujuan, t.DaerahTujuan, pr.TipeTrailer, h.Transport, " +
                        "h.Harga, pr.AlamatBongkarMuat, pr.BiayaTambahan, k.IdKaryawan IdOperator, k.NamaKaryawan NamaOperator " +
                        "FROM tblPesan p " +
                        "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblPelanggan  pl ON p.IdPelanggan = pl.IdPelanggan " +
                        "INNER JOIN tblKaryawan k ON p.IdKaryawanOperator = k.IdKaryawan " +
                        "INNER JOIN tblTujuan t ON pr.KodeTujuan = t.KodeTujuan " +
                        "INNER JOIN tblHarga h ON t.KodeTujuan = h.KodeTujuan AND h.TipeTrailer = pr.TipeTrailer " +
                        "WHERE p.TglPesan >= '" + klausaTambahan[0] + "' " +
                        "AND p.TglPesan <= '" + klausaTambahan[1] + "' ORDER BY pr.Status, p.NoPesan";
                    break;
                case "Data Pemesanan - Daftar Tunggu":
                    vm.sql = "SELECT pr.Status, p.NoPesan, FORMAT(p.TglPesan, 'dd-MM-yyyy') TglPesan, " +
                        "FORMAT(pr.TglAwalPesan, 'dd-MM-yyyy') TglAwalPesan, FORMAT(pr.TglAkhirPesan, 'dd-MM-yyyy') TglAkhirPesan, " +
                        "pl.IdPelanggan, pl.NamaPelanggan, pl.Perusahaan, pl.Telepon, k.IdKaryawan IdOperator, k.NamaKaryawan NamaOperator " +
                        "FROM tblPesan p " +
                        "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblPelanggan pl ON p.IdPelanggan = pl.IdPelanggan " +
                        "INNER JOIN tblKaryawan k ON p.IdKaryawanOperator = k.IdKaryawan " +
                        "WHERE NOT EXISTS (SELECT kr.* FROM tblKirim kr WHERE kr.NoPesan = p.NoPesan) " +
                        "AND NOT EXISTS (SELECT dt.* FROM tblDaftarTunggu dt WHERE dt.NoPesan = p.NoPesan) " +
                        klausaTambahan[0] + "ORDER BY p.TglPesan, p.NoPesan";
                    break;
                case "Data Pemesanan":
                case "Data Pemesanan - Pemesanan":
                    vm.sql = "SELECT pr.Status, p.NoPesan, pr.JenisPesan, " +
                        "FORMAT(p.TglPesan, 'dd-MM-yyyy') TglPesan, pr.TglAwalPesan, pr.TglAkhirPesan, " +
                        "pr.KetereanganBiayaTambahan, pl.IdPelanggan, pl.NamaPelanggan, pl.Perusahaan, " +
                        "pl.Telepon, t.KodeTujuan, t.KotaTujuan, t.DaerahTujuan, pr.TipeTrailer, h.Transport, " +
                        "h.Harga, pr.AlamatBongkarMuat, pr.BiayaTambahan, k.IdKaryawan IdOperator, k.NamaKaryawan NamaOperator " +
                        "FROM tblPesan p " +
                        "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblPelanggan  pl ON p.IdPelanggan = pl.IdPelanggan " +
                        "INNER JOIN tblKaryawan k ON p.IdKaryawanOperator = k.IdKaryawan " +
                        "INNER JOIN tblTujuan t ON pr.KodeTujuan = t.KodeTujuan " +
                        "INNER JOIN tblHarga h ON t.KodeTujuan = h.KodeTujuan AND h.TipeTrailer = pr.TipeTrailer " +
                        klausaTambahan[0] + "ORDER BY pr.Status, p.NoPesan";
                    break;
                case "Data Pemesanan - Pengiriman":
                    vm.sql = "SELECT pr.Status, p.NoPesan, p.TglPesan, pl.IdPelanggan, " +
                        "pl.NamaPelanggan, pl.Perusahaan, pl.Telepon, k.IdKaryawan IdOperator, k.NamaKaryawan NamaOperator, " +
                        "t.NoPolisi, t.Merk, spr1.NamaKaryawan NamaSupir1, spr2.NamaKaryawan NamaSupir2 " +
                        "FROM tblPesan p " +
                        "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblPelanggan pl ON p.IdPelanggan = pl.IdPelanggan " +
                        "INNER JOIN tblKaryawan k ON p.IdKaryawanOperator = k.IdKaryawan " +
                        "INNER JOIN tblDaftarTunggu dt ON p.NoPesan = dt.NoPesan " +
                        "INNER JOIN tblTruk t ON dt.NoPolisi = t.NoPolisi " +
                        "INNER JOIN tblKaryawan spr1 ON t.IdSupir1 = spr1.IdKaryawan " +
                        "INNER JOIN tblKaryawan spr2 ON t.IdSupir2 = spr2.IdKaryawan " +
                        "WHERE NOT EXISTS (SELECT kr.* FROM tblKirim kr WHERE kr.NoPesan = p.NoPesan) " +
                        klausaTambahan[0] + "ORDER BY p.TglPesan, p.NoPesan";
                    break;
                // sub-tab Transaksi: Pengiriman
                case "Hapus Data Pengiriman":
                    vm.sql = "SELECT kr.Status, k.NoKirim, p.NoPesan, " +
                        "FORMAT(k.TglKirim, 'dd-MM-yyyy') TglKirim, pl.NamaPelanggan, pl.Perusahaan, " +
                        "pl.Telepon, kr.NoDO, kr.Pengangkut, kr.Komoditi, t.NoPolisi, t.Merk, " +
                        "spr1.NamaKaryawan NamaSupir1, spr2.NamaKaryawan NamaSupir2, " +
                        "kry.IdKaryawan IdOperasional, kry.NamaKaryawan NamaOperasional " +
                        "FROM tblKirim k " +
                        "INNER JOIN tblKirimRinci kr ON k.NoKirim = kr.NoKirim " +
                        "INNER JOIN tblPesan p ON k.NoPesan = p.NoPesan " +
                        "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblPelanggan pl ON p.IdPelanggan = pl.IdPelanggan " +
                        "INNER JOIN tblTruk t ON kr.NoPolisi = t.NoPolisi " +
                        "INNER JOIN tblKaryawan kry ON k.IdKaryawanOperasional = kry.IdKaryawan " +
                        "INNER JOIN tblKaryawan spr1 ON t.IdSupir1 = spr1.IdKaryawan " +
                        "INNER JOIN tblKaryawan spr2 ON t.IdSupir2 = spr2.IdKaryawan " +
                        "WHERE k.TglKirim >= '" + klausaTambahan[0] + "' " +
                        "AND k.TglKirim <= '" + klausaTambahan[1] + "' ORDER BY k.NoKirim, kr.Status";
                    break;
                case "Data Pengiriman":
                case "Data Pengiriman - Pengiriman":
                    vm.sql = "SELECT kr.Status, k.NoKirim, p.NoPesan, " +
                        "FORMAT(k.TglKirim, 'dd-MM-yyyy') TglKirim, pl.NamaPelanggan, pl.Perusahaan, " +
                        "pl.Telepon, kr.NoDO, kr.Pengangkut, kr.Komoditi, t.NoPolisi, t.Merk, " +
                        "spr1.NamaKaryawan NamaSupir1, spr2.NamaKaryawan NamaSupir2, " +
                        "kry.IdKaryawan IdOperasional, kry.NamaKaryawan NamaOperasional " +
                        "FROM tblKirim k " +
                        "INNER JOIN tblKirimRinci kr ON k.NoKirim = kr.NoKirim " +
                        "INNER JOIN tblPesan p ON k.NoPesan = p.NoPesan " +
                        "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblPelanggan pl ON p.IdPelanggan = pl.IdPelanggan " +
                        "INNER JOIN tblTruk t ON kr.NoPolisi = t.NoPolisi " +
                        "INNER JOIN tblKaryawan kry ON k.IdKaryawanOperasional = kry.IdKaryawan " +
                        "INNER JOIN tblKaryawan spr1 ON t.IdSupir1 = spr1.IdKaryawan " +
                        "INNER JOIN tblKaryawan spr2 ON t.IdSupir2 = spr2.IdKaryawan " +
                        klausaTambahan[0] + "ORDER BY k.NoKirim, kr.Status";
                    break;
                case "Data Pengiriman - Transport":
                    vm.sql = "SELECT kr.Status StatusKirim, k.NoKirim, pr.NoPesan, " +
                        "pr.Status StatusPesan, hr.Transport, DATEDIFF(day, pr.TglAwalPesan, pr.TglAkhirPesan) + 1 LamaPesan, " +
                        "(DATEDIFF(day, pr.TglAwalPesan, pr.TglAkhirPesan) + 1) * hr.Transport BiayaTransport, " +
                        "spr1.NamaKaryawan NamaSupir1, spr2.NamaKaryawan NamaSupir2, kry.IdKaryawan IdOperasional, " +
                        "kry.NamaKaryawan NamaOperasional " +
                        "FROM tblKirim k " +
                        "INNER JOIN tblKirimRinci kr ON k.NoKirim = kr.NoKirim " +
                        "INNER JOIN tblPesanRinci pr ON k.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblHarga hr ON pr.KodeTujuan = hr.KodeTujuan AND pr.TipeTrailer = hr.TipeTrailer " +
                        "INNER JOIN tblKaryawan kry ON k.IdKaryawanOperasional = kry.IdKaryawan " +
                        "INNER JOIN tblDaftarTunggu dt ON pr.NoPesan = dt.NoPesan " +
                        "INNER JOIN tblTruk t ON dt.NoPolisi = t.NoPolisi " +
                        "INNER JOIN tblKaryawan spr1 ON t.IdSupir1 = spr1.IdKaryawan " +
                        "INNER JOIN tblKaryawan spr2 ON t.IdSupir2 = spr2.IdKaryawan " +
                        "WHERE pr.Status = 'Proses Pengiriman' " +
                        "AND k.NoKirim NOT IN (SELECT NoKirim FROM tblTransport) " +
                        klausaTambahan[0] + "ORDER BY k.NoKirim, kr.Status";
                    break;
                // sub-tab Transaksi: Transport
                case "Hapus Data Transport":
                    vm.sql = "SELECT kr.Status StatusKirim, t.NoTransport, " +
                        "FORMAT(t.TglTransport, 'dd-MM-yyyy') TglTransport, " +
                        "k.NoKirim, h.Transport, DATEDIFF(day, pr.TglAwalPesan, pr.TglAkhirPesan) + 1 LamaPesan, " +
                        "(DATEDIFF(day, pr.TglAwalPesan, pr.TglAkhirPesan) + 1) * h.Transport BiayaTransport, " +
                        "spr1.NamaKaryawan NamaSupir1, spr2.NamaKaryawan NamaSupir2, " +
                        "kk.IdKaryawan IdKeuangan, kk.NamaKaryawan NamaKeuangan " +
                        "FROM tblTransport t " +
                        "INNER JOIN tblKirim k ON t.NoKirim = k.NoKirim " +
                        "INNER JOIN tblKirimRinci kr ON k.NoKirim = kr.NoKirim " +
                        "INNER JOIN tblPesan p ON k.NoPesan = p.NoPesan " +
                        "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblHarga h ON pr.KodeTujuan = h.KodeTujuan AND pr.TipeTrailer = h.TipeTrailer " +
                        "INNER JOIN tblDaftarTunggu dt ON p.NoPesan = dt.NoPesan " +
                        "INNER JOIN tblTruk tr ON dt.NoPolisi = tr.NoPolisi " +
                        "INNER JOIN tblKaryawan spr1 ON tr.IdSupir1 = spr1.IdKaryawan " +
                        "INNER JOIN tblKaryawan spr2 ON tr.IdSupir2 = spr2.IdKaryawan " +
                        "INNER JOIN tblKaryawan kk ON t.IdKaryawanKeuangan = kk.IdKaryawan " +
                        "WHERE t.TglTransport >= '" + klausaTambahan[0] + "' " +
                        "AND t.TglTransport <= '" + klausaTambahan[1] + "' ORDER BY t.TglTransport";
                    break;
                case "Data Transport":
                case "Data Transport - Transport":
                    vm.sql = "SELECT kr.Status StatusKirim, t.NoTransport, " +
                        "FORMAT(t.TglTransport, 'dd-MM-yyyy') TglTransport, " +
                        "k.NoKirim, h.Transport, DATEDIFF(day, pr.TglAwalPesan, pr.TglAkhirPesan) + 1 LamaPesan, " +
                        "(DATEDIFF(day, pr.TglAwalPesan, pr.TglAkhirPesan) + 1) * h.Transport BiayaTransport, " +
                        "spr1.NamaKaryawan NamaSupir1, spr2.NamaKaryawan NamaSupir2, " +
                        "kk.IdKaryawan IdKeuangan, kk.NamaKaryawan NamaKeuangan " +
                        "FROM tblTransport t " +
                        "INNER JOIN tblKirim k ON t.NoKirim = k.NoKirim " +
                        "INNER JOIN tblKirimRinci kr ON k.NoKirim = kr.NoKirim " +
                        "INNER JOIN tblPesan p ON k.NoPesan = p.NoPesan " +
                        "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                        "INNER JOIN tblHarga h ON pr.KodeTujuan = h.KodeTujuan AND pr.TipeTrailer = h.TipeTrailer " +
                        "INNER JOIN tblDaftarTunggu dt ON p.NoPesan = dt.NoPesan " +
                        "INNER JOIN tblTruk tr ON dt.NoPolisi = tr.NoPolisi " +
                        "INNER JOIN tblKaryawan spr1 ON tr.IdSupir1 = spr1.IdKaryawan " +
                        "INNER JOIN tblKaryawan spr2 ON tr.IdSupir2 = spr2.IdKaryawan " +
                        "INNER JOIN tblKaryawan kk ON t.IdKaryawanKeuangan = kk.IdKaryawan " +
                        klausaTambahan[0] + "ORDER BY t.TglTransport";
                    break;
            }
            return vm.sql;
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            try
            {
                if (TglAwalPesan == String.Empty && TglAkhirPesan == String.Empty)
                {
                    dtpAwal.Value = dtpAkhir.Value = Convert.ToDateTime(Parameter);
                }

                vm.tabel = vm.proses.EksekusiQuery(
                    QwerySql(String.Empty, TglAwalPesan, TglAkhirPesan, String.Empty));

                if (vm.tabel.Rows.Count == 0)
                {
                    txtCari.Focus();
                }
                dgvData.DataSource = vm.tabel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            #region lblKeterangan
            switch (this.Text)
            {
                // tab Sistem.
                case "Data Pengguna":
                case "Data Pengguna - Pengguna Aplikasi":

                // tab Master.
                // sub-tab Master: Karyawan
                case "Data Karyawan - Pengguna Aplikasi":
                case "Data Karyawan":
                case "Data Karyawan - Karyawan":
                case "Data Karyawan - Supir 1":
                case "Data Karyawan - Supir 2":
                    lblKeterangan.Text = "* Untuk melakukan pencarian, ketikkan nama karyawan yang dimaksud.";
                    break;
                // sub-tab Master: Pelanggan
                case "Data Pelanggan":
                case "Data Pelanggan - Pelanggan":
                case "Data Pelanggan - Pemesanan":
                    lblKeterangan.Text = "* Untuk melakukan pencarian, ketikkan nama pelanggan yang dimaksud.";
                    break;
                // sub-tab Master: Truk
                case "Data Truk":
                case "Data Truk - Truk":
                case "Data Truk - Daftar Tunggu":
                    lblKeterangan.Text = "* Untuk melakukan pencarian, ketikkan merk truk yang dimaksud.";
                    break;
                // sub-tab Master: Tujuan
                case "Data Tujuan":
                case "Data Tujuan - Tujuan":
                case "Data Tujuan - Pemesanan":
                    lblKeterangan.Text = "* Untuk melakukan pencarian, ketikkan daerah tujuan yang dimaksud.";
                    break;

                // tab Transaksi.
                // sub-tab Transaksi: Daftar Tunggu
                case "Data Daftar Tunggu - Daftar Tunggu":
                // sub-tab Transaksi: Pemesanan
                case "Data Pemesanan - Daftar Tunggu":
                case "Data Pemesanan":
                case "Data Pemesanan - Pemesanan":
                case "Data Pemesanan - Pengiriman":
                    lblKeterangan.Text = "* Untuk melakukan pencarian, ketikkan No. Pemesanan yang dimaksud.";
                    break;
                // sub-tab Transaksi: Pengiriman
                case "Data Pengiriman":
                case "Data Pengiriman - Pengiriman":
                case "Data Pengiriman - Transport":
                    lblKeterangan.Text = "* Untuk melakukan pencarian, ketikkan No. Pengiriman yang dimaksud.";
                    break;
                // sub-tab Transaksi: Transport
                case "Data Transport":
                case "Data Transport - Transport":
                    lblKeterangan.Text = "* Untuk melakukan pencarian, ketikkan No. Transport yang dimaksud.";
                    break;
            } 
            #endregion
        }

        private void dtpAwal_ValueChanged(object sender, EventArgs e)
        {
            TglAwalPesan = String.Format("{0:yyyy-MM-dd}", dtpAwal.Value);
            TglAkhirPesan = String.Format("{0:yyyy-MM-dd}", dtpAkhir.Value);
            CariRangeTanggal(TglAwalPesan, TglAkhirPesan);
        }

        private void dtpAkhir_ValueChanged(object sender, EventArgs e)
        {
            TglAwalPesan = String.Format("{0:yyyy-MM-dd}", dtpAwal.Value);
            TglAkhirPesan = String.Format("{0:yyyy-MM-dd}", dtpAkhir.Value);
            CariRangeTanggal(TglAwalPesan, TglAkhirPesan);
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.Text)
                {
                    case "Hapus Data Pemesanan":
                        vm.pesan = String.Format("Apakah anda akan melakukan penghapusan pada data pemesanan dari tanggal " +
                            "'{0:dd-MM-yyyy}' sampai tanggal '{1:dd-MM-yyyy}'?", dtpAwal.Value, dtpAkhir.Value);

                        if (vm.PesanPeringatan(vm.pesan, "Hapus data"))
                        {
                            vm.sql = "DELETE FROM tblPesan WHERE TglPesan >= '" + TglAwalPesan +
                                "' AND TglPesan <= '" + TglAkhirPesan + "'";
                            vm.proses.EksekusiNonQuery(vm.sql);

                            vm.pesan = String.Format("Data pemesanan dari tanggal '{0:dd-MM-yyyy}' sampai tanggal " +
                                "'{1:dd-MM-yyyy}' telah dihapus.", dtpAwal.Value, dtpAkhir.Value);
                            MessageBox.Show(vm.pesan, "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CariRangeTanggal(TglAwalPesan, TglAkhirPesan);
                        }
                        break;
                    case "Hapus Data Pengiriman":
                        vm.pesan = String.Format("Apakah anda akan melakukan penghapusan pada data pengiriman dari tanggal " +
                            "'{0:dd-MM-yyyy}' sampai tanggal '{1:dd-MM-yyyy}'?", dtpAwal.Value, dtpAkhir.Value);

                        if (vm.PesanPeringatan(vm.pesan, "Hapus data"))
                        {
                            vm.sql = "DELETE FROM tblKirim WHERE TglKirim >= '" + TglAwalPesan +
                                "' AND TglKirim <= '" + TglAkhirPesan + "'";
                            vm.proses.EksekusiNonQuery(vm.sql);

                            vm.pesan = String.Format("Data pengiriman dari tanggal '{0:dd-MM-yyyy}' sampai tanggal " +
                                "'{1:dd-MM-yyyy}' telah dihapus.", dtpAwal.Value, dtpAkhir.Value);
                            MessageBox.Show(vm.pesan, "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CariRangeTanggal(TglAwalPesan, TglAkhirPesan);
                        }
                        break;
                    case "Hapus Data Transport":
                        vm.pesan = String.Format("Apakah anda akan melakukan penghapusan pada data uang transport dari tanggal " +
                            "'{0:dd-MM-yyyy}' sampai tanggal '{1:dd-MM-yyyy}'?", dtpAwal.Value, dtpAkhir.Value);

                        if (vm.PesanPeringatan(vm.pesan, "Hapus data"))
                        {
                            vm.sql = "DELETE FROM tblTransport WHERE TglTransport >= '" + TglAwalPesan +
                                "' AND TglTransport <= '" + TglAkhirPesan + "'";
                            vm.proses.EksekusiNonQuery(vm.sql);

                            vm.pesan = String.Format("Data uang transport dari tanggal '{0:dd-MM-yyyy}' sampai tanggal " +
                                "'{1:dd-MM-yyyy}' telah dihapus.", dtpAwal.Value, dtpAkhir.Value);
                            MessageBox.Show(vm.pesan, "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CariRangeTanggal(TglAwalPesan, TglAkhirPesan);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (this.Text)
                {
                    // tab Sistem.
                    case "Data Pengguna - Pengguna Aplikasi":
                        IdKaryawan = dgvData.SelectedCells[0].Value.ToString();
                        NamaKaryawan = dgvData.SelectedCells[1].Value.ToString();
                        Jabatan = dgvData.SelectedCells[2].Value.ToString();
                        Password = dgvData.SelectedCells[3].Value.ToString();
                        break;

                    // tab Master.
                    // sub-tab Master: Karyawan
                    case "Data Karyawan - Pengguna Aplikasi":
                        IdKaryawan = dgvData.SelectedCells[0].Value.ToString();
                        NamaKaryawan = dgvData.SelectedCells[1].Value.ToString();
                        Jabatan = dgvData.SelectedCells[2].Value.ToString();
                        break;
                    case "Data Karyawan - Karyawan":
                        IdKaryawan = dgvData.SelectedCells[0].Value.ToString();
                        NamaKaryawan = dgvData.SelectedCells[1].Value.ToString();
                        TempatLahir = dgvData.SelectedCells[2].Value.ToString();
                        TglLahir = String.Format("{0:dd-MM-yyyy}", dgvData.SelectedCells[3].Value);
                        Agama = dgvData.SelectedCells[4].Value.ToString();
                        JenisKelamin = dgvData.SelectedCells[5].Value.ToString();
                        Alamat = dgvData.SelectedCells[6].Value.ToString();
                        Telepon = dgvData.SelectedCells[7].Value.ToString();
                        Email = dgvData.SelectedCells[8].Value.ToString();
                        Jabatan = dgvData.SelectedCells[9].Value.ToString();
                        Rekening = dgvData.SelectedCells[10].Value.ToString();
                        TglMulaiKerja = String.Format("{0:dd-MM-yyyy}", dgvData.SelectedCells[11].Value);
                        if (IdKaryawan == String.Empty)
                            goto default;
                            break;
                    case "Data Karyawan - Supir 1":
                        IdKaryawan = dgvData.SelectedCells[0].Value.ToString();
                        NamaKaryawan = dgvData.SelectedCells[1].Value.ToString();
                        break;
                    case "Data Karyawan - Supir 2":
                        IdKaryawan = dgvData.SelectedCells[0].Value.ToString();
                        NamaKaryawan = dgvData.SelectedCells[1].Value.ToString();
                        break;
                    // sub-tab Master: Pelanggan
                    case "Data Pelanggan - Pelanggan":
                        IdPelanggan = dgvData.SelectedCells[0].Value.ToString();
                        NamaPelanggan = dgvData.SelectedCells[1].Value.ToString();
                        Perusahaan = dgvData.SelectedCells[2].Value.ToString();
                        Alamat = dgvData.SelectedCells[3].Value.ToString();
                        Telepon = dgvData.SelectedCells[4].Value.ToString();
                        Email = dgvData.SelectedCells[5].Value.ToString();
                        Fax = dgvData.SelectedCells[6].Value.ToString();
                        break;
                    case "Data Pelanggan - Pemesanan":
                        IdPelanggan = dgvData.SelectedCells[0].Value.ToString();
                        NamaPelanggan = dgvData.SelectedCells[1].Value.ToString();
                        Perusahaan = dgvData.SelectedCells[2].Value.ToString();
                        Telepon = dgvData.SelectedCells[4].Value.ToString();
                        break;
                    // sub-tab Master: Truk
                    case "Data Truk - Truk":
                        NoPolisi = dgvData.SelectedCells[1].Value.ToString();
                        Merk = dgvData.SelectedCells[2].Value.ToString();
                        TipeTrailer = dgvData.SelectedCells[3].Value.ToString();
                        TahunBuat = dgvData.SelectedCells[4].Value.ToString();
                        STNK = dgvData.SelectedCells[5].Value.ToString();
                        NoKir = dgvData.SelectedCells[6].Value.ToString();
                        NoRangka = dgvData.SelectedCells[7].Value.ToString();
                        BPKB = dgvData.SelectedCells[8].Value.ToString();
                        NoMesin = dgvData.SelectedCells[9].Value.ToString();
                        IdSupir1 = dgvData.SelectedCells[10].Value.ToString();
                        IdSupir2 = dgvData.SelectedCells[11].Value.ToString();
                        Kondisi = dgvData.SelectedCells[0].Value.ToString();
                        break;
                    case "Data Truk - Daftar Tunggu":
                        NoPolisi = dgvData.SelectedCells[1].Value.ToString();
                        Merk = dgvData.SelectedCells[2].Value.ToString();
                        TipeTrailer = dgvData.SelectedCells[3].Value.ToString();
                        break;
                    // sub-tab Master: Tujuan
                    case "Data Tujuan - Tujuan":
                        KodeTujuan = dgvData.SelectedCells[0].Value.ToString();
                        KotaTujuan = dgvData.SelectedCells[1].Value.ToString();
                        DaerahTujuan = dgvData.SelectedCells[2].Value.ToString();
                        break;
                    case "Data Tujuan - Pemesanan":
                        KodeTujuan = dgvData.SelectedCells[0].Value.ToString();
                        KotaTujuan = dgvData.SelectedCells[1].Value.ToString();
                        DaerahTujuan = dgvData.SelectedCells[2].Value.ToString();
                        TipeTrailer = dgvData.SelectedCells[3].Value.ToString();
                        Transport = dgvData.SelectedCells[4].Value.ToString();
                        Harga = KotaTujuan = dgvData.SelectedCells[5].Value.ToString();
                        break;

                    // tab Transaksi.
                    // sub-tab Transaksi: Daftar Tunggu
                    case "Data Daftar Tunggu - Daftar Tunggu":
                        NoPesan = dgvData.SelectedCells[0].Value.ToString();
                        TglAwalPesan = dgvData.SelectedCells[1].Value.ToString();
                        TglAkhirPesan = dgvData.SelectedCells[2].Value.ToString();
                        NoPolisi = dgvData.SelectedCells[3].Value.ToString();
                        Merk = dgvData.SelectedCells[4].Value.ToString();
                        TipeTrailer = dgvData.SelectedCells[5].Value.ToString();
                        break;
                    // sub-tab Transaksi: Pemesanan
                    case "Data Pemesanan - Daftar Tunggu":
                        NoPesan = dgvData.SelectedCells[1].Value.ToString();
                        TglAwalPesan = dgvData.SelectedCells[3].Value.ToString();
                        TglAkhirPesan = dgvData.SelectedCells[4].Value.ToString();
                        break;
                    case "Data Pemesanan - Pemesanan":
                        IdKaryawan = dgvData.SelectedCells[19].Value.ToString();
                        NamaKaryawan = dgvData.SelectedCells[20].Value.ToString();
                        NoPesan = dgvData.SelectedCells[1].Value.ToString();
                        JenisPesan = dgvData.SelectedCells[2].Value.ToString();
                        TglPesan = dgvData.SelectedCells[3].Value.ToString();
                        TglAwalPesan = String.Format("{0:dd-MM-yyyy}", dgvData.SelectedCells[4].Value);
                        TglAkhirPesan = String.Format("{0:dd-MM-yyyy}", dgvData.SelectedCells[5].Value);
                        KetereanganBiayaTambahan = dgvData.SelectedCells[6].Value.ToString();
                        IdPelanggan = dgvData.SelectedCells[7].Value.ToString();
                        NamaPelanggan = dgvData.SelectedCells[8].Value.ToString();
                        Perusahaan = dgvData.SelectedCells[9].Value.ToString();
                        Telepon = dgvData.SelectedCells[10].Value.ToString();
                        KodeTujuan = dgvData.SelectedCells[11].Value.ToString();
                        KotaTujuan = dgvData.SelectedCells[12].Value.ToString();
                        DaerahTujuan = dgvData.SelectedCells[13].Value.ToString();
                        TipeTrailer = dgvData.SelectedCells[14].Value.ToString();
                        Transport = dgvData.SelectedCells[15].Value.ToString();
                        Harga = dgvData.SelectedCells[16].Value.ToString();
                        Alamat = dgvData.SelectedCells[17].Value.ToString();
                        BiayaTambahan = dgvData.SelectedCells[18].Value.ToString();
                        if (NoPesan == String.Empty)
                            goto default;
                            break;
                    case "Data Pemesanan - Pengiriman":
                        NoPesan = dgvData.SelectedCells[1].Value.ToString();
                        NamaPelanggan = dgvData.SelectedCells[4].Value.ToString();
                        Perusahaan = dgvData.SelectedCells[5].Value.ToString();
                        Telepon = dgvData.SelectedCells[6].Value.ToString();
                        NoPolisi = dgvData.SelectedCells[9].Value.ToString();
                        Merk = dgvData.SelectedCells[10].Value.ToString();
                        NamaSupir1 = dgvData.SelectedCells[11].Value.ToString();
                        NamaSupir2 = dgvData.SelectedCells[12].Value.ToString();
                        if (NoPesan == String.Empty)
                            goto default;
                            break;
                    // sub-tab Transaksi: Pengiriman
                    case "Data Pengiriman - Pengiriman":
                        IdKaryawan = dgvData.SelectedCells[14].Value.ToString();
                        NamaKaryawan = dgvData.SelectedCells[15].Value.ToString();
                        NoKirim = dgvData.SelectedCells[1].Value.ToString();
                        TglKirim = dgvData.SelectedCells[3].Value.ToString();
                        NoPesan = dgvData.SelectedCells[2].Value.ToString();
                        NamaPelanggan = dgvData.SelectedCells[4].Value.ToString();
                        Perusahaan = dgvData.SelectedCells[5].Value.ToString();
                        Telepon = dgvData.SelectedCells[6].Value.ToString();
                        NoDO = dgvData.SelectedCells[7].Value.ToString();
                        Pengangkut = dgvData.SelectedCells[8].Value.ToString();
                        Komoditi = dgvData.SelectedCells[9].Value.ToString();
                        NoPolisi = dgvData.SelectedCells[10].Value.ToString();
                        Merk = dgvData.SelectedCells[11].Value.ToString();
                        NamaSupir1 = dgvData.SelectedCells[12].Value.ToString();
                        NamaSupir2 = dgvData.SelectedCells[13].Value.ToString();
                        break;
                    case "Data Pengiriman - Transport":
                        NoKirim = dgvData.SelectedCells[1].Value.ToString();
                        NamaSupir1 = dgvData.SelectedCells[7].Value.ToString();
                        NamaSupir2 = dgvData.SelectedCells[8].Value.ToString();
                        Transport = dgvData.SelectedCells[6].Value.ToString();
                        break;
                    // sub-tab Transaksi: Transport
                    case "Data Transport - Transport":
                        NoTransport = dgvData.SelectedCells[1].Value.ToString();
                        TglTransport = dgvData.SelectedCells[2].Value.ToString();
                        IdKaryawan = dgvData.SelectedCells[9].Value.ToString();
                        NamaKaryawan = dgvData.SelectedCells[3].Value.ToString();
                        NoKirim = dgvData.SelectedCells[10].Value.ToString();
                        NamaSupir1 = dgvData.SelectedCells[7].Value.ToString();
                        NamaSupir2 = dgvData.SelectedCells[8].Value.ToString();
                        Transport = dgvData.SelectedCells[6].Value.ToString();
                        break;
                    default:
                        return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (this.Text)
                {
                    // tab Sistem.
                    case "Data Pengguna":
                    case "Data Pengguna - Pengguna Aplikasi":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE k.NamaKaryawan LIKE '%" + txtCari.Text + "%'"));
                        break;

                    // tab Master.
                    // sub-tab Master: Karyawan
                    case "Data Karyawan - Pengguna Aplikasi":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("AND k.NamaKaryawan LIKE '%" + txtCari.Text + "%'"));
                        break;
                    case "Data Karyawan":
                    case "Data Karyawan - Karyawan":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE NamaKaryawan LIKE '%" + txtCari.Text + "%'"));
                        break;
                    case "Data Karyawan - Supir 1":
                    case "Data Karyawan - Supir 2":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("AND k.NamaKaryawan LIKE '%" + txtCari.Text + "%'"));
                        break;
                    // sub-tab Master: Pelanggan
                    case "Data Pelanggan":
                    case "Data Pelanggan - Pelanggan":
                    case "Data Pelanggan - Pemesanan":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE NamaPelanggan LIKE '%" + txtCari.Text + "%'"));
                        break;
                    // sub-tab Master: Truk
                    case "Data Truk":
                    case "Data Truk - Truk":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE Merk LIKE '%" + txtCari.Text + "%' "));
                        break;
                    case "Data Truk - Daftar Tunggu":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE t.Merk LIKE '%" + txtCari.Text + "%' ", String.Empty, String.Empty,
                            "AND t.Merk LIKE '%"  + txtCari.Text + "%'"));
                        break;
                    // sub-tab Master: Tujuan
                    case "Data Tujuan":
                    case "Data Tujuan - Tujuan":
                    case "Data Tujuan - Pemesanan":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE t.DaerahTujuan LIKE '%" + txtCari.Text + "%' "));
                        break;

                    // tab Transaksi.
                    // sub-tab Transaksi: Daftar Tunggu
                    case "Data Daftar Tunggu - Daftar Tunggu":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE dt.NoPesan LIKE '%" + txtCari.Text + "%' "));
                        break;
                    // sub-tab Transaksi: Pemesanan
                    case "Data Pemesanan - Daftar Tunggu":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("AND p.NoPesan LIKE '%" + txtCari.Text + "%' "));
                        break;
                    case "Data Pemesanan":
                    case "Data Pemesanan - Pemesanan":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE p.NoPesan LIKE '%" + txtCari.Text + "%' "));
                        break;
                    case "Data Pemesanan - Pengiriman":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("AND p.NoPesan LIKE '%" + txtCari.Text + "%' "));
                        break;
                    // sub-tab Transaksi: Pengiriman
                    case "Data Pengiriman":
                    case "Data Pengiriman - Pengiriman":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE k.NoKirim LIKE '%" + txtCari.Text + "%' "));
                        break;
                    case "Data Pengiriman - Transport":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("AND k.NoKirim LIKE '%" + txtCari.Text + "' "));
                        break;
                    // sub-tab Transaksi: Transport
                    case "Data Transport":
                    case "Data Transport - Transport":
                        vm.tabel = vm.proses.EksekusiQuery(
                            QwerySql("WHERE t.NoTransport LIKE '%" + txtCari.Text + "%' "));
                        break;
                }

                if (vm.tabel.Rows.Count == 0)
                {
                    txtCari.Focus();
                }
                dgvData.DataSource = vm.tabel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}