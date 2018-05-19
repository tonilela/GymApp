﻿using System;
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
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public string getImePrezime()
        {
            return txtImePrezime.Text.Trim();
        }
        public string getAdresu()
        {
            return txtAdresa.Text.Trim();
        }
        public string getMobitel()
        {
            return txtMobitel.Text.Trim();
        }
        public int getComboClanarina1()
        {
            return 1 + (cmbClanarine.SelectedIndex);
        }
        public string getComboClanarina()
        {
            return cmbClanarine.Text.Trim();
        }
        public void putImePrezime(string ImePrezime)
        {

            txtImePrezime.Text = ImePrezime.Trim();

        }
        public void putAdresu(string Adresa)
        {

            txtAdresa.Text = Adresa.Trim();

        }
        public void putMobitel(string Mobitel)
        {

            txtMobitel.Text = Mobitel.Trim();

        }
        public void putDatum(string datum)
        {

            labelDatumUpisa.Text = datum.Trim();

        }
        public string getBrojDana() {

            return labelPreostalodana.Text;
        }
        public void putPreostaloDana(DateTime datumUpisa)
        {
            DateTime danas = DateTime.Now;
            DateTime kraj = datumUpisa.AddDays(30);
          string Preostalo= (kraj - danas).TotalDays.ToString();
            if (Preostalo[0] == '-')
            {
                labelPreostalodana.Text = "Članarina istekla";

            }
            else {
                decimal d= decimal.Parse(Preostalo);
                int i = decimal.ToInt32(d);
                labelPreostalodana.Text = i.ToString();
            }
        }
        public void Combo1() {
            cmbClanarine.Items.Clear();
            TeretanaEntities novi = new TeretanaEntities();
            var Sve_clanarine = novi.Clanarine.ToList();
          
                cmbClanarine.DataSource = Sve_clanarine;
                cmbClanarine.DisplayMember = "Ime_clanarine";
                cmbClanarine.ValueMember = "Id";
            


        }
        public void putComboClanarine(int clanarina) {

            cmbClanarine.SelectedIndex = clanarina-1;
        }

        public void btnProduzi_Click(object sender, EventArgs e)
        {
            KorisnikProduziPrintPreviewDialog.Document = KorisnikProduziPrintDocument;
            KorisnikProduziPrintPreviewDialog.ShowDialog(this);
        }

        private void KorisnikProduziPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                using (TeretanaEntities baza = new TeretanaEntities())
                {
                    string ime=this.getImePrezime();
                    var racun=(from g in baza.Racun_Korisnik
                                  orderby g.Id descending
                                  select g).First();
                    var korisnik = (from b in baza.Korisnici
                                    where b.Ime_Prezime == ime
                                    select b).FirstOrDefault();

                    Bitmap bmp = Properties.Resources.tempo;
                    Image newimage = bmp;
                    e.Graphics.DrawImage(newimage, 300, 0, 250, 200);



                    e.Graphics.DrawString("Broj Računa:  " + racun.Id, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));
                    e.Graphics.DrawString("Datum izdavanja:  " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 280));

                    string crte = "-------------------------------------------------------------------------------------------------------------------------";
                    e.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 320));
                    e.Graphics.DrawString("Ime korisnika", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
                    e.Graphics.DrawString(korisnik.Ime_Prezime, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 350));

                    e.Graphics.DrawString("Adresa ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 380));
                    e.Graphics.DrawString(korisnik.Adresa, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 380));

                    e.Graphics.DrawString("Mobitel", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 410));
                    e.Graphics.DrawString(korisnik.Mobitel, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 410));
                       
                    var clanarina = (from g in baza.Clanarine
                               where g.Id == korisnik.Id_clanarine
                               select g).FirstOrDefault();

                    e.Graphics.DrawString("Članarina", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 440));
                    e.Graphics.DrawString(clanarina.Ime_clanarine, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 440));


                    
                e.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50,470));
                e.Graphics.DrawString("Ukupni Račun: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 500));

                e.Graphics.DrawString(clanarina.Cjena.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 500));

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }
        }

       
    }
}
