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
    public partial class PoslovniProstorForm : Form
    {
        string? Id = null;
        public PoslovniProstorForm()
        {
            InitializeComponent();
        }

        public PoslovniProstorForm(string id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnPrikaziPoslovniProstor_Click(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public async void popuniPodacima()
        {

            listView1.Items.Clear();
            List<PoslovniProstorPregled> podaci = await DTOManager.VratiPoslovniProstor(Id!);

            foreach (PoslovniProstorPregled z in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { z.Id, z.RedniBroj.ToString() });
                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }

        private void btnDodajPoslovniProstor_Click(object sender, EventArgs e)
        {
            PoslovniProstorDodajForm form = new PoslovniProstorDodajForm(Id!);
            form.ShowDialog();
            this.popuniPodacima();
        }
    }
}
