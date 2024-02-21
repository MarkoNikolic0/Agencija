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
    public partial class AgencijaForm : Form
    {
        public AgencijaForm()
        {
            InitializeComponent();
        }

        private void btnPrikaziAgencije_Click(object sender, EventArgs e)
        {
        }

        private void btnZgrade_Click(object sender, EventArgs e)
        {
            ZgradaForm form = new ZgradaForm();
            form.ShowDialog();
        }

        private void btnUpravnici_Click(object sender, EventArgs e)
        {
            UpravnikForm form = new UpravnikForm();
            form.ShowDialog();
        }

        private void AgencijaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLicence_Click(object sender, EventArgs e)
        {
            LicenceForm form = new LicenceForm();
            form.ShowDialog();
        }
    }
}
