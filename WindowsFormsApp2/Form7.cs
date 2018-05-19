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
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace WindowsFormsApp2
{
    public partial class Form7 : MaterialSkin.Controls.MaterialForm
    {
        public Form7()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        public string getIme()
        {
            return txtImeProizvoda.Text.Trim();
        }
        public void putIme(string Ime)
        {

            txtImeProizvoda.Text = Ime.Trim();

        }

        public string getCjena()
        {
            return txtCjenaProizvoda.Text.Trim();
        }
        public void putCjena(string Cjena)
        {

            txtCjenaProizvoda.Text = Cjena.Trim();

        }
        public string getOpis()
        {
            return txtbOpisProizvoda.Text.Trim();
        }
        public void putOpis(string Cjena)
        {

           txtbOpisProizvoda.Text = Cjena.Trim();

        }
    }
}
