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
    public partial class LokaliForm : Form
    {
        string? Id = null;
        public LokaliForm()
        {
            InitializeComponent();
        }
        public LokaliForm(string id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private async void LokaliForm_Load(object sender, EventArgs e)
        {
            List<LokalPregled> lokali = new List<LokalPregled>();

            try
            {
                lokali = await DTOManager.vratiLokaleZgrade(Id);

                foreach (LokalPregled o in lokali)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.ImeFirme, o.Prostor.RedniBroj.ToString() });
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
