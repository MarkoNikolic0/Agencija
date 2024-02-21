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
    public partial class UpravnikForm : Form
    {
        public UpravnikForm()
        {
            InitializeComponent();
        }

        private async void btnPrikaziUpravnike_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<UpravnikPregled> upravnici = new List<UpravnikPregled>();

            upravnici = await DTOManager.VratiUpravnike();

            foreach (UpravnikPregled z in upravnici)
            {
                ListViewItem item = new ListViewItem(new string[] { z.JMBG, z.Ime, z.ImeRoditelja, z.Prezime, z.DatumRodjenja.ToString(), z.BrojLk, z.MestoIzdavanja, z.BrTel, z.Adresa, z.Institucija, z.Zvanje, z.DatumSticanja.ToString() });
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZgradaForm form = new ZgradaForm();
            form.ShowDialog();
        }

        public async void popuniPodacima()
        {

            listView1.Items.Clear();
            List<UpravnikPregled> podaci = await DTOManager.VratiUpravnike();

            foreach (UpravnikPregled z in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { z.Id,z.JMBG, z.Ime, z.ImeRoditelja, z.Prezime, z.DatumRodjenja.ToString(), z.BrojLk, z.MestoIzdavanja, z.BrTel, z.Adresa, z.Institucija, z.Zvanje, z.DatumSticanja.ToString() });
                listView1.Items.Add(item);

            }

            listView1.Refresh();
        }

        private void btnDodajUpravnika_Click(object sender, EventArgs e)
        {
            UpravnikDodajForm form = new UpravnikDodajForm();
            form.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisiUpravnika_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite upravnika kog zelite da obrisete!");
                return;
            }

            string jmbgUpravnika = listView1.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog upravnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiUpravnika(jmbgUpravnika);
                MessageBox.Show("Brisanje upravnika je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private async void btnIzmeniUpravnike_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite upravnika cije podatke zelite da izmenite!");
                return;
            }

            string idUpravnika = listView1.SelectedItems[0].SubItems[0].Text;
            UpravnikPregled ob = await DTOManager.VratiUpravnika(idUpravnika);

            UpravnikIzmeniForm formaUpdate = new UpravnikIzmeniForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpravnikForm_Load(object sender, EventArgs e)
        {

        }
    }
}
