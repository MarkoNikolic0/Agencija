using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.Forms;

namespace WinFormsUI
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
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

        private void btnAgencije_Click(object sender, EventArgs e)
        {
            AgencijaForm form = new AgencijaForm();

            form.ShowDialog();
        }
    }
}
