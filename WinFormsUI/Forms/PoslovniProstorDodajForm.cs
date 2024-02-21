using Projekat;
using Projekat.Entiteti;
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
    public partial class PoslovniProstorDodajForm : Form
    {
        PoslovniProstorBasic poslovniProstor = new PoslovniProstorBasic();
        string? idZgrade = null;

        public PoslovniProstorDodajForm(PoslovniProstorBasic poslovniProstor)
        {
            InitializeComponent();
            this.poslovniProstor = poslovniProstor;
            idZgrade = this.poslovniProstor.Zgrada.Id;
        }

        public PoslovniProstorDodajForm(string idZgrade)
        {
            InitializeComponent();
            this.idZgrade = idZgrade;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi poslovni prostor?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                poslovniProstor.RedniBroj = int.Parse(redniBrojProstoraTb.Text);

                MessageBox.Show(await DTOManager.SacuvajPoslovniProstorAsync(this.poslovniProstor, idZgrade!));
                this.Close();
            }
            else
            {
            }
        }
    }
}
