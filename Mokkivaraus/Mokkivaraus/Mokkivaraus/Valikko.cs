using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkivaraus
{
    public partial class Valikko : Form
    {
        public Valikko()
        {
            InitializeComponent();
        }

        private void Valikko_Load(object sender, EventArgs e)
        {

        }

        private void btnUusivaraus_Click(object sender, EventArgs e)
        {
            frmAsiakastiedot frm = new frmAsiakastiedot();
            if (Application.OpenForms.OfType<frmAsiakastiedot>().Count() == 1)
            {
                
            }
            else 
            {
                frm.Show();
            }
        }

        private void btnVarauksiin_Click(object sender, EventArgs e)
        {
            Majoitusvaraukset frm = new Majoitusvaraukset();
            if (Application.OpenForms.OfType<Majoitusvaraukset>().Count() == 1)
            {

            }
            else
            {
                frm.Show();
            }
        }

        private void btnPalveluihin_Click(object sender, EventArgs e)
        {
            PalveluidenHallinta frm = new PalveluidenHallinta();
            if (Application.OpenForms.OfType<PalveluidenHallinta>().Count() == 1)
            {

            }
            else
            {
                frm.Show();
            }
        }

        private void btnMokkiAlue_Click(object sender, EventArgs e)
        {
            frmTiedot frm = new frmTiedot();
            if (Application.OpenForms.OfType<frmTiedot>().Count() == 1)
            {

            }
            else
            {
                frm.Show();
            }
        }

        private void Valikko_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Olet sulkemassa sovellusta","Haluatko varmasti sulkea?", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (Result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
