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
    public partial class Form6 : MaterialSkin.Controls.MaterialForm
    {
        public Form6()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            listViewPrizvodi.Items.Clear();
            using (TeretanaEntities context = new TeretanaEntities())
            {
                var list = context.Proizvodi.ToList();
                foreach (var c in list)
                {
                    ListViewItem item = new ListViewItem(c.Id.ToString());
                    item.SubItems.Add(c.Ime_Proizvoda);
                    item.SubItems.Add(c.Opis);
                   
                    item.SubItems.Add(c.Cjena.ToString());
                    listViewPrizvodi.View = View.Details;
                    item.Tag = c;
                    listViewPrizvodi.FullRowSelect = true;
                    listViewPrizvodi.Items.Add(item);
                }
            }
        }

        private void btnNoviProizvod_Click(object sender, EventArgs e)
        {
            try
            {
                Form7 forma = new Form7();

                forma.ShowDialog(this);
                if (forma.DialogResult == DialogResult.OK)
                {
                    try
                    {

                        string ime = forma.getIme();
                        string cjena = forma.getCjena();
                        string opis = forma.getOpis();

                        TeretanaEntities nova = new TeretanaEntities();
                        Proizvodi proizvodi = new Proizvodi();

                        decimal d = decimal.Parse(cjena);
                        proizvodi.Cjena = d;
                        proizvodi.Ime_Proizvoda = ime;
                        proizvodi.Opis = opis;

                        nova.Proizvodi.Add(proizvodi);
                        nova.SaveChanges();
                        this.Form6_Load(null, null);


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }





            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);

            }

        }

        private void listViewPrizvodi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Form7 forma = new Form7();

                TeretanaEntities novi = new TeretanaEntities();

                var proizvodi = (Proizvodi)listViewPrizvodi.SelectedItems[0].Tag;
                forma.putIme(proizvodi.Ime_Proizvoda);
                forma.putCjena(proizvodi.Cjena.ToString());
                forma.putOpis(proizvodi.Opis);

                forma.ShowDialog(this);
                if (forma.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        string Ime = forma.getIme();
                        string Cjena = forma.getCjena();
                        string opis = forma.getOpis();

                        proizvodi.Ime_Proizvoda = Ime;
                        proizvodi.Opis = opis;
                        decimal d = decimal.Parse(Cjena);
                        proizvodi.Cjena = d;


                        novi.Proizvodi.Attach(proizvodi);
                        novi.Entry(proizvodi).State = EntityState.Modified;
                        novi.SaveChanges();





                        this.Form6_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ne radi");

                    }



                }
                if (forma.DialogResult == DialogResult.No)
                {
                    try
                    {
                        using (TeretanaEntities baza = new TeretanaEntities())
                        {

                            var racuni=(from j in baza.Racun_Proizvodi
                                      where j.Id_proizvoda == proizvodi.Id
                                      select j).ToList();

                          

                            var proiz = (from p in baza.Proizvodi
                                         where p.Id == proizvodi.Id
                                         select p).FirstOrDefault();


                            foreach (var racun in racuni)
                            {
                                baza.Entry(racun).State = System.Data.Entity.EntityState.Deleted;



                            }
                            baza.Proizvodi.Remove(proiz);
                            baza.SaveChanges();
                            this.Form6_Load(null, null);
                        }


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
    }
}
