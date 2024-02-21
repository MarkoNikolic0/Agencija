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
    public partial class StanoviDodajForm : Form
    {
        StanBasic stan=new StanBasic();
        string? idProstora = null;

        public StanoviDodajForm()
        {
            InitializeComponent();
        }

        public StanoviDodajForm(string idProstora)
        {
            InitializeComponent();
            this.idProstora = idProstora;
        }

        private async void btnDodajStan_Click(object sender, EventArgs e)
        {
            stan.BrojStana = int.Parse(brojStanaTb.Text);
            stan.Povrsina = int.Parse(PovrsinaTb.Text);

            MessageBox.Show(await DTOManager.SacuvajStanAsync(stan, idProstora!));
        }
    }
}
