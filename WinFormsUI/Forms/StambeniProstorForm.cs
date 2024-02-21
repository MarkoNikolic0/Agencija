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

public partial class StambeniProstorForm : Form
{
    string? Id = null;
    public StambeniProstorForm()
    {
        InitializeComponent();
    }

    public StambeniProstorForm(string id)
    {
        InitializeComponent();
        this.Id = id;
    }

    private void btnPrikaziStambeniProstor_Click(object sender, EventArgs e)
    {
        popuniPodacima();
    }
    public async void popuniPodacima()
    {

        listView1.Items.Clear();
        List<StambeniProstorPregled> podaci = await DTOManager.VratiStambeniProstor(Id!);

        foreach (StambeniProstorPregled z in podaci)
        {
            ListViewItem item = new ListViewItem(new string[] { z.Id, z.BrojSprata.ToString() });
            listView1.Items.Add(item);

        }

        listView1.Refresh();
    }

    private void btnDodajStambeniProstor_Click(object sender, EventArgs e)
    {
        StambeniProstorDodajForm form = new StambeniProstorDodajForm(Id!);
        form.ShowDialog();
        this.popuniPodacima();
    }

    private void btnDodajStan_Click(object sender, EventArgs e)
    {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite stambeni prostor gde zelite da dodate stan");
                return;
            }
            string idProstora = listView1.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da dodate stan?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                StanoviDodajForm form = new StanoviDodajForm(idProstora);
                form.ShowDialog();
            }
    }
}
