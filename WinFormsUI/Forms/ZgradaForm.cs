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

public partial class ZgradaForm : Form
{
    string? idZgrade;
    public ZgradaForm()
    {
        InitializeComponent();
    }
    public ZgradaForm(string idZgrade)
    {
        InitializeComponent();
        this.idZgrade = idZgrade;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite zgradu koju zelite da obrisete!");
            return;
        }

        string idZgrade = listView1.SelectedItems[0].SubItems[0].Text;
        string poruka = "Da li zelite da obrisete izabranu zgradua?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            DTOManager.ObrisiZgradu(idZgrade);
            MessageBox.Show("Brisanje prodavnice je uspesno obavljeno!");
            this.popuniPodacima();
        }
        else
        {
        }
    }

    private void btnPrikaziZgrade_Click(object sender, EventArgs e)
    {
        popuniPodacima();
    }

    public async void popuniPodacima()
    {
        listView1.Items.Clear();
        List<ZgradaPregled> podaci = await DTOManager.VratiZgrade();

        foreach (ZgradaPregled z in podaci)
        {
            ListViewItem item = new ListViewItem(new string[] { z.Id, z.Adresa });
            listView1.Items.Add(item);

        }

        listView1.Refresh();
    }

    private void btnDodajZgradu_Click(object sender, EventArgs e)
    {
        ZgradaDodajForm form = new ZgradaDodajForm();
        form.ShowDialog();
        this.popuniPodacima();
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private async void btnLiftovi_ClickAsync(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite zgradu cije liftove zelite da vidite");
            return;
        }

        string idZgrade = listView1.SelectedItems[0].SubItems[0].Text;
        ZgradaPregled p = await DTOManager.VratiZgradu(idZgrade);
        LiftoviForm forma = new LiftoviForm(idZgrade);
        forma.ShowDialog();
    }

    private async void btnUlazi_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite zgradu cije ulaze zelite da vidite");
            return;
        }

        string idZgrade = listView1.SelectedItems[0].SubItems[0].Text;
        ZgradaPregled p = await DTOManager.VratiZgradu(idZgrade);
        UlaziForm forma = new UlaziForm(idZgrade);
        forma.ShowDialog();
    }

    private async void btnStanovi_ClickAsync(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite zgradu cije stanove zelite da vidite");
            return;
        }

        string idZgrade = listView1.SelectedItems[0].SubItems[0].Text;
        ZgradaPregled p = await DTOManager.VratiZgradu(idZgrade);
        StanoviForm forma = new StanoviForm(idZgrade);
        forma.ShowDialog();
    }

    private async void btnParkingMesta_ClickAsync(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite zgradu cija parking mesta zelite da vidite");
            return;
        }

        string idZgrade = listView1.SelectedItems[0].SubItems[0].Text;
        ZgradaPregled p = await DTOManager.VratiZgradu(idZgrade);
        ParkingMestaForm forma = new ParkingMestaForm(idZgrade);
        forma.ShowDialog();
    }

    private async void btnLokali_ClickAsync(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite zgradu cije lokale zelite da vidite");
            return;
        }

        string idZgrade = listView1.SelectedItems[0].SubItems[0].Text;
        ZgradaPregled p = await DTOManager.VratiZgradu(idZgrade);
        LokaliForm forma = new LokaliForm(idZgrade);
        forma.ShowDialog();
    }

    private async void btnStambeniProstor_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite zgradu cije stambene prostore zelite da vidite");
            return;
        }

        string idZgrade = listView1.SelectedItems[0].SubItems[0].Text;
        ZgradaPregled p = await DTOManager.VratiZgradu(idZgrade);
        StambeniProstorForm forma = new StambeniProstorForm(idZgrade);
        forma.ShowDialog();
    }

    private async void btnPoslovniProstor_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite zgradu cije poslovne prostore zelite da vidite");
            return;
        }

        string idZgrade = listView1.SelectedItems[0].SubItems[0].Text;
        ZgradaPregled p = await DTOManager.VratiZgradu(idZgrade);
        PoslovniProstorForm forma = new PoslovniProstorForm(idZgrade);
        forma.ShowDialog();
    }

    private void btnGaraza_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite zgradu cije garaze zelite da vidite");
            return;
        }

        string idZgrade = listView1.SelectedItems[0].SubItems[0].Text;
        GarazaForm forma = new GarazaForm(idZgrade);
        forma.ShowDialog();
    }
}
