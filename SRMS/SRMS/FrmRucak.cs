using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRMS
{
    public partial class FrmRucak : Form
    {
        public FrmRucak()
        {
            InitializeComponent();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPocetnaStranica frmPocetnaStranica = new FrmPocetnaStranica();
            frmPocetnaStranica.ShowDialog();
            this.Close();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMeni1 frmMeni1 = new FrmMeni1();
            frmMeni1.ShowDialog();
            this.Close();
        }

        private void btnMeni1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPlacanje frmPlacanje = new FrmPlacanje();
            frmPlacanje.ShowDialog();
            this.Close();
        }
    }
}
