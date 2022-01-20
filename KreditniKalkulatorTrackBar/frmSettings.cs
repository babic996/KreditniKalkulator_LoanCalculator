using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KreditniKalkulatorTrackBar
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            txtMinIznosKredita.Text = Properties.Settings.Default.minUkupanIznosKredita.ToString();
            txtMaxIznosKredita.Text = Properties.Settings.Default.maxUkupanIznosKredita.ToString();
            txtMinBrojMjeseci.Text = Properties.Settings.Default.minBrojMjeseci.ToString();
            txtMaxBrojMjeseci.Text = Properties.Settings.Default.maxBrojMjeseci.ToString();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            //Provjerava se da li je Max vrijednost > Min vrijednosti
            if (Int32.Parse(txtMaxIznosKredita.Text) < Int32.Parse(txtMinIznosKredita.Text))
                MessageBox.Show("Minimalna vrijednost za iznos kredita ne može biti veća od maksimalne!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Int32.Parse(txtMaxBrojMjeseci.Text) < Int32.Parse(txtMinBrojMjeseci.Text))
                MessageBox.Show("Minimalna vrijednost za broj mjeseci ne može biti veća od maksimalne!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
            { 
                try
                {
                    //Zadate vrijednosti u TextBoxovima se upisuju u Settings
                    Properties.Settings.Default.minUkupanIznosKredita = Int32.Parse(txtMinIznosKredita.Text);
                    Properties.Settings.Default.maxUkupanIznosKredita = Int32.Parse(txtMaxIznosKredita.Text);
                    Properties.Settings.Default.minBrojMjeseci = Int32.Parse(txtMinBrojMjeseci.Text);
                    Properties.Settings.Default.maxBrojMjeseci = Int32.Parse(txtMaxBrojMjeseci.Text);
                    //Snimaju se podešavanja kako bi se učitala nakon ponovnog pokretanja aplikacije
                    Properties.Settings.Default.Save();
                    //Postavlja se DialogResult na OK, čime se i zatvara forma
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Morate unijeti cjelobrojne vrijednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
