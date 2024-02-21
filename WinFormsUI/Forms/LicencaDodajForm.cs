using Projekat.Entiteti;
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
    public partial class LicencaDodajForm : Form
    {
        LicencaBasic licenca = new LicencaBasic();
        public LicencaDodajForm()
        {
            InitializeComponent();
        }

        public LicencaDodajForm(LicencaBasic licenca)
        {
            InitializeComponent();
            this.licenca = licenca;
        }

        private async void btnDodajLicencu_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu licencu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                licenca.BrojLicence = brojLicenceTb.Text;
                licenca.Institucija = nazivInstitucijeTb.Text;

                MessageBox.Show(await DTOManager.SacuvajLicencuAsync(licenca));
                this.Close();
            }
            else
            {
            }
        }

        private void LicencaDodajForm_Load(object sender, EventArgs e)
        {

        }
    }
}
