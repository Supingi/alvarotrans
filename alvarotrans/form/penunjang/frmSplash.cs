using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using alvarotrans.form.penunjang;

namespace alvarotrans
{
    public partial class frmSplash : Form
    {
        #region Assembly Attribute Accessors
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        #endregion

        public frmSplash()
        {
            InitializeComponent();
            this.lblVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.lblCopyright.Text = AssemblyCopyright + "      Made By : " + AssemblyProduct;
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Timer.Interval = 50;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            this.Opacity = this.Opacity - 0.01;
            ProgressBar.Value = ProgressBar.Value + 2;

            switch (this.ProgressBar.Value)
            {
                case 10:
                    lblSystem.Text = "Mencari modul...";
                    break;
                case 20:
                    lblSystem.Text = "Mendapatkan modul...";
                    break;
                case 40:
                    lblSystem.Text = "Menyalakan modul...";
                    break;
                case 60:
                    lblSystem.Text = "Loading modul...";
                    break;
                case 80:
                    lblSystem.Text = "Loading modul selesai...";
                    break;
                case 100:
                    Timer.Enabled = false;
                    fl.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
