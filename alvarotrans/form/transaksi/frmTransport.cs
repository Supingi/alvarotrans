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

namespace alvarotrans.form.transaksi
{
    public partial class frmTransport : Form
    {
        private string idKaryawanAdministrasi { get; set; }
        private string namaKaryawanAdministrasi { get; set; }
        public frmTransport()
        {
            InitializeComponent();
        }

        public frmTransport(string id, string nama)
        {
            InitializeComponent();
            idKaryawanAdministrasi = id;
            namaKaryawanAdministrasi = nama;
        }

        private void KosongkanIsiTeks()
        {
            vm.KosongkanIsiText(gbxTransport);
            vm.KosongkanIsiText(gbxPengiriman);
        }

        private void Pengaturan()
        {

            switch (vm.status)
            {
                case true:
                    tsbSimpan.Enabled = true;
                    tsbBatal.Enabled = false;
                    tsbCetak.Enabled = false;

                    KosongkanIsiTeks();
                    txtNoTransport.Text = "TRS" + vm.KodeOtomatis("NoTransport", "tblTransport", "NoTransport"); 
                    txtTglTransport.Text = String.Format("{0:dd-MM-yyyy}", DateTime.Now);
                    txtIdKaryawanKeuangan.Text = idKaryawanAdministrasi;
                    txtNamaKaryawanKeuangan.Text = namaKaryawanAdministrasi;
                    btnNoKirim.Enabled = true;
                    break;
                case false:
                    tsbSimpan.Enabled = false;
                    tsbBatal.Enabled = true;
                    tsbCetak.Enabled = true;
                    btnNoKirim.Enabled = false;
                    break;
            }
        }

        private bool TidakTerisi()
        {
            if (vm.ApakahKosong(txtNoKirim, "No. Pengiriman"))
            {
                vm.tidakTerisi = true;
            }
            else
            {
                vm.tidakTerisi = false;
            }
            return vm.tidakTerisi;
        }

        private void frmTransport_Load(object sender, EventArgs e)
        {
            vm.status = true;
            Pengaturan();
        }

        private void btnNoKirim_Click(object sender, EventArgs e)
        {
            frmData pengiriman = new frmData(txtNoTransport.Text);
            pengiriman.Text = "Data Pengiriman - Transport";
            if (pengiriman.ShowDialog() == DialogResult.OK)
            {
                txtNoKirim.Text = pengiriman.NoKirim;
                txtNamaSupir1.Text = pengiriman.NamaSupir1;
                txtNamaSupir2.Text = pengiriman.NamaSupir2;
                txtTrasport.Text = pengiriman.Transport;
            }
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TidakTerisi() != true)
                {
                    vm.sql = "INSERT INTO tblTransport VALUES ('" + txtNoTransport.Text +
                        "','" + String.Format("{0:yyyy-MM-dd}", DateTime.Now) +
                        "','" + txtNoKirim.Text +
                        "','" + txtIdKaryawanKeuangan.Text + "')";
                    vm.proses.EksekusiNonQuery(vm.sql);

                    vm.pesan = "Data transport dengan No. Transport: '" + txtNoTransport.Text + "' telah tersimpan.";
                    MessageBox.Show(vm.pesan, "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pengaturan();
                }
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
            frmData transport = new frmData();
            transport.Text = "Data Transport - Transport";
            if (transport.ShowDialog() == DialogResult.OK)
            {
                txtNoTransport.Text = transport.NoTransport;
                txtTglTransport.Text = transport.TglTransport;
                txtIdKaryawanKeuangan.Text = transport.IdKaryawan;
                txtNamaKaryawanKeuangan.Text = transport.NamaKaryawan;
                txtNoKirim.Text = transport.NoKirim;
                txtNamaSupir1.Text = transport.NamaSupir1;
                txtNamaSupir2.Text = transport.NamaSupir2;
                txtTrasport.Text = transport.Transport;

                vm.status = false;
                Pengaturan();
            }
        }

        private void tsbCetak_Click(object sender, EventArgs e)
        {

        }

        private void tsbTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
