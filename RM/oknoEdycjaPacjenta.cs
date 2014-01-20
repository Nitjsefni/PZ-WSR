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
    public partial class oknoEdycjaPacjenta : Form
    {
        public oknoEdycjaPacjenta()
        {
            InitializeComponent();
        }

        private void dod_pacjenta_okno_Click_1(object sender, EventArgs e)
        {
            using (RMEntities ctx = new RMEntities())
            {

                //Create new Emp object
                DateTime date = data_przyj_pick.Value;
                Pacjenci1 d = new Pacjenci1() {
                    PESEL =  Convert.ToInt64(pesel_box.Text), 
                    imie = imie_box.Text, 
                    nazwisko = nazwisko_box.Text, 
                    data_przyjecia = date, 
                    miejscowosc = miejscowosc_box.Text, 
                    kod_pocztowy = kod_pocz_box.Text, 
                    lekarz = lekarz_box.Text, 
                    nr_ubezpieczenia = Convert.ToInt32(nr_ubez_box.Text), 
                    ulica = ulica_box.Text
                     };

                

                //Add to memory



                ctx.Pacjenci1.Add(d);


                //Save to database

                ctx.SaveChanges();
                
                oknoEdycjaPacjenta.ActiveForm.Close();
            }
        }

    }
}
