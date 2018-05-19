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
using System.Drawing.Printing;

namespace WindowsFormsApp2
{
    public partial class Form9 : MaterialSkin.Controls.MaterialForm
    {
        public Form9()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            listViewKorisnici.Items.Clear();
            listViewProizvodi.Items.Clear();
            using (TeretanaEntities context = new TeretanaEntities())
            {



                var list = context.Racun_Proizvodi.ToList();
                int id = 0;
                decimal ukupno = 0;
                decimal ukupanIZnos = 0;
                foreach (var c in list)
                {
                    if (id != c.Id_racuna)
                    {
                        ListViewItem item = new ListViewItem(c.Id_racuna.ToString());
                        item.SubItems.Add(c.Racuni.Datum_izdavanja.ToString());
                        var racun = (from j in context.Racun_Proizvodi
                                     where j.Id_racuna == c.Id_racuna
                                     select j).ToList();

                        foreach (var rac in racun)
                        {
                            ukupno += rac.Kolicina * rac.Proizvodi.Cjena;



                        }
                        item.SubItems.Add(ukupno.ToString());

                        ukupanIZnos += ukupno;
                        listViewProizvodi.View = View.Details;
                        item.Tag = c;
                        listViewProizvodi.FullRowSelect = true;
                        listViewProizvodi.Items.Add(item);
                        id = c.Id_racuna;
                    }
                    ukupno = 0;
                }

                var novaLista = context.Racun_Korisnik.ToList();

                decimal UkupanIznosClanarine = 0;
                foreach (var k in novaLista)
                {

                    ListViewItem item = new ListViewItem(k.Id.ToString());
                    item.SubItems.Add(k.Datum_izdavanja.ToString());
                    item.SubItems.Add(k.Korisnici.Ime_Prezime.ToString());

                    item.SubItems.Add(k.Korisnici.Clanarine.Cjena.ToString());

                    UkupanIznosClanarine += k.Korisnici.Clanarine.Cjena;
                    listViewKorisnici.View = View.Details;
                    item.Tag = k;
                    listViewKorisnici.FullRowSelect = true;
                    listViewKorisnici.Items.Add(item);
                }
                txtRacuniKorisnici.Text = UkupanIznosClanarine.ToString();
                txtRacuniProizvodi.Text = ukupanIZnos.ToString();



            }
        }

        private void listViewProizvodi_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                var racun = listViewProizvodi.SelectedItems[0].SubItems[0].Text;
                int br = Int32.Parse(racun);
                TeretanaEntities baza = new TeretanaEntities();
                var nesto = (from k in baza.Racuni
                             where k.Id == br
                             select k).FirstOrDefault();
                PrintDocument p = new PrintDocument();
                p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    var sviProizvodi = (from g in baza.Racun_Proizvodi
                                        where g.Id_racuna == nesto.Id
                                        select g.Proizvodi).ToList();

                    Bitmap bmp = Properties.Resources.tempo;
                    Image newimage = bmp;
                    e1.Graphics.DrawImage(newimage, 300, 0, 250, 200);



                    e1.Graphics.DrawString("Broj Računa:  " + nesto.Id, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));
                    e1.Graphics.DrawString("Datum izdavanja:  " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 280));

                    string crte = "-------------------------------------------------------------------------------------------------------------------------";
                    e1.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 320));
                    e1.Graphics.DrawString("Ime Proizvoda", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
                    e1.Graphics.DrawString("Cijena ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 350));

                    e1.Graphics.DrawString("Količina ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 350));

                    e1.Graphics.DrawString("Ukupno", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 350));
                    e1.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 380));

                    PointF drawPoint = new PointF(50, 410);
                    decimal UkupniRacun = 0;
                    foreach (var proizvod in sviProizvodi)
                    {


                        e1.Graphics.DrawString(proizvod.Ime_Proizvoda, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                        drawPoint.X = 300;
                        e1.Graphics.DrawString(proizvod.Cjena.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                        drawPoint.X = 470;
                        var kol = (from g in baza.Racun_Proizvodi
                                   where g.Id_racuna == nesto.Id
                                   && g.Id_proizvoda == proizvod.Id
                                   select g.Kolicina).FirstOrDefault();
                        e1.Graphics.DrawString(kol.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                        drawPoint.X = 600;
                        e1.Graphics.DrawString((kol * proizvod.Cjena).ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                        UkupniRacun += (kol * proizvod.Cjena);
                        drawPoint.Y += 30;
                        drawPoint.X = 50;
                    }
                    int y = ((int)drawPoint.Y) + 36;
                    e1.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                    e1.Graphics.DrawString("Ukupni Račun: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, y));

                    e1.Graphics.DrawString(UkupniRacun.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, y));

                };



                try
                {
                    ProizvodiPrintPreviewDialog.Document = p;
                    ProizvodiPrintPreviewDialog.ShowDialog();
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception Occured While Printing", ex);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var racuni = listViewKorisnici.SelectedItems[0].SubItems[0].Text;
                int br = Int32.Parse(racuni);
                TeretanaEntities baza = new TeretanaEntities();

                PrintDocument novidoc = new PrintDocument();
                novidoc.PrintPage += delegate (object sender2, PrintPageEventArgs e2)
                {
                    var racun = (from g in baza.Racun_Korisnik
                                 where g.Id == br
                                 select g).First();
                    var korisnik = (from b in baza.Korisnici
                                    where b.Id == racun.Id_Korisnika
                                    select b).FirstOrDefault();

                    Bitmap bmp = Properties.Resources.tempo;
                    Image newimage = bmp;
                    e2.Graphics.DrawImage(newimage, 300, 0, 250, 200);



                    e2.Graphics.DrawString("Broj Računa:  " + racun.Id, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));
                    e2.Graphics.DrawString("Datum izdavanja:  " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 280));

                    string crte = "-------------------------------------------------------------------------------------------------------------------------";
                    e2.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 320));
                    e2.Graphics.DrawString("Ime korisnika", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
                    e2.Graphics.DrawString(korisnik.Ime_Prezime, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 350));

                    e2.Graphics.DrawString("Adresa ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 380));
                    e2.Graphics.DrawString(korisnik.Adresa, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 380));

                    e2.Graphics.DrawString("Mobitel", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 410));
                    e2.Graphics.DrawString(korisnik.Mobitel, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 410));

                    var clanarina = (from g in baza.Clanarine
                                     where g.Id == korisnik.Id_clanarine
                                     select g).FirstOrDefault();

                    e2.Graphics.DrawString("Članarina", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 440));
                    e2.Graphics.DrawString(clanarina.Ime_clanarine, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 440));



                    e2.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 470));
                    e2.Graphics.DrawString("Ukupni Račun: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 500));

                    e2.Graphics.DrawString(clanarina.Cjena.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 500));




                };


                try
                {
                    KorisniciPrintPreviewDialog.Document = novidoc;
                    KorisniciPrintPreviewDialog.ShowDialog();
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception Occured While Printing", ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
