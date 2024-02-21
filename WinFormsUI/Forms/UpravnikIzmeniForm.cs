using Projekat;
using Projekat.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI.Forms
{
    public partial class UpravnikIzmeniForm : Form
    {
        UpravnikPregled upravnik = new UpravnikPregled();
        public UpravnikIzmeniForm()
        {
            InitializeComponent();
        }

        public UpravnikIzmeniForm(UpravnikPregled upravnik)
        {
            InitializeComponent();

            this.upravnik=upravnik;
            tbJMBG.Text = upravnik.JMBG;
            tbIme.Text= upravnik.Ime;
            tbImeRoditelja.Text = upravnik.ImeRoditelja;
            tbPrezime.Text= upravnik.Prezime;
            tbDatumRodjenja.Text = upravnik.DatumRodjenja.ToString();
            tbBrLk.Text = upravnik.BrojLk;
            tbMestoIzdavanja.Text = upravnik.MestoIzdavanja;
            tbBrTel.Text = upravnik.BrTel;
            tbAdresa.Text = upravnik.Adresa;
            tbInstitucija.Text = upravnik.Institucija;
            tbZvanje.Text = upravnik.Zvanje;
            tbDatumSticanja.Text = upravnik.DatumSticanja.ToString();
        }

        private void UpravnikIzmeniForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene upravnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            { 
                this.upravnik.JMBG = tbJMBG.Text;
                this.upravnik.Ime = tbIme.Text;
                this.upravnik.ImeRoditelja = tbImeRoditelja.Text;
                this.upravnik.Prezime = tbPrezime.Text;
                this.upravnik.DatumRodjenja = DateTime.Parse(tbDatumRodjenja.Text);
                this.upravnik.BrojLk = tbBrLk.Text;
                this.upravnik.MestoIzdavanja = tbMestoIzdavanja.Text;
                this.upravnik.BrTel = tbBrTel.Text;
                this.upravnik.Adresa = tbAdresa.Text;
                this.upravnik.Institucija = tbInstitucija.Text;
                this.upravnik.Zvanje = tbZvanje.Text;
                this.upravnik.DatumSticanja = DateTime.Parse(tbDatumSticanja.Text);

                await DTOManager.IzmeniUpravnikaAsync(this.upravnik.Map2());
                MessageBox.Show("Azuriranje upravnika je uspesno izvrseno!");
            }
            
            
        }
    }
}
