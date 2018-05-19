using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace WindowsFormsApp2
{
    public partial class Form4 : MaterialSkin.Controls.MaterialForm
    {
        public Form4()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        public string getIme()
        {
            return txtIme.Text.Trim();
        }
        public void putIme(string Ime)
        {

            txtIme.Text = Ime.Trim();

        }

        public string getCjena()
        {
            return txtCjena.Text.Trim();
        }
        public void putCjena(string Cjena)
        {

            txtCjena.Text = Cjena.Trim();

        }
    }
}
