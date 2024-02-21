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

public partial class VlasnikForm : Form
{
    string? Id = null;
    public VlasnikForm()
    {
        InitializeComponent();
    }

    public VlasnikForm(string id)
    {
        InitializeComponent();
        this.Id = id;
    }
    private async void VlasnikForm_Load(object sender, EventArgs e)
    {
        VlasnikPregled vlasnik = new VlasnikPregled();

        try
        {
            vlasnik = await DTOManager.VratiVlasnikaPremaStanu(Id!);

            ListViewItem item = new ListViewItem(new string[] { vlasnik.Ime, vlasnik.Prezime, vlasnik.BrojTelefona, vlasnik.Funkcija });
            listView1.Items.Add(item);

            listView1.Refresh();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }


}
