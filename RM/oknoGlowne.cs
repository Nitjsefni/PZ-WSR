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
    public partial class oknoGlowne : Form
    {
        oknoEdycjaPacjenta form2 = new oknoEdycjaPacjenta();
        oknoEdycjaLekarza form3 = new oknoEdycjaLekarza();
        public oknoGlowne()
        {
            InitializeComponent();
            DisplayPatients();
            DisplayDoctors();
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

            private void DisplayDoctors()
            {
            using (var dc = new RMEntities())
            {
                var doctors = from c in dc.Personel1
                               select new
                               {
                                   ID_lekarz = c.ID_lekarz,
                                   imie_lekarz = c.imie,
                                   nazwisko_lekarz = c.nazwisko,
                                   stanowisko_lekarz = c.stanowisko,
                                   specjalizacja_lekarz = c.specjalizacja
                                   

                               };

                dataGridView5.DataSource = doctors.ToList();
            }


        }

        private void dod_pacj_Click(object sender, EventArgs e)
        {
            form2.Show();
            
        }

        private void odswiezanie_Click(object sender, EventArgs e)
        {
            DisplayPatients();
        }

        private void edycja_pacjenta_btn_Click(object sender, EventArgs e)
        {

        }

        private void usun_pacjenta_btn_Click(object sender, DataGridViewRowEventArgs e)
        {

       /*     DataGridViewSelectedRowCollection rows = dataGridView4.Rows
            int ID_pacjenta = Convert.ToInt64(dataGridView4.SelectedRows.
       int customerID = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].DataKeys[e.RowIndex].Value);
       using (RMEntities context = new RMEntities())
       {
           Pacjenci1 obj = context.Pacjenci1.First(x=>x.CustomerID == customerID);
           context.Pacjenci1.Remove(obj);
           context.SaveChanges();
           BindGrid();
           lblMessage.Text = "Deleted successfully.";*/
       }

        private void dod_lekarza_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void odswiez_lekarz_btn_Click(object sender, EventArgs e)
        {
            DisplayDoctors();
        }     

        }






    }

