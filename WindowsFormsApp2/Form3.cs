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
    public partial class Form3 : MaterialSkin.Controls.MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listViewClanarine.Items.Clear();
            using (TeretanaEntities context = new TeretanaEntities())
            {
                var list = context.Clanarine.ToList();
                foreach (var c in list)
                {
                    ListViewItem item = new ListViewItem(c.Id.ToString());
                    item.SubItems.Add(c.Ime_clanarine);
                    item.SubItems.Add(c.Cjena.ToString());
                    listViewClanarine.View = View.Details;
                    item.Tag = c;
                    listViewClanarine.FullRowSelect = true;
                    listViewClanarine.Items.Add(item);
                }
            }
        }

        private void listViewClanarine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Form4 forma = new Form4();

                TeretanaEntities novi = new TeretanaEntities();

                var clanarine = (Clanarine)listViewClanarine.SelectedItems[0].Tag;
                forma.putIme(clanarine.Ime_clanarine);
                forma.putCjena(clanarine.Cjena.ToString());

                forma.ShowDialog(this);
                if (forma.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        string Ime = forma.getIme();
                        string Cjena = forma.getCjena();

                        clanarine.Ime_clanarine = Ime;
                        decimal d = decimal.Parse(Cjena);
                        clanarine.Cjena = d;


                        novi.Clanarine.Attach(clanarine);
                        novi.Entry(clanarine).State = EntityState.Modified;
                        novi.SaveChanges();





                        this.Form3_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ne radi");

                    }



                }
                forma.Dispose();
            }
            catch (Exception ex) { }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 forma = new Form4();

                forma.ShowDialog(this);
                if (forma.DialogResult == DialogResult.OK)
                {

                    string ime = forma.getIme();
                    string cjena = forma.getCjena();

                    TeretanaEntities nova = new TeretanaEntities();
                    Clanarine clanarina = new Clanarine();

                    decimal d = decimal.Parse(cjena);
                    clanarina.Cjena = d;
                    clanarina.Ime_clanarine = ime;

                    nova.Clanarine.Add(clanarina);
                    nova.SaveChanges();
                    this.Form3_Load(null, null);
                  
                        
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ne radi");

            }
        }
    }
}
