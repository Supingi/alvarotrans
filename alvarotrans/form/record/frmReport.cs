using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;
using vm = alvarotrans.form.kelas.clsHimpunan;

namespace alvarotrans.form.record
{
    public partial class frmReport : Form
    {
        private string Parameter { get; set; }

        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(string parameter)
        {
            InitializeComponent();
            Parameter = parameter;
        }

        string dir;

        private void ReportViewer(string direktori, string namaDataSet, DataTable dTabel)
        {
            // namaDataSet Harus sesuai dengan DataSet Property > DataSet Name saat membuat DataTable
            ReportDataSource rdsc = new ReportDataSource(namaDataSet, dTabel);
            rvwLaporan.Reset();
            rvwLaporan.LocalReport.ReportPath = direktori;
            rvwLaporan.LocalReport.DataSources.Clear();
            rvwLaporan.LocalReport.DataSources.Add(rdsc);
            rvwLaporan.RefreshReport();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                switch (this.Text)
                {
                    case "Pedoman Harga":
                        dir = @"E:\workspace\c_sharp\portofolio_c\alvarotrans\alvarotrans\form\record\rptHarga.rdlc";
                        vm.tabel = vm.proses.EksekusiQuery("SELECT t.KotaTujuan, t.DaerahTujuan, tt.TipeTrailer, h.Harga " +
                            "FROM tblTujuan t INNER JOIN tblHarga h ON t.KodeTujuan = h.KodeTujuan " +
                            "INNER JOIN tblTipeTrailer tt ON h.TipeTrailer = tt.TipeTrailer ORDER BY t.DaerahTujuan");
                        ReportViewer(dir, "Pedoman_Harga", vm.tabel);
                        break;
                    case "Konfirmasi Pemesanan":
                        dir = @"E:\workspace\c_sharp\portofolio_c\alvarotrans\alvarotrans\form\record\rptPemesanan.rdlc";
                        vm.tabel = vm.proses.EksekusiQuery("SELECT p.NoPesan, FORMAT(p.TglPesan, 'dd MMMM yyyy') TglPesan, " +
                            "FORMAT(pr.TglAwalPesan, 'dd MMMM yyyy') TglAwalPesan, FORMAT(pr.TglAkhirPesan, 'dd MMMM yyyy') TglAkhirPesan, " +
                            "DATEDIFF(day, pr.TglAwalPesan, pr.TglAkhirPesan) + 1 LamaPesan, pr.JenisPesan, t.KodeTujuan, h.TipeTrailer, pl.NamaPelanggan, pl.Perusahaan, pl.Alamat, pr.AlamatBongkarMuat, h.Harga, " +
                            "pr.KetereanganBiayaTambahan, pr.BiayaTambahan FROM tblPesan p " +
                            "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                            "INNER JOIN tblPelanggan pl ON p.IdPelanggan = pl.IdPelanggan " +
                            "INNER JOIN tblTujuan t ON pr.KodeTujuan = t.KodeTujuan " +
                            "INNER JOIN tblHarga h ON t.KodeTujuan = h.KodeTujuan AND pr.TipeTrailer = h.TipeTrailer " +
                            "WHERE p.NoPesan = '" + Parameter + "'");
                        ReportViewer(dir, "Konfirmasi_Pemesanan", vm.tabel);
                        break;
                    case "Form Pengiriman Barang":
                        dir = @"E:\workspace\c_sharp\portofolio_c\alvarotrans\alvarotrans\form\record\rptPengiriman.rdlc";
                        vm.tabel = vm.proses.EksekusiQuery("SELECT k.NoKirim, p.NoPesan, pl.NamaPelanggan, pl.Perusahaan, " +
                            "pl.Alamat, pl.Telepon, kr.NoDO, kr.Pengangkut, kr.Komoditi, pr.AlamatBongkarMuat, " +
                            "kry.IdKaryawan, kry.NamaKaryawan BagOperasional, spr1.NamaKaryawan Supir1, spr2.NamaKaryawan Supir2 " +
                            "FROM tblKirim k " +
                            "INNER JOIN tblKirimRinci kr ON k.NoKirim = kr.NoKirim " +
                            "INNER JOIN tblPesan p ON k.NoPesan = p.NoPesan " +
                            "INNER JOIN tblPesanRinci pr ON p.NoPesan = pr.NoPesan " +
                            "INNER JOIN tblPelanggan pl ON p.IdPelanggan = pl.IdPelanggan " +
                            "INNER JOIN tblKaryawan kry ON k.IdKaryawanOperasional = kry.IdKaryawan " +
                            "INNER JOIN tblTruk tr ON kr.NoPolisi = tr.NoPolisi " +
                            "INNER JOIN tblKaryawan spr1 ON tr.IdSupir1 = spr1.IdKaryawan " +
                            "INNER JOIN tblKaryawan spr2 ON tr.IdSupir2 = spr2.IdKaryawan " +
                            "WHERE k.NoKirim = '" + Parameter + "'");
                        ReportViewer(dir, "Pengiriman_Barang", vm.tabel);
                        break;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
