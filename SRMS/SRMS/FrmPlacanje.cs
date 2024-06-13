using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRMS
{
    public partial class FrmPlacanje : Form
    {
        public FrmPlacanje()
        {
            InitializeComponent();
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            string ImePrez = txtImePrez.Text;
            string BrojKartice = txtBrojKartice.Text;
            string DatumIsteka = txtDatumIsteka.Text;
            string CVC = txtCVC.Text;

            if (ImePrez == "" || BrojKartice == "" || DatumIsteka == "" || CVC == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (ImePrez == "Ivan Lesko" && BrojKartice == "0000 0000 0000 0000" && DatumIsteka == "06/27" && CVC == "753")
                    {
                        FrmPotvrda frmPotvrda = new FrmPotvrda();
                        frmPotvrda.ShowDialog();
                        this.Close();
                    }else
                        {
                        MessageBox.Show("Unijeli ste neipravne podatke", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
        }

        private void btnNazadPlacanje_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRucak frmRucak = new FrmRucak();
            frmRucak.ShowDialog();
            this.Close();
        }
    }
}
