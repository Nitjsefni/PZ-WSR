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
    public partial class dod_pacjentow : Form
    {
        public dod_pacjentow()
        {
            InitializeComponent();
        }

        private void dod_pacjenta_okno_Click_1(object sender, EventArgs e)
        {
            using (RMEntities ctx = new RMEntities())
            {

                //Create new Emp object
                DateTime date = new DateTime(2012, 6, 14, 21, 30, 0);
                Pacjenci1 d = new Pacjenci1() { PESEL = 1231241424, imie = "Marcin", nazwisko = "Płociennik", data_przyjecia = date, miejscowosc = "Lubon", kod_pocztowy = "50-232", lekarz = "Wąsik", nr_ubezpieczenia = 2382183, ulica = "Lubońska", ID_lekarz = 92929292 };



                //Add to memory

                ctx.Pacjenci1.Add(d);





                //Save to database

                ctx.SaveChanges();

            }
        }

    }
}
