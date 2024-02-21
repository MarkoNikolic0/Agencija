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
    public partial class LiftDodajForm : Form
    {
        LiftBasic lift = new LiftBasic();
        string? idZgrade = null;
        public LiftDodajForm()
        {
            InitializeComponent();
        }

        public LiftDodajForm(LiftBasic lift)
        {
            InitializeComponent();
            this.lift = lift;

        }
        public LiftDodajForm(string idZgrade)
        {
            InitializeComponent();
            this.idZgrade = idZgrade;
        }

        private async void btnDodajLift_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi lift?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.lift.SerijskiBroj = serijskiBrojTb.Text;
                this.lift.Proizvodjac = proizvodjacTb.Text;
                this.lift.BrojOsoba = int.Parse(brojOsobaTb.Text);
                this.lift.Tip = tipTb.Text;
                this.lift.Nosivost = int.Parse(nosivostTb.Text);
                this.lift.DatumServisiranja = DateTime.Now.AddDays(10);
                this.lift.DatumKvara = DateTime.Now;
                this.lift.DaniVanUpotrebe = (int)(this.lift.DatumServisiranja - this.lift.DatumKvara).TotalDays;

                await DTOManager.SacuvajLiftAsync(this.lift, idZgrade!);
                MessageBox.Show("Uspesno ste sacuvali novi lift");
            }
            else
            {

            }
        }
    }
}
