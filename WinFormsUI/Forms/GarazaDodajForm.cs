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
    public partial class GarazaDodajForm : Form
    {
        GarazaBasic garaza = new GarazaBasic();
        string? idZgrade = null;

        public GarazaDodajForm()
        {
            InitializeComponent();
        }

        public GarazaDodajForm(GarazaBasic garaza)
        {
            InitializeComponent();
            this.garaza = garaza;
            idZgrade = this.garaza.Zgrada.Id;
        }
        public GarazaDodajForm(string idZgrade)
        {
            InitializeComponent();
            this.idZgrade = idZgrade;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi garazni prostor?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                garaza.RedniBroj = int.Parse(redniBrojTb.Text);

                MessageBox.Show(await DTOManager.SacuvajGarazuAsync(this.garaza, idZgrade!));
                this.Close();
            }
            else
            {
            }
        }
    }
}
