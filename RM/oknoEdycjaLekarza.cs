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
    public partial class oknoEdycjaLekarza : Form
    {
        private Personel1 edytowanyLekarz;

        public oknoEdycjaLekarza()
        {
            InitializeComponent();

            edytowanyLekarz = new Personel1();
        }

        public oknoEdycjaLekarza(long ID_lekarza)
        {
            InitializeComponent();
            this.Show();

            using (var ctx = new RMEntities())
            {
                edytowanyLekarz = ctx.Personel1.SingleOrDefault(c => c.ID_lekarz == ID_lekarza);

                zaladujWartosciDoBoxow();

                this.dod_lekarza_okno.Text = "Edytuj";

                this.dod_lekarza_okno.Click -= new System.EventHandler(this.dodajLekarza_Click);
                this.dod_lekarza_okno.Click += new System.EventHandler(this.edytujLekarza_Click);
            }
        }

        public oknoGlowne zwrocOknoGlowne()
        {
            oknoGlowne og = this.Owner as oknoGlowne;
            return og;
        }

        public void zaladujWartosciZBoxow()
        {
            

            //edytowanyLekarz.ID_lekarz = Convert.ToInt64(ID_box.Text);
            edytowanyLekarz.imie = imie_box.Text;
            edytowanyLekarz.nazwisko = nazw_box.Text;
            edytowanyLekarz.stanowisko = stanowisko_box.Text;
            edytowanyLekarz.specjalizacja = specj_box.Text;

        }

        public void zaladujWartosciDoBoxow()
        {
            //ID_box.Text = edytowanyLekarz.ID_lekarz.ToString();
            imie_box.Text = edytowanyLekarz.imie;
            nazw_box.Text = edytowanyLekarz.nazwisko;
            stanowisko_box.Text = edytowanyLekarz.stanowisko;
            specj_box.Text = edytowanyLekarz.specjalizacja;

        }

        private void edytujLekarza_Click(object sender, EventArgs e)
        {
            zaladujWartosciZBoxow();

            using (RMEntities ctx = new RMEntities())
            {
                ctx.Personel1.Attach(edytowanyLekarz);
                ctx.Entry(edytowanyLekarz).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            oknoEdycjaPacjenta.ActiveForm.Close();
        }

        private void dodajLekarza_Click(object sender, EventArgs e)
        {
            zaladujWartosciZBoxow();

            using (RMEntities ctx = new RMEntities())
            {
                ctx.Personel1.Add(edytowanyLekarz);
                ctx.SaveChanges();

                oknoEdycjaLekarza.ActiveForm.Close();
            }
        }



    }
}
