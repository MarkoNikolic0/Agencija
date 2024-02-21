using Projekat;
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
    public partial class UpravnikDodajForm : Form
    {
        UpravnikBasic upravnik = new UpravnikBasic();
        public UpravnikDodajForm()
        {
            InitializeComponent();
        }

        public UpravnikDodajForm(UpravnikBasic upravnik)
        {
            InitializeComponent();
            this.upravnik = upravnik;
        }

        private async void btnDodaj_Click_1(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog upravnika?";
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
                string licencaId = tbLicencaId.Text;

                await DTOManager.SacuvajUpravnikaAsync(this.upravnik, licencaId);
                MessageBox.Show("Uspesno ste sacuvali novog upravnika");
                this.Close();
            }
            else
            {

            }
        }

        private void UpravnikDodajForm_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbLicencaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tbDatumSticanja_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbZvanje_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ImeRoditelja_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbInstitucija_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBrTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMestoIzdavanja_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDatumRodjenja_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBrLk_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbImeRoditelja_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbJMBG_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblJMBG_Click(object sender, EventArgs e)
        {

        }
    }
}
