using SRMS.Model;
using SRMS.Reposatory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

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



        private void ShowRecepti()
        {
            try
            {
                List<Recept> recepti = ReceptRepository.GetAllRecepti();
                dgvRecepti.DataSource = recepti;
                dgvRecepti.Columns["IdMeni1"].DisplayIndex = 0;
                dgvRecepti.Columns["Jelo"].DisplayIndex = 1;
                dgvRecepti.Columns["Sastojak"].DisplayIndex = 2;
            }
            catch(Exception ex)
                {
                MessageBox.Show($"An error occurred: {ex.Message}");
                }
        }

        private void FrmMeni1_Load_1(object sender, EventArgs e)
        {
            ShowRecepti();
        }
    }
}
