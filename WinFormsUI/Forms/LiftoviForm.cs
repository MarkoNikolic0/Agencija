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
    public partial class LiftoviForm : Form
    {
        string? Id = null;
        public LiftoviForm()
        {
            InitializeComponent();
        }

        public LiftoviForm(string id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private async void LiftoviForm_Load(object sender, EventArgs e)
        {
            List<LiftPregled> liftovi = new List<LiftPregled>();

            try
            {
                liftovi = await DTOManager.vratiLiftoveZgrade(Id!);

                foreach (LiftPregled o in liftovi)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.SerijskiBroj, o.Proizvodjac,
                    o.Tip, o.Nosivost.ToString(), o.BrojOsoba.ToString() });
                    listView1.Items.Add(item);
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

        private void btnDodajLift_Click(object sender, EventArgs e)
        {
            LiftDodajForm form = new LiftDodajForm(Id!);
            form.ShowDialog();
            listView1.Refresh();
        }
    }
}
