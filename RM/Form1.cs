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

        private void DisplayCustomers()
        {
            using (var dc = new RMEntities())
            {
                var customers = from c in dc.Pacjenci1
                                select new
                                {
                                   
                                    pesel_pacjenta1 = c.PESEL,
                                    imie_pacjenta = c.imie,
                                    nazwisko_pacjenta = c.nazwisko,
                                    numer_ubezpieczenia_pacj = c.nr_ubezpieczenia
                                };

                dataGridView4.DataSource = customers.ToList();
            }
        }

    }
}
