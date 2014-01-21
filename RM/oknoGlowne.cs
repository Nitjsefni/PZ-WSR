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
        oknoEdycjaKaretki form_karetka = new oknoEdycjaKaretki();

        public oknoGlowne()
        {
            InitializeComponent();
            DisplayPatients();
            DisplayDoctors();
            DisplayAmbulance();
        }

        public void DisplayPatients()
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

                pacjenci_dataGrid.DataSource = patients.ToList();
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

                lekarze_dataGrid.DataSource = doctors.ToList();
            }
        }

       private void DisplayAmbulance()
        {
            using (var dc = new RMEntities())
            {
                var ambulance = from c in dc.Karetkas
                              select new
                              {
                                  ID_karetki = c.ID_karetki,
                                  typ_numer = c.typ_numer,
                                  //ID_skladu_karetka = c.ID_skladu,
                                  wyposazenie_karetki = c.wyposazenie,
                                  uwagi  = c.uwagi

                              };

                karetki_dataGrid.DataSource = ambulance.ToList();
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

        private void DastaGrid_RightClick(object sender, MouseEventArgs e)
        {


        }

        private void pacjenci_dataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                pacjenci_dataGrid.Rows[Convert.ToInt32(e.RowIndex.ToString())].Selected = true;
                long pesel = Convert.ToInt64(pacjenci_dataGrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());

                oknoEdycjaPacjenta oEdycjaPacjenta = new oknoEdycjaPacjenta(pesel);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dod_rat_Click(object sender, EventArgs e)
        {

        }




        private void lekarze_dataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                lekarze_dataGrid.Rows[Convert.ToInt32(e.RowIndex.ToString())].Selected = true;
                long ID_lekarza = Convert.ToInt64(lekarze_dataGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());

                oknoEdycjaLekarza oEdycjaPacjenta = new oknoEdycjaLekarza(ID_lekarza);
            }
        }

        private void dod_karetke_Click(object sender, EventArgs e)
        {
            form_karetka.Show();
        }

        private void refresh_karetka_Click(object sender, EventArgs e)
        {
            DisplayAmbulance();
        }


        private void karetki_dataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
               karetki_dataGrid.Rows[Convert.ToInt32(e.RowIndex.ToString())].Selected = true;
                long ID_karetki = Convert.ToInt64(karetki_dataGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());

                oknoEdycjaKaretki oEdycjaKaretki= new oknoEdycjaKaretki(ID_karetki);
            }
        }
    }
}




