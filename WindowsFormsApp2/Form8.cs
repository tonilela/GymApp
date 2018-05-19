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
    public partial class Form8 : MaterialSkin.Controls.MaterialForm
    {
        public Form8()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            listViewPonudaProizvoda.Items.Clear();
            listViewKosarica.Items.Clear();
            using (TeretanaEntities context = new TeretanaEntities())
            {
                var list = context.Proizvodi.ToList();
                foreach (var c in list)
                {
                    ListViewItem item = new ListViewItem(c.Id.ToString());
                    item.SubItems.Add(c.Ime_Proizvoda);
                   

                    item.SubItems.Add(c.Cjena.ToString());
                    listViewPonudaProizvoda.View = View.Details;
                    item.Tag = c;
                    listViewPonudaProizvoda.FullRowSelect = true;
                    listViewPonudaProizvoda.Items.Add(item);
                }
                Racuni racun = new Racuni();
                racun.Datum_izdavanja = DateTime.Now;
                context.Racuni.Add(racun);
                context.SaveChanges();
                
            }
        }

        private void listViewPonudaProizvoda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Proizvodi proizvod = (Proizvodi)listViewPonudaProizvoda.SelectedItems[0].Tag;
           
            try
            {
                using (TeretanaEntities baza = new TeretanaEntities())
                {
                    var ZadnjiRacun = (from c in baza.Racuni
                                       orderby c.Id descending
                                       select c).First();

                   
                        int kol = Int32.Parse(numericUpDown1.Value.ToString());


                    Racun_Proizvodi racun = new Racun_Proizvodi();
                    racun.Id_proizvoda = proizvod.Id;
                    racun.Id_racuna = ZadnjiRacun.Id;
                    racun.Kolicina = kol;

                    baza.Racun_Proizvodi.Add(racun);
                    baza.SaveChanges();
                    ListViewItem item = new ListViewItem(proizvod.Id.ToString());
                    item.SubItems.Add(proizvod.Ime_Proizvoda);


                    item.SubItems.Add(proizvod.Cjena.ToString());
                    item.SubItems.Add(racun.Kolicina.ToString());
                    listViewKosarica.View = View.Details;
                    item.Tag = proizvod;
                    listViewKosarica.FullRowSelect = true;
                    listViewKosarica.Items.Add(item);
                    if (labelUkupniRacun.Text == "")
                    {
                        labelUkupniRacun.Text = (proizvod.Cjena * kol).ToString();


                    }
                    else {
                        decimal d = decimal.Parse(labelUkupniRacun.Text);
                        labelUkupniRacun.Text =(d+ (proizvod.Cjena * kol)).ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                using (TeretanaEntities novabaza = new TeretanaEntities())

                {
                      var ZadnjiRacun = (from c in novabaza.Racuni
                                         orderby c.Id descending
                                         select c).First();
                      var racun_proizvod = (from d in novabaza.Racun_Proizvodi
                                            where d.Id_racuna == ZadnjiRacun.Id
                                            && d.Id_proizvoda == proizvod.Id
                                            select d).FirstOrDefault();
                    racun_proizvod.Kolicina +=  Int32.Parse(numericUpDown1.Value.ToString());

                    novabaza.Racun_Proizvodi.Attach(racun_proizvod);

                 
                    novabaza.Entry(racun_proizvod).State = EntityState.Modified;
                    novabaza.SaveChanges();
                    decimal ukupno = decimal.Parse(labelUkupniRacun.Text);
                    labelUkupniRacun.Text = (ukupno + (proizvod.Cjena * Int32.Parse(numericUpDown1.Value.ToString()))).ToString();
                    var ProizvodiKosarica = (from g in novabaza.Racun_Proizvodi
                                             where g.Id_racuna == ZadnjiRacun.Id
                                             select g.Proizvodi).ToList();

                    listViewKosarica.Items.Clear();
                    foreach (var proizvod1 in ProizvodiKosarica)
                    {
                        ListViewItem item = new ListViewItem(proizvod1.Id.ToString());
                        item.SubItems.Add(proizvod1.Ime_Proizvoda);


                        item.SubItems.Add(proizvod1.Cjena.ToString());
                        var racun_proizvodii = (from d in novabaza.Racun_Proizvodi
                                                where d.Id_racuna == ZadnjiRacun.Id
                                                && d.Id_proizvoda == proizvod1.Id
                                                select d).FirstOrDefault();
                        item.SubItems.Add(racun_proizvodii.Kolicina.ToString());
                        listViewKosarica.View = View.Details;
                        item.Tag = proizvod1;
                        listViewKosarica.FullRowSelect = true;
                        listViewKosarica.Items.Add(item);
                    }
                }
                  

            }


        }

        private void listViewKosarica_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Proizvodi proizvod = (Proizvodi)listViewKosarica.SelectedItems[0].Tag;

            try
            {
                using (TeretanaEntities baza = new TeretanaEntities())
                {
                    var ZadnjiRacun = (from c in baza.Racuni
                                       orderby c.Id descending
                                       select c).First();
                    var racun_proizvod = (from d in baza.Racun_Proizvodi
                                          where d.Id_racuna == ZadnjiRacun.Id
                                          && d.Id_proizvoda == proizvod.Id
                                          select d).FirstOrDefault();
                    decimal ukupno = decimal.Parse(labelUkupniRacun.Text);
                    labelUkupniRacun.Text = (ukupno - (racun_proizvod.Kolicina * proizvod.Cjena)).ToString();
                    baza.Racun_Proizvodi.Remove(racun_proizvod);
                    baza.SaveChanges();
                    var ProizvodiKosarica = (from g in baza.Racun_Proizvodi
                                             where g.Id_racuna == ZadnjiRacun.Id
                                             select g.Proizvodi).ToList();

                    listViewKosarica.Items.Clear();
                    foreach (var proizvod1 in ProizvodiKosarica)
                    {
                        ListViewItem item = new ListViewItem(proizvod1.Id.ToString());
                        item.SubItems.Add(proizvod1.Ime_Proizvoda);


                        item.SubItems.Add(proizvod1.Cjena.ToString());
                        var racun_proizvodii = (from d in baza.Racun_Proizvodi
                                              where d.Id_racuna == ZadnjiRacun.Id
                                              && d.Id_proizvoda == proizvod1.Id
                                              select d).FirstOrDefault();
                        item.SubItems.Add(racun_proizvodii.Kolicina.ToString());
                        listViewKosarica.View = View.Details;
                        item.Tag = proizvod1;
                        listViewKosarica.FullRowSelect = true;
                        listViewKosarica.Items.Add(item);
                    }
                  
                }
            }

            catch (Exception ex)
            {
              
                    MessageBox.Show(ex.Message);
                
            }
        }

        private void btnIzbrisiKosaricu_Click(object sender, EventArgs e)
        {
            try {
                using (TeretanaEntities baza = new TeretanaEntities())
                {
                    var ZadnjiRacun = (from c in baza.Racuni
                                       orderby c.Id descending
                                       select c).First();

                    var SviZadnjiRacuni = (from g in baza.Racun_Proizvodi
                                           where g.Id_racuna == ZadnjiRacun.Id
                                           select g).ToList();

                    foreach (var rac in SviZadnjiRacuni) {

                        baza.Racun_Proizvodi.Remove(rac);

                    }
                    baza.SaveChanges();
                    listViewKosarica.Items.Clear();
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            KosaricaPrintPreviewDialog.Document = KosaricaPrintDocument;
            KosaricaPrintPreviewDialog.ShowDialog();
            
        }

        private void KosaricaPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                using (TeretanaEntities baza = new TeretanaEntities())
                {

                    var ZadnjiRacun = (from c in baza.Racuni
                                       orderby c.Id descending
                                       select c).First();

                    var sviProizvodi = (from g in baza.Racun_Proizvodi
                                        where g.Id_racuna == ZadnjiRacun.Id
                                        select g.Proizvodi).ToList();

                    Bitmap bmp = Properties.Resources.tempo;
                    Image newimage = bmp;
                    e.Graphics.DrawImage(newimage, 300, 0, 250, 200);


                  
                    e.Graphics.DrawString("Broj Računa:  " + ZadnjiRacun.Id, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50,250));
                    e.Graphics.DrawString("Datum izdavanja:  " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 280));

                    string crte = "-------------------------------------------------------------------------------------------------------------------------";
                    e.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 320));
                    e.Graphics.DrawString("Ime Proizvoda", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
                    e.Graphics.DrawString("Cijena ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 350));

                    e.Graphics.DrawString("Količina ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 350));

                    e.Graphics.DrawString("Ukupno", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 350));
                    e.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 380));
                    
                    PointF drawPoint = new PointF(50,410);
                  decimal UkupniRacun = 0;
                    foreach (var proizvod in sviProizvodi)
                    {


                        e.Graphics.DrawString(proizvod.Ime_Proizvoda, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                        drawPoint.X = 300;
                        e.Graphics.DrawString(proizvod.Cjena.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                        drawPoint.X = 470;
                        var kol = (from g in baza.Racun_Proizvodi
                                            where g.Id_racuna == ZadnjiRacun.Id 
                                            && g.Id_proizvoda==proizvod.Id
                                            select g.Kolicina).FirstOrDefault();
                        e.Graphics.DrawString(kol.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                        drawPoint.X = 600;
                        e.Graphics.DrawString((kol*proizvod.Cjena).ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                        UkupniRacun += (kol * proizvod.Cjena);
                        drawPoint.Y += 30;
                        drawPoint.X = 50;
                    }
                    int y =((int) drawPoint.Y)+36;
                    e.Graphics.DrawString(crte, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, drawPoint);
                     e.Graphics.DrawString("Ukupni Račun: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, y));

                       e.Graphics.DrawString(UkupniRacun.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, y));

                }
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
            
           
        }
    }
}
