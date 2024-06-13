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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void FrmMeni1_Load_1(object sender, EventArgs e)
        {
            ShowRecepti();
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodaj frmDodaj = new FrmDodaj();
            if (frmDodaj.ShowDialog() == DialogResult.OK)
            {
                ShowRecepti();
            }
            /*Hide();
            FrmDodaj frmDodaj = new FrmDodaj();
            frmDodaj.ShowDialog();
            this.Close();*/
        }


        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRecepti.SelectedRows.Count > 0)
            {
                int idMeni1 = (int)dgvRecepti.SelectedRows[0].Cells["IdMeni1"].Value;
                ReceptRepository.DeleteRecept(idMeni1);
                ShowRecepti();
            }
            else
            {
                MessageBox.Show("Molim odaberite redak koji želite obrisati.");
            }
        }
    }
}
