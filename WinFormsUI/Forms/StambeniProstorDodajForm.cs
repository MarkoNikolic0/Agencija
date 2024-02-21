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

namespace WinFormsUI.Forms;

public partial class StambeniProstorDodajForm : Form
{
    StambeniProstorBasic stambeniProstor = new StambeniProstorBasic();
    string? idZgrade = null;

    public StambeniProstorDodajForm()
    {
        InitializeComponent();
    }

    public StambeniProstorDodajForm(StambeniProstorBasic stambeniProstor)
    {
        InitializeComponent();
        this.stambeniProstor = stambeniProstor;
        idZgrade = this.stambeniProstor.Zgrada.Id;
    }
    public StambeniProstorDodajForm(string idZgrade)
    {
        InitializeComponent();
        this.idZgrade = idZgrade;
    }

    private async void btnDodaj_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novi stambeni prostor?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            stambeniProstor.BrojSprata = int.Parse(brojSprataTb.Text);

            MessageBox.Show(await DTOManager.SacuvajStambeniProstorAsync(this.stambeniProstor, idZgrade!));
            this.Close();
        }
        else
        {
        }
    }
}
