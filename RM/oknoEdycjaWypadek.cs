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
    public partial class oknoEdycjaWypadek : Form
    {
        private Wypadek edytowanyWypadek;

        public oknoEdycjaWypadek()
        {
            InitializeComponent();
            edytowanyWypadek = new Wypadek();
        }

        public  oknoEdycjaWypadek(long ID_Wypadku)
        {
            InitializeComponent();
            this.Show();

            using (var ctx = new RMEntities())
            {
                
                edytowanyWypadek = ctx.Wypadeks.SingleOrDefault(c => c.ID_wypadku == ID_Wypadku);

                zaladujWartosciDoBoxow();

                this.dodaj_wypadek_button.Text = "Edytuj";

                this.dodaj_wypadek_button.Click -= new System.EventHandler(this.dodaj_wypadek_button_Click);
                this.dodaj_wypadek_button.Click += new System.EventHandler(this.edytuj_wypadek_Click);
            }
        }
        //dotąd sprawdzone
        public oknoGlowne zwrocOknoGlowne()
        {
            oknoGlowne og = this.Owner as oknoGlowne;
            return og;
        }

        public void zaladujWartosciZBoxow()
        {
            DateTime date = dateTimePicker1.Value;

            //jak już będzie AutoIncrement wywalić tego Randa!
            Random random = new Random();
            int randomNumber = random.Next(0, 1000);

            edytowanyWypadek.ID_wypadku = randomNumber; //Convert.ToInt32(ID_wypadku_box.Text);
            edytowanyWypadek.miejsce_wypadku = miejsce_box.Text;
            edytowanyWypadek.liczba_rannych =  Convert.ToInt32(liczba_rannych_box.Text);
            edytowanyWypadek.typ_wypadku = typ_comboBox.Text;
            edytowanyWypadek.data_godz_zgl = date;
            edytowanyWypadek.ID_skladu = 1;
            edytowanyWypadek.numer_zgl =  Convert.ToInt32(telefon_zgl_box.Text);
            edytowanyWypadek.uwagi = opis_box.Text;
        }

        public void zaladujWartosciDoBoxow()
        {
            ID_wypadku_box.Text = edytowanyWypadek.ID_wypadku.ToString();
            miejsce_box.Text = edytowanyWypadek.miejsce_wypadku;
            liczba_rannych_box.Text = edytowanyWypadek.liczba_rannych.ToString();
            typ_comboBox.Text = edytowanyWypadek.typ_wypadku;
            dateTimePicker1.Text = edytowanyWypadek.data_godz_zgl.ToString();
            edytowanyWypadek.ID_skladu = edytowanyWypadek.ID_skladu;
            telefon_zgl_box.Text = edytowanyWypadek.numer_zgl.ToString();
            opis_box.Text = edytowanyWypadek.uwagi;

        }

        private void edytuj_wypadek_Click(object sender, EventArgs e)
        {
            zaladujWartosciZBoxow();

            using (RMEntities ctx = new RMEntities())
            {
                ctx.Wypadeks.Attach(edytowanyWypadek);
                ctx.Entry(edytowanyWypadek).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            oknoEdycjaWypadek.ActiveForm.Close();
        }

        private void dodaj_wypadek_button_Click(object sender, EventArgs e)
        {
            zaladujWartosciZBoxow();

            using (RMEntities ctx = new RMEntities())
            {
                ctx.Wypadeks.Add(edytowanyWypadek);
                ctx.SaveChanges();
            }

            oknoEdycjaWypadek.ActiveForm.Close();
        }
    }
}
