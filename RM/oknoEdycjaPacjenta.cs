﻿using System;
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
        private Pacjenci1 edytowanyPacjent;

        public oknoEdycjaPacjenta()
        {
            InitializeComponent();
            inicjalizujLekarzy();

            edytowanyPacjent = new Pacjenci1();
        }
        
        public oknoEdycjaPacjenta(long PESEL)
        {
            InitializeComponent();
            inicjalizujLekarzy();
            this.Show();

            using(var ctx = new RMEntities())
            {
                edytowanyPacjent = ctx.Pacjenci1.SingleOrDefault(c => c.PESEL == PESEL);
                
                zaladujWartosciDoBoxow();

                this.dod_pacjentaBtn.Text = "Edytuj";

                this.dod_pacjentaBtn.Click -= new System.EventHandler( this.dodajPacjenta_Click );
                this.dod_pacjentaBtn.Click += new System.EventHandler( this.edytujPacjenta_Click );
            }
        }

        public void inicjalizujLekarzy()
        {
            using (var ctx = new RMEntities())
            {
                lekarz_cbox.DataSource = ctx.Personel1.ToList();
                lekarz_cbox.ValueMember = "ID_lekarz";
                lekarz_cbox.DisplayMember = "nazwisko";
            }
        }

        public oknoGlowne zwrocOknoGlowne()
        {
            oknoGlowne og = this.Owner as oknoGlowne;
            return og;
        }

        public void zaladujWartosciZBoxow()
        {
            DateTime date = data_przyj_pick.Value;

            edytowanyPacjent.PESEL              = Convert.ToInt64(pesel_box.Text); 
            edytowanyPacjent.imie               = imie_box.Text;
            edytowanyPacjent.nazwisko           = nazwisko_box.Text;
            edytowanyPacjent.data_przyjecia     = date;
            edytowanyPacjent.miejscowosc        = miejscowosc_box.Text;
            edytowanyPacjent.kod_pocztowy       = kod_pocz_box.Text;
            edytowanyPacjent.nr_ubezpieczenia   = Convert.ToInt32(nr_ubez_box.Text); 
            edytowanyPacjent.ulica              = ulica_box.Text;
            edytowanyPacjent.opis               = opis_box.Text;

            if(lekarz_cbox.SelectedIndex >= 0)
            {
                edytowanyPacjent.ID_lekarz= Convert.ToInt64(lekarz_cbox.SelectedValue);
            }
            else
            {
                edytowanyPacjent.ID_lekarz = null;
            }
        }

        public void zaladujWartosciDoBoxow()
        {
            DateTime date = new DateTime();
            
            pesel_box.Text          = edytowanyPacjent.PESEL.ToString();
            imie_box.Text           = edytowanyPacjent.imie;
            nazwisko_box.Text       = edytowanyPacjent.nazwisko;
            miejscowosc_box.Text    = edytowanyPacjent.miejscowosc;
            nr_ubez_box.Text        = edytowanyPacjent.nr_ubezpieczenia.ToString();
            kod_pocz_box.Text       = edytowanyPacjent.kod_pocztowy;
            date                    = edytowanyPacjent.data_przyjecia;
            data_przyj_pick.Value   = date;
            opis_box.Text           = edytowanyPacjent.opis;
            ulica_box.Text          = edytowanyPacjent.ulica;
            opis_box.Text           = edytowanyPacjent.opis;
            if (edytowanyPacjent.ID_lekarz > 0) lekarz_cbox.SelectedValue = edytowanyPacjent.ID_lekarz;
        }

        private void edytujPacjenta_Click(object sender, EventArgs e)
        {
            zaladujWartosciZBoxow();

            using (RMEntities ctx = new RMEntities())
            {
                ctx.Pacjenci1.Attach(edytowanyPacjent);
                ctx.Entry(edytowanyPacjent).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            
            oknoEdycjaPacjenta.ActiveForm.Close();
        }

        private void dodajPacjenta_Click(object sender, EventArgs e)
        {
            zaladujWartosciZBoxow();

            using (RMEntities ctx = new RMEntities())
            {
                ctx.Pacjenci1.Add(edytowanyPacjent);
                ctx.SaveChanges();

                oknoEdycjaPacjenta.ActiveForm.Close();
            }
        }

    }
}
