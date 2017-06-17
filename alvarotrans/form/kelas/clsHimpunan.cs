using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Data.OleDb;
using alvarotrans.form.kelas;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using System.Collections;
using System.Diagnostics;

using alvarotrans;
using dt = System.DateTime;

namespace alvarotrans.form.kelas
{
    class clsHimpunan
    {
        public static string sql, pesan;
        public static bool status, tidakTerisi;
        public static DataTable tabel;
        public static clsKoneksi proses = new clsKoneksi();
        
        public static bool ApakahKosong(Control ctrl, string namaCtrl)
        {
            bool nilai;
            if (String.IsNullOrWhiteSpace(ctrl.Text) || String.IsNullOrEmpty(ctrl.Text))
            {
                nilai = true;
                MessageBox.Show("Proses simpan data gagal. Data dalam kolom '" +
                    namaCtrl + "' tidak boleh kosong. Silahkan periksa kembali!", "Simpan data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ctrl.Focus();
            }
            else
            {
                nilai = false;
            }
            return nilai;
        }

        public static string Enkripsi(string plainText)
        {
            string enkripsiKarakter = null,
                chipherText = null,
                teksAsli = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890?!@#$%^&*()_+|;:,'\"\\/.-`~",
                teksSandi = "?!@#$%^&*()_+|;:,'\"\\/.-`~1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            int posisi, panjangTeks;

            for (panjangTeks = 0; panjangTeks < plainText.Length; panjangTeks++)
            {
                posisi = teksAsli.IndexOf(plainText.Substring(panjangTeks, 1), 1);

                if (posisi > 0)
                {
                    enkripsiKarakter = teksSandi.Substring(posisi, 1);
                    chipherText += enkripsiKarakter;
                }
                else
                {
                    chipherText += teksSandi.Substring(0, 1);
                }
            }
            return chipherText;
        }

        /*
         * Method untuk nonaktif tombol delete di combobox.
         * Method ini dapat mencegah semua input yang dilakukan oleh user karena penggunaan Properti. KeyPressEventArgs.Handled.
         */
        public static void InputNonAktif(KeyEventArgs e)
        {
            e.Handled = true;
        }
        /*
         * Method untuk nonaktifkan semua karakter yang diinput oleh user di combobox dan textbox(kecuali angka).
         * Method ini dapat mencegah semua input yang dilakukan oleh user karena penggunaan Properti. KeyPressEventArgs.KeyChar
         * kecuali beberapa tombol seperti pada link berikut: https://msdn.microsoft.com/en-us/library/s4cys3z6(v=vs.110).aspx
         */
        public static void InputNonAktif(object obj, KeyPressEventArgs e)
        {
            if (obj is ComboBox ||
                (obj is TextBox && !Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        public static string KodeOtomatis(string pilihField, string tabelX, string fieldY)
        {
            string nilai;
            tabel = proses.EksekusiQuery(
                "SELECT " + pilihField + " FROM " + tabelX + " ORDER BY " + fieldY + " DESC");

            if (tabel.Rows.Count == 0)
            {
                nilai = String.Format("{0:yyMM}-001", dt.Now).ToUpper();
            }
            else
            {
                nilai = tabel.Rows[0][0].ToString();
                string s = nilai.Substring(5, 2);

                if (s != String.Format("{0:MM}", dt.Now))
                {
                    nilai = String.Format("{0:yyMM}-001", dt.Now).ToUpper();
                }
                else
                {
                    int i = Convert.ToInt32(nilai.Substring(nilai.Length - 3)) + 1;
                    nilai = String.Format("{0:yyMM}-{1:000}", dt.Now, i).ToUpper();
                }
            }
            return nilai;
        }

        public static void KosongkanIsiText(Form x)
        {
            foreach (Control i in x.Controls)
            {
                if (i is TextBox)
                {
                    i.Text = String.Empty;
                    i.Focus();
                }
                else if (i is ComboBox)
                {
                    i.Text = String.Empty;
                }
            }
        }

        public static void KosongkanIsiText(GroupBox x)
        {
            foreach (Control i in x.Controls)
            {
                if (i is TextBox)
                {
                    i.Text = String.Empty;
                    i.Focus();
                }
                else if (i is ComboBox)
                {
                    i.Text = String.Empty;
                }
            }
        }

        public static bool PesanPeringatan(string isiPesan, string judulPesan)
        {
            bool nilai;
            if (MessageBox.Show(isiPesan, judulPesan, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nilai = true;
            }
            else
            {
                MessageBox.Show("Proses " + judulPesan.ToLower() + " dibatalkan.", 
                    judulPesan, MessageBoxButtons.OK, MessageBoxIcon.Information);
                nilai = false;
            }
            return nilai;
        }
    }
}
