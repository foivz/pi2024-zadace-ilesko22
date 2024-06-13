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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "" ||  password == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (username == "ilesko@gmail.com" && password == "1234")
            {
                Hide();
                FrmPocetnaStranica frmPocetnaStranica = new FrmPocetnaStranica();
                frmPocetnaStranica.ShowDialog();
                Close();
            }else
            {
                MessageBox.Show("Email ili lozinka nisu ispravni", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load_1(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_ilesko22_DB", "PI2324_ilesko22_User", ">N/PV71:");
        }
    }
}
