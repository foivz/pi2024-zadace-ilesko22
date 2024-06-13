using DBLayer;
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
    public partial class FrmPocetnaStranica : Form
    {

        public FrmPocetnaStranica()
        {
            InitializeComponent();
        }

        private void btnRucak_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRucak frmRucak = new FrmRucak();
            frmRucak.ShowDialog();
            this.Hide();
        }
    }
}
