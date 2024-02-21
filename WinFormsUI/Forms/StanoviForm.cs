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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsUI.Forms;

public partial class StanoviForm : Form
{
    StanBasic stan = new StanBasic();
    string? Id = null;
    public StanoviForm()
    {
        InitializeComponent();
    }

    public StanoviForm(string id)
    {
        InitializeComponent();
        this.Id = id;
    }


    private async void StanoviForm_Load(object sender, EventArgs e)
    {
        List<StanPregled> stanovi = new List<StanPregled>();

        try
        {
            stanovi = await DTOManager.vratiStanoveZgrade(Id!);

            foreach (StanPregled o in stanovi)
            {
                if (o.Vlasnik != null)
                {
                    ListViewItem item = new ListViewItem(new string[] {o.Id,o.BrojStana.ToString(),
                    o.Povrsina.ToString(), o.Vlasnik.Ime.ToString()!,o.Vlasnik.Prezime.ToString()!, o.StambeniProstor.BrojSprata.ToString() });
                    listView1.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[] {o.Id,o.BrojStana.ToString(),
                    o.Povrsina.ToString(), null!,null!, o.StambeniProstor.BrojSprata.ToString() });
                    listView1.Items.Add(item);
                }
            }
            listView1.Refresh();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnPrikaziVlasnika_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite stan cijeg vlasnika zelite da vidite");
            return;
        }

        string idStana = listView1.SelectedItems[0].SubItems[0].Text;
        /*ZgradaPregled p = await DTOManager.VratiZgradu(idZgrade);*/
        VlasnikForm forma = new VlasnikForm(idStana);
        forma.ShowDialog();
    }

    private async void btnObrisiStan_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite stan koji zelite da obrisete!");
            return;
        }

        string idStana = listView1.SelectedItems[0].SubItems[0].Text;
        string poruka = "Da li zelite da obrisete izabrani stan?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            await DTOManager.ObrisiStanAsync(idStana);
            MessageBox.Show("Brisanje stana je uspesno obavljeno!");

            listView1.Refresh();
        }
        else
        { }
    }

    private void btnDodajVlasnika_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite stan kome zelite da dodate vlasnika!");
            return;
        }

        string idStana = listView1.SelectedItems[0].SubItems[0].Text;
        string poruka = "Da li zelite da dodate vlasnika?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            VlasnikDodajForm form = new VlasnikDodajForm(idStana);
            form.ShowDialog();
            listView1.Refresh();
        }
        else
        { }
    }

    
}
