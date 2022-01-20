using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KreditniKalkulatorTrackBar
{
    

    public partial class frmMain : Form
    {
        double mjesecnaRata = 0;
        double ukupnoZaduzenje = 0;
        double ukupnaKamata = 0;
        double kamatnaStopa = 0;
        
        public frmMain()
        {
            InitializeComponent();
            //Kada se pokrene program Min i Max vrijednosti se učitaju iz Settings-a
            PostaviTrackBar();
            //U tekstualno polje se upiše vrijednost na kojoj se nalazi klizač
            txtIznosKredita.Text = trbIznosKredita.Value.ToString();
            txtBrojMjeseci.Text = trbBrojMjeseci.Value.ToString();
            rdbOdlican.Checked = true;
            //Postavljanje sata nakon startovanja programa
            lblSat.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Postavljanje sata nakon otkucaja sata
            lblSat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //Promjena vrijednosti na klizaču Iznos kredita
        private void trbIznosKredita_Scroll(object sender, EventArgs e)
        {
            txtIznosKredita.Text = trbIznosKredita.Value.ToString();
            postaviLabele();
        }

        //Promjena vrijednosti na klizaču broj mjeseci
        private void trbBrojMjeseci_Scroll(object sender, EventArgs e)
        {
            txtBrojMjeseci.Text = trbBrojMjeseci.Value.ToString();
            postaviLabele();
        }

        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbOdlican_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOdlican.Checked)
                kamatnaStopa = 3d;
            postaviLabele();
        }

        private void rdbDobar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDobar.Checked)
                kamatnaStopa = 5d;
            postaviLabele();
        }

        private void rdbLos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLos.Checked)
                kamatnaStopa = 6d;
            postaviLabele();
        }
        //Funkcija za izračunavanje kamate
        double IzracunajRatu(int ukupanIznosKredita, int brojMjeseci, double kamatnaStopa)
        {
            double kamata = kamatnaStopa / 1200;
            double stepen = Math.Pow((1 + kamata), brojMjeseci);
            mjesecnaRata = ukupanIznosKredita * kamata * (stepen) / (stepen - 1);
            return mjesecnaRata;
        }
        //Funkcija za izračunavanje Ukupnog Zaduzenja
        double izracunajUkupnoZaduzenje(int brojMjeseci, double mjesecnaRata)
        {
            return ukupnoZaduzenje = brojMjeseci * mjesecnaRata;
        }
        //Funkcija za izračunavanje ukupne kamate
        double izracunajKamatu(double ukupnoZaduzenje, double ukupanIznosKredita)
        {
            return ukupnaKamata = ukupnoZaduzenje - ukupanIznosKredita;
        }
        //Poziv funkcija za izračunavanje podataka i postavljanje vrijednosti na labele
        private void postaviLabele()
        {
            mjesecnaRata = IzracunajRatu(trbIznosKredita.Value, trbBrojMjeseci.Value, kamatnaStopa);
            lblIzosRate.Text = mjesecnaRata.ToString("C", CultureInfo.CreateSpecificCulture("ba-BA"));
            ukupnoZaduzenje = izracunajUkupnoZaduzenje(trbBrojMjeseci.Value, mjesecnaRata);
            lblUkupnoZaduzenje.Text = ukupnoZaduzenje.ToString("C", CultureInfo.CreateSpecificCulture("ba-BA"));
            ukupnaKamata = izracunajKamatu(ukupnoZaduzenje, (double)trbIznosKredita.Value);
            lblUkupnoKamate.Text = ukupnaKamata.ToString("C", CultureInfo.CreateSpecificCulture("ba-BA"));
        }

        //Podešavanje Min i Max vrijednosti na TrackBar-u iz podešavanja
        private void PostaviTrackBar()
        {
            trbBrojMjeseci.Minimum = Properties.Settings.Default.minBrojMjeseci;
            trbBrojMjeseci.Maximum = Properties.Settings.Default.maxBrojMjeseci;
            trbIznosKredita.Minimum = Properties.Settings.Default.minUkupanIznosKredita;
            trbIznosKredita.Maximum = Properties.Settings.Default.maxUkupanIznosKredita;
        }

        private void podešavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kreira se instanca nove forme i poziva se nova forma
            frmSettings formaPodesavanja = new frmSettings();
            formaPodesavanja.ShowDialog();

            //Ako je dialogResult sa forme Podešavanja == OK, postavlja se TrackBar
            if (formaPodesavanja.DialogResult == DialogResult.OK)
                PostaviTrackBar();
        }
    }
}
