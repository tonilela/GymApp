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
using RefactorThis.GraphDiff;

namespace WindowsFormsApp2
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {

            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (TeretanaEntities context = new TeretanaEntities())
            {   
                var list = context.Korisnici.ToList();
                foreach (Korisnici c in list)
                {
                    ListViewItem item = new ListViewItem(c.Id.ToString());
                    item.SubItems.Add(c.Ime_Prezime);
                    item.SubItems.Add(c.Adresa);
                    item.SubItems.Add(c.Mobitel);
                    string rez = putPreostaloDanaDoKraja(c.Datum_upisa);
                    item.SubItems.Add(rez);
                    var clanarina = (from p in context.Clanarine where p.Id == c.Id_clanarine select p).FirstOrDefault();
                    item.SubItems.Add(clanarina.Cjena.ToString());
                    listView1.View = View.Details;
                    item.Tag = c;
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);
                }
            }

        }
        public string putPreostaloDanaDoKraja(DateTime datumUpisa)
        {
            DateTime danas = DateTime.Now;
            DateTime kraj = datumUpisa.AddDays(30);
            string Preostalo = (kraj - danas).TotalDays.ToString();
            string rez = "";
            if (Preostalo[0] == '-')
            {
                rez = "Članarina istekla";

            }
            else
            {
                decimal d = decimal.Parse(Preostalo);
                int i = decimal.ToInt32(d);
                Preostalo = i.ToString();
                rez = Preostalo;

            }

            return rez;

        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                Form2 forma = new Form2();

                TeretanaEntities novi = new TeretanaEntities();
                forma.Combo1();
                Korisnici clan = (Korisnici)listView1.SelectedItems[0].Tag;
                forma.putImePrezime(clan.Ime_Prezime);
                forma.putAdresu(clan.Adresa);
                forma.putMobitel(clan.Mobitel);
                forma.putComboClanarine(clan.Id_clanarine);
                forma.putDatum(clan.Datum_upisa.ToString("MMMM dd, yyyy"));
                forma.putPreostaloDana(clan.Datum_upisa);
                var days = forma.getBrojDana();
                DateTime datum = clan.Datum_upisa;
                forma.ShowDialog(this);

                if (forma.DialogResult == DialogResult.No) {

                    try {

                        using (TeretanaEntities baza = new TeretanaEntities())
                        {
                            var racuni = (from j in baza.Racun_Korisnik
                                      where j.Id_Korisnika == clan.Id
                                      select j).ToList();

                            var kor = (from p in baza.Korisnici
                                       where p.Id==clan.Id
                                       select p).FirstOrDefault();
                           
                            foreach (var racun in racuni) {
                                baza.Entry(racun).State = System.Data.Entity.EntityState.Deleted;
                               


                            }
                            baza.Korisnici.Remove(kor);
                            baza.SaveChanges();

                            this.Form1_Load(null, null);
                        }
                            


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                if (forma.DialogResult == DialogResult.Yes)
                {
                    if (days == "Članarina istekla")
                    {
                        try
                        {
                            clan.Datum_upisa = DateTime.Now;

                            Racun_Korisnik racun = new Racun_Korisnik();
                            racun.Id_Korisnika = clan.Id;
                            racun.Datum_izdavanja = DateTime.Now;


                            novi.Racun_Korisnik.Add(racun);
                            novi.SaveChanges();



                            using (TeretanaEntities baza = new TeretanaEntities())
                            {
                                baza.Korisnici.Attach(clan);
                                baza.Entry(clan).State = EntityState.Modified;
                                baza.SaveChanges();
                            }


                            forma.btnProduzi_Click(null, null);

                            this.Form1_Load(null, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }

                    }
                    else
                    {   MessageBox.Show("Članarina još nije istekla preostalo je "+days+" dana");
                        this.listView1_MouseDoubleClick(null, null);
                        
                        
                    }
                }

               
                    if (forma.DialogResult == DialogResult.OK)
                    {
                        try
                        {
                            using (TeretanaEntities baza = new TeretanaEntities())
                            {
                            string ImePrezime = forma.getImePrezime();
                            string Adresa = forma.getAdresu();
                            string Mobitel = forma.getMobitel();
                          int Vrsta_clanarine = forma.getComboClanarina1();

                            
                            clan.Ime_Prezime = ImePrezime;
                            clan.Adresa = Adresa;
                            clan.Mobitel = Mobitel;
                            clan.Datum_upisa = datum;


                    
                            
                         //   clan.Id_clanarine =Vrsta_clanarine;
                                baza.Korisnici.Attach(clan);
                                baza.Entry(clan).State = EntityState.Modified;
                                baza.SaveChanges();
                            }




                            this.Form1_Load(null, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }

                    forma.Dispose();

                }
                
            }
            catch (Exception ex) { }
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Form3 formaClanarine = new Form3();
                formaClanarine.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ne radi");

            }
            this.Form1_Load(null, null);

        }
      
        private void btnNovi_Click(object sender, EventArgs e)
        {
            try
            {
                Form5 forma = new Form5();

                TeretanaEntities novi = new TeretanaEntities();
                forma.Combo1();
                forma.ShowDialog(this);
                if (forma.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        Korisnici clan = new Korisnici();
                        string ImePrezime = forma.getImePrezime();
                        string Adresa = forma.getAdresu();
                        string Mobitel = forma.getMobitel();
                        int Vrsta_clanarine = forma.getComboClanarina();

                        clan.Ime_Prezime = ImePrezime;
                        clan.Adresa = Adresa;
                        clan.Mobitel = Mobitel;
                        clan.Id_clanarine = Vrsta_clanarine;
                        clan.Datum_upisa = DateTime.Now;

                        Racun_Korisnik racun = new Racun_Korisnik();
                        racun.Id_Korisnika = clan.Id;
                        racun.Datum_izdavanja = DateTime.Now;

                        novi.Korisnici.Add(clan);
                        novi.Racun_Korisnik.Add(racun);
                        novi.SaveChanges();


                        forma.Ok_Click(null,null);


                        this.Form1_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }



                }
                forma.Dispose();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void txtPretraziId_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
               
                    int id = Int32.Parse(txtPretraziId.Text);
                TeretanaEntities db = new TeretanaEntities();
             
                    var c = (from p in db.Korisnici where p.Id == id select p).FirstOrDefault();

                ListViewItem item = new ListViewItem(c.Id.ToString());
                item.SubItems.Add(c.Ime_Prezime);
                item.SubItems.Add(c.Adresa);
                item.SubItems.Add(c.Mobitel);
                string rez = putPreostaloDanaDoKraja(c.Datum_upisa);
                item.SubItems.Add(rez);
                var clanarina = (from p in db.Clanarine where p.Id == c.Id_clanarine select p).FirstOrDefault();
                item.SubItems.Add(clanarina.Cjena.ToString());
                listView1.View = View.Details;
                item.Tag = c;
                listView1.FullRowSelect = true;
                listView1.Items.Add(item);


            }
            catch {

                this.Form1_Load(null, null);

            }
        }

        private void btnProizvoidi_Click(object sender, EventArgs e)
        {
            try
            {
                Form6 formaProizvodi = new Form6();
                formaProizvodi.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ne radi");

            }
        }

        private void btnKosarica_Click(object sender, EventArgs e)
        {
            try
            {
                Form8 formaKosarica = new Form8();
              formaKosarica.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ne radi");

            }
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            try
            {
                Form9 formaRacuni = new Form9();
                formaRacuni.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ne radi");

            }
        }
    }
}
