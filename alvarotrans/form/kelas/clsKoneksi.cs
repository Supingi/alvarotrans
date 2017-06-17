using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using System.IO;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;
using alvarotrans.form.penunjang;
using Microsoft.Reporting.WinForms;

namespace alvarotrans.form.kelas
{
    class clsKoneksi
    {
        OleDbConnection Koneksi;
        OleDbCommand Perintah;
        OleDbDataAdapter dataAdapter;
        DataSet dataSet;
        DataTable dataTabel;

        public DataTable EksekusiQuery(string query)
        {
            Koneksi = new OleDbConnection("Provider=SQLOLEDB; Data Source=SUPINGI-PC;" +
                "Persist Security Info=False;Trusted_Connection=yes;" +
                "Initial Catalog=alvarotrans_db;User ID=SUPINGI-PC\\Achmad;Password=sa;");
            try
            {
                Koneksi.Open();
                Perintah = new OleDbCommand(query, Koneksi);
                dataAdapter = new OleDbDataAdapter();
                dataAdapter.SelectCommand = Perintah;

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataTabel = dataSet.Tables[0];
                Koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataTabel;
        }

        public void EksekusiNonQuery(string query)
        {
            Koneksi = new OleDbConnection("Provider=SQLOLEDB; Data Source=SUPINGI-PC;" +
                "Persist Security Info=False;Trusted_Connection=yes;" +
                "Initial Catalog=alvarotrans_db;User ID=SUPINGI-PC\\Achmad;Password=sa;");
            try
            {
                Koneksi.Open();
                Perintah = new OleDbCommand();
                Perintah.Connection = Koneksi;
                Perintah.CommandType = CommandType.Text;
                Perintah.CommandText = query;
                Perintah.ExecuteNonQuery();
                Koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}