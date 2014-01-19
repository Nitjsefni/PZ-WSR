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
    public partial class dod_lekarza : Form
    {
        public dod_lekarza()
        {
            InitializeComponent();
        }



        private void dod_lekarza_okno_Click(object sender, EventArgs e)
        {
            using (RMEntities ctx = new RMEntities())
            {

                //Create new Emp object
                
                Personel1 d = new Personel1()
                {
                    ID_lekarz = Convert.ToInt64(ID_box.Text),
                    imie = imie_box.Text,
                    nazwisko = nazw_box.Text, 
                    stanowisko = stanowisko_box.Text,
                    specjalizacja = specj_box.Text
                    

                };



                //Add to memory



                ctx.Personel1.Add(d);


                //Save to database

                ctx.SaveChanges();

                dod_lekarza.ActiveForm.Close();
            }
        }
    }
}
