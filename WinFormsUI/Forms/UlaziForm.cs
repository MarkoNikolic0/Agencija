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
    public partial class UlaziForm : Form
    {
        string id;
        public UlaziForm()
        {
            InitializeComponent();
        }

        public UlaziForm(string id)
        {
            InitializeComponent();
            this.id=id;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UlaziForm_Load(object sender, EventArgs e)
        {
            List<UlaziPregled> ulazi = new List<UlaziPregled>();

            try
            {

                ulazi = DTOManager.vratiUlazeZgrade(id);

                foreach (UlaziPregled o in ulazi)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.Id, o.RedniBroj.ToString(),
                        o.Kamera.ToString(), o.Otvoren});
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
