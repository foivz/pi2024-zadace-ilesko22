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
    public partial class FrmMeni1 : Form
    {
        public FrmMeni1()
        {
            InitializeComponent();
        }

        private void btnNazadMeni1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRucak frmRucak = new FrmRucak();
            frmRucak.ShowDialog();
            this.Close();
        }
    }
}
