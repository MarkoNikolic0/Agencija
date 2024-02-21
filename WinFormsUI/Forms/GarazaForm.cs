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
    public partial class GarazaForm : Form
    {
        string? Id = null;
        public GarazaForm()
        {
            InitializeComponent();
        }
        public GarazaForm(string id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnDodajGarazu_Click(object sender, EventArgs e)
        {
            GarazaDodajForm form = new GarazaDodajForm(Id!);
            form.ShowDialog();
            this.popuniPodacima();
        }

        private void btnPrikaziGarazu_Click(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public async void popuniPodacima()
        {
            listView1.Items.Clear();
            List<GarazaPregled> podaci = await DTOManager.VratiGarazu(Id!);

            foreach (GarazaPregled z in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { z.Id, z.RedniBroj.ToString() });
                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }
    }
}
