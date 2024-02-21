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

namespace WinFormsUI.Forms
{
    public partial class ParkingMestaForm : Form
    {
        string? Id = null;
        public ParkingMestaForm()
        {
            InitializeComponent();
        }

        public ParkingMestaForm(string id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private async void ParkingMestaForm_Load(object sender, EventArgs e)
        {
            List<ParkingMestoPregled> parkingMesta = new List<ParkingMestoPregled>();

            try
            {
                parkingMesta = await DTOManager.vratiParkingMestaZgrade(Id);

                foreach (ParkingMestoPregled o in parkingMesta)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.RegBroj, o.Garaza.RedniBroj.ToString() });
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
