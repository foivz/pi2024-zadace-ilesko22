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

namespace SRMS
{
    public partial class FrmDodaj : Form
    {
        public FrmDodaj()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string jelo = txtJelo.Text;
            string sastojak = txtSastojak.Text;

            if (!string.IsNullOrWhiteSpace(jelo) && !string.IsNullOrWhiteSpace(sastojak))
            {
                Recept recept = new Recept
                {
                    Jelo = jelo,
                    Sastojak = sastojak
                };
                ReceptRepository.InsertRecept(recept);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Jelo i sastojak ne mogu biti prazni.");
            }
        }
    }
}
