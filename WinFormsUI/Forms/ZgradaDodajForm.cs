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

namespace WinFormsUI.Forms;

public partial class ZgradaDodajForm : Form
{
    ZgradaBasic zgrada = new ZgradaBasic();
    public ZgradaDodajForm()
    {
        InitializeComponent();
    }

    public ZgradaDodajForm(ZgradaBasic zgrada)
    {
        InitializeComponent();
        this.zgrada = zgrada;
    }

    private async void btnDodajZgradu_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novu zgradu?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            zgrada.Adresa = tbAdresa.Text;
            
            MessageBox.Show(await DTOManager.SacuvajZgraduAsync(this.zgrada, tbUpravnikId.Text/*, tbUgovorId.Text*/));
            this.Close();
        }
        else
        {
        }
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void ZgradaDodajForm_Load(object sender, EventArgs e)
    {

    }
}
