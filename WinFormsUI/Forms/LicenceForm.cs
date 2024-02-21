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

public partial class LicenceForm : Form
{
    public LicenceForm()
    {
        InitializeComponent();
    }

    private void btnDodajLicencu_Click(object sender, EventArgs e)
    {
        LicencaDodajForm form = new LicencaDodajForm();
        form.ShowDialog();
        this.popuniPodacima();
    }

    private void btnPrikaziLicence_Click(object sender, EventArgs e)
    {
        popuniPodacima();
    }

    public async void popuniPodacima()
    {
        listView1.Items.Clear();
        List<LicencaPregled> podaci = await DTOManager.VratiLicence();

        foreach (LicencaPregled z in podaci)
        {
            ListViewItem item = new ListViewItem(new string[] { z.Id, z.BrojLicence, z.Institucija, z.DatumSticanja.ToString()});
            listView1.Items.Add(item);
        }
        listView1.Refresh();
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
