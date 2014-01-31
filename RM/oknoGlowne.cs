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
        oknoEdycjaWypadek form_wypadek = new oknoEdycjaWypadek();

        public oknoGlowne()
        {
            InitializeComponent();
            DisplayPatients();
            DisplayDoctors();
            DisplayAmbulance();
            DisplayAccident();
        }

        public void DisplayPatients()
        {
            using (var dc = new RMEntities())
            {
                var patients = from p in dc.Pacjenci1
                               join l in dc.Personel1 on p.ID_lekarz equals l.ID_lekarz
                               select new
                               {

                                   pesel_pacjenta = p.PESEL,
                                   imie_pacjenta = p.imie,
                                   nazwisko_pacjenta = p.nazwisko,
                                   numer_ubezpieczenia_pacj = p.nr_ubezpieczenia,
                                   data_przyjecia_pacj = p.data_przyjecia,
                                   miejscowosc_pacj = p.miejscowosc,
                                   kod_pocz_pacj = p.kod_pocztowy,
                                   ulica_pacj = p.ulica,
                                   opis_pacj = p.opis,
                                   uwagi_pacj = p.uwagi,
                                   lekarz_pacjenta = l.imie + " " + l.nazwisko

                               };

                pacjenci_dataGrid.DataSource = patients.ToList();
            }
        }
        private void wyszukaj_pacjenta_btn_Click(object sender, EventArgs e)
        {
            string Str = wyszukaj_pacjenta_box.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {
                long pesel = Convert.ToInt64(wyszukaj_pacjenta_box.Text);
                szukaj_pacjenta(pesel);
            }
            else
                MessageBox.Show("Pesel powinien być numerem");
            
        }
        

        
        
        private void szukaj_pacjenta(long pesel)
        {
            using (var dc = new RMEntities())
            {

                var patients = from p in dc.Pacjenci1
                               join l in dc.Personel1 on p.ID_lekarz equals l.ID_lekarz
                               where p.PESEL == pesel
                               select new
                               {

                                   pesel_pacjenta = p.PESEL,
                                   imie_pacjenta = p.imie,
                                   nazwisko_pacjenta = p.nazwisko,
                                   numer_ubezpieczenia_pacj = p.nr_ubezpieczenia,
                                   data_przyjecia_pacj = p.data_przyjecia,
                                   miejscowosc_pacj = p.miejscowosc,
                                   kod_pocz_pacj = p.kod_pocztowy,
                                   ulica_pacj = p.ulica,
                                   opis_pacj = p.opis,
                                   uwagi_pacj = p.uwagi,
                                   lekarz_pacjenta = l.imie + " " + l.nazwisko

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
                                  ID_skladu_karetka = c.ID_skladu,
                                  wyposazenie_karetki = c.wyposazenie,
                                  uwagi  = c.uwagi

                              };

                karetki_dataGrid.DataSource = ambulance.ToList();
            }
        }

       private void DisplayAccident()
       {
           using (var dc = new RMEntities())
           {
               var accident = from c in dc.Wypadeks
                               select new
                               {
                                   id_wypadku = c.ID_wypadku,
                                   miejsce_wyp = c.miejsce_wypadku,
                                   liczba_rannych = c.liczba_rannych,
                                   data_zgloszenia = c.data_godz_zgl,
                                   typ_wypadku = c.typ_wypadku,
                                   numer_zglaszajacego = c.numer_zgl,
                                   uwagi_wypadek = c.uwagi
                               };

               wypadki_dataGrid.DataSource = accident.ToList();
           }
       }

        private void dod_pacj_Click(object sender, EventArgs e)
        {
            oknoEdycjaPacjenta form2 = new oknoEdycjaPacjenta();
            
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
            oknoEdycjaLekarza form3 = new oknoEdycjaLekarza();
            
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
                
                long pesel = Convert.ToInt64(pacjenci_dataGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

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
                long ID_lekarza = Convert.ToInt64(lekarze_dataGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

                oknoEdycjaLekarza oEdycjaPacjenta = new oknoEdycjaLekarza(ID_lekarza);
            }
        }

        private void dod_karetke_Click(object sender, EventArgs e)
        {
            oknoEdycjaKaretki form_karetka = new oknoEdycjaKaretki();
            
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

        private void dod_wyp_Click(object sender, EventArgs e)
        {
            oknoEdycjaWypadek form_wypadek = new oknoEdycjaWypadek();
            form_wypadek.Show();
        }

        private void wyp_refresh_Click(object sender, EventArgs e)
        {
            DisplayAccident();
        }
        private void wypadki_dataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                wypadki_dataGrid.Rows[Convert.ToInt32(e.RowIndex.ToString())].Selected = true;
                
                long ID_wypadku = Convert.ToInt64(wypadki_dataGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

                oknoEdycjaWypadek oEdycjaWypadek = new oknoEdycjaWypadek(ID_wypadku);
            }
        }
        // PACJENCI
        private void pacjenci_dataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (pacjenci_dataGrid.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                pacjenci_dataGrid.Rows[pacjenci_dataGrid.HitTest(e.X, e.Y).RowIndex].Selected = true;
            }

            if (e.Button == MouseButtons.Right && pacjenci_dataGrid.HitTest(e.X,e.Y).RowIndex >= 0)
            {
                rClickPacjenciDG.Show( pacjenci_dataGrid, new Point(e.X, e.Y) );
            }
        }

        private long zwrocPESELWybranegoPacjenta()
        {
            String cellValue = pacjenci_dataGrid.SelectedRows[0].Cells[0].FormattedValue.ToString();

            return Convert.ToInt64(cellValue);
        }

        private void menuPacjenci_edytujBtn_Click(object sender, EventArgs e)
        {
            oknoEdycjaPacjenta oEdycjaPacjenta = new oknoEdycjaPacjenta( zwrocPESELWybranegoPacjenta() );
        }

        private void menuPacjenci_usunBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult wynik = MessageBox.Show("Na pewno usunąć pacjenta o numerze PESEL: " + zwrocPESELWybranegoPacjenta() + "?", "Usuwanie pacjenta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (wynik == DialogResult.Yes)
            {
                using (RMEntities context = new RMEntities())
                {
                    long pesel = zwrocPESELWybranegoPacjenta();
                    Pacjenci1 pacjent = context.Pacjenci1.First(p => p.PESEL == pesel );
                    context.Pacjenci1.Remove(pacjent);
                    context.SaveChanges();
                    DisplayPatients();
                    
                }
            }
        }


        // LEKARZE
        private void lekarze_dataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (lekarze_dataGrid.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                lekarze_dataGrid.Rows[lekarze_dataGrid.HitTest(e.X, e.Y).RowIndex].Selected = true;
            }

            if (e.Button == MouseButtons.Right && lekarze_dataGrid.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                rClickLekarzeDG.Show(lekarze_dataGrid, new Point(e.X, e.Y));
            }
        }

        private long zwrocIDWybranegoLekarza()
        {
            String cellValue = lekarze_dataGrid.SelectedRows[0].Cells[0].FormattedValue.ToString();

            return Convert.ToInt64(cellValue);
        }

        private void MenuLekarze_EdytujBtn_Click(object sender, EventArgs e)
        {
            oknoEdycjaLekarza oEdycjaLekarza = new oknoEdycjaLekarza(zwrocIDWybranegoLekarza());
        }

        private void MenuLekarze_UsunBtn_Click(object sender, EventArgs e)
        {
            using (RMEntities context = new RMEntities())
            {
                long ID_lekarza = zwrocIDWybranegoLekarza();
                Personel1 lekarz = context.Personel1.First(p => p.ID_lekarz == ID_lekarza);

                DialogResult wynik = MessageBox.Show("Na pewno usunąć lekarza: " + lekarz.imie + " " + lekarz.nazwisko + "?", "Usuwanie lekarza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (wynik == DialogResult.Yes)
                {   
                    context.Personel1.Remove( lekarz );

                    // tu powinno być usuwanie z Pacjentów IDlekarza o lekarz.ID_lekarz
                    context.SaveChanges();
                    DisplayDoctors();
                }
            }
        }






    }
}
