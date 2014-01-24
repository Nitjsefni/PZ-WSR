using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class oknoEdycjaKaretki : Form
    {
        private Karetka edytowanaKaretka;

        public oknoEdycjaKaretki()
        {
            InitializeComponent();
            edytowanaKaretka = new Karetka();
        }

        public  oknoEdycjaKaretki(long ID_karetki)
        {
            InitializeComponent();
            this.Show();

            using (var ctx = new RMEntities())
            {
                
                edytowanaKaretka = ctx.Karetkas.SingleOrDefault(c => c.ID_karetki == ID_karetki);

                zaladujWartosciDoBoxow();

                this.dodaj_karetke_button.Text = "Edytuj";

                this.dodaj_karetke_button.Click -= new System.EventHandler(this.dodaj_karetke_Click);
                this.dodaj_karetke_button.Click += new System.EventHandler(this.edytuj_karetke_Click);
            }
        }

        public oknoGlowne zwrocOknoGlowne()
        {
            oknoGlowne og = this.Owner as oknoGlowne;
            return og;
        }

        public void zaladujWartosciZBoxow()
        {
           // edytowanaKaretka.ID_karetki = Convert.ToInt32(ID_karetki_box.Text);
            edytowanaKaretka.typ_numer = typ_box.Text;
            edytowanaKaretka.ID_skladu = Convert.ToInt32(ID_skladu_box.Text);
            edytowanaKaretka.wyposazenie = wyposazenie_box.Text;
            edytowanaKaretka.uwagi = uwagi_box.Text;
        }

        public void zaladujWartosciDoBoxow()
        {
            //ID_karetki_box.Text = edytowanaKaretka.ID_karetki.ToString();
            typ_box.Text = edytowanaKaretka.typ_numer;
            ID_skladu_box.Text = edytowanaKaretka.ID_skladu.ToString();
            wyposazenie_box.Text = edytowanaKaretka.wyposazenie;
            uwagi_box.Text = edytowanaKaretka.uwagi;

        }

        private void edytuj_karetke_Click(object sender, EventArgs e)
        {
            zaladujWartosciZBoxow();

            using (RMEntities ctx = new RMEntities())
            {
                ctx.Karetkas.Attach(edytowanaKaretka);
                ctx.Entry(edytowanaKaretka).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            oknoEdycjaKaretki.ActiveForm.Close();
        }

        private void dodaj_karetke_Click(object sender, EventArgs e)
        {
            zaladujWartosciZBoxow();

            using (RMEntities ctx = new RMEntities())
            {
                ctx.Karetkas.Add(edytowanaKaretka);
                ctx.SaveChanges();
            }

            oknoEdycjaKaretki.ActiveForm.Close();
        }

    }
}
