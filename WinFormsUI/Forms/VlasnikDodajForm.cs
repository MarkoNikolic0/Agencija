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
    public partial class VlasnikDodajForm : Form
    {
        VlasnikBasic vlasnik=new VlasnikBasic();
        string? idStana=null;

        public VlasnikDodajForm()
        {
            InitializeComponent();
        }

        public VlasnikDodajForm(string idStana)
        {
            InitializeComponent();
            this.idStana = idStana;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            vlasnik.JMBG = jmbgTb.Text;
            vlasnik.Ime=imeTb.Text;
            vlasnik.ImeRoditelja=imeRoditeljatb.Text;
            vlasnik.Prezime=prezimeTb.Text;
            vlasnik.Adresa=adresaTb.Text;
            vlasnik.BrojTelefona=brojTelefonaTb.Text;
            vlasnik.Funkcija=funkcijaTb.Text;

            MessageBox.Show(await DTOManager.SacuvajVlasnikaAsync(vlasnik,idStana!));
        }
    }
}
