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
    public partial class Form1 : Form
    {
        dod_pacjentow form2 = new dod_pacjentow();
        public Form1()
        {
            InitializeComponent();
            
            form2.Show();
        }




        private void DisplayPatients()
        {
            using (var dc = new RMEntities())
            {
                var patients = from c in dc.Pacjenci1
                               select new
                               {

                                   pesel_pacjenta = c.PESEL,
                                   imie_pacjenta = c.imie,
                                   nazwisko_pacjenta = c.nazwisko,
                                   numer_ubezpieczenia_pacj = c.nr_ubezpieczenia,
                                   data_przyjecia_pacj = c.data_przyjecia,
                                   miejscowosc_pacj = c.miejscowosc,
                                   kod_pocz_pacj = c.kod_pocztowy,
                                   ulica_pacj = c.ulica,
                                   opis_pacj = c.opis,
                                   uwagi_pacj = c.uwagi,
                                   lekarz_pacjenta = c.lekarz

                               };

                dataGridView4.DataSource = patients.ToList();
            }




        }

        private void dod_pacj_Click(object sender, EventArgs e)
        {
            DisplayPatients();
        }





    }
}
