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
        public Form1()
        {
            InitializeComponent();
            DisplayCustomers();
        }

<<<<<<< HEAD
       private void DisplayCustomers()
        {
            using (var dc = new RMEntities())
            {
                var customers = from c in dc.Pacjenci1
                                select new
                                {
                                   
                                    pesel_pacjenta = c.PESEL,
                                    imie_pacjenta = c.imie,
                                    nazwisko_pacjenta = c.nazwisko,
                                    numer_ubezpieczenia_pacj = c.nr_ubezpieczenia,
                                   
                                    miejscowosc_pacj = c.miejscowosc,
                                    kod_pocz_pacj = c.kod_pocztowy,
                                    ulica_pacj = c.ulica,
                                    opis_pacj = c.opis,
                                    uwagi_pacj = c.uwagi,
                                    lekarz_pacjenta = c.lekarz
                                    
                                };

                dataGridView4.DataSource = customers.ToList();
            }
        }
=======
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rMDataSet.Pacjenci1' table. You can move, or remove it, as needed.
            this.pacjenci1TableAdapter.Fill(this.rMDataSet.Pacjenci1);

        }





>>>>>>> 200a27f736eb6c67f1ed734cb3a777303ceedb40

    }
}
