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

                this.dodaj_karetke_button.Click -= new System.EventHandler(this.dodaj_karetke_button_Click);
            }
        }

        public oknoGlowne zwrocOknoGlowne()
        {
            oknoGlowne og = this.Owner as oknoGlowne;
            return og;
        }

        public void zaladujWartosciZBoxow()
        {
            edytowanaKaretka.ID_karetki = 1;
            edytowanaKaretka.typ_numer = typ_box.Text;
            edytowanaKaretka.ID_skladu = 1;
            edytowanaKaretka.wyposazenie = "test";
            edytowanaKaretka.uwagi = uwagi_box.Text;
        }

        private void dodaj_karetke_button_Click(object sender, EventArgs e)
        {
            zaladujWartosciZBoxow();

            using (RMEntities ctx = new RMEntities())
            {
                ctx.Karetkas.Attach(edytowanaKaretka);
                ctx.SaveChanges();
            }

            oknoEdycjaKaretki.ActiveForm.Close();
        }

    }
}
