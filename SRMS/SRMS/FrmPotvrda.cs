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
    public partial class FrmPotvrda : Form
    {
        public FrmPotvrda()
        {
            InitializeComponent();
        }

        private void btnNazadPotvrda_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPocetnaStranica frmPocetnaStranica = new FrmPocetnaStranica();
            frmPocetnaStranica.ShowDialog();
            this.Close();

        }
    }
}
