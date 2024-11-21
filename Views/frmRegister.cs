using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda_Angelical.Views
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

        }

        private void enableRegister()
        {
            bool isValid = false;

            if (cbxAngels.SelectedIndex == -1 || tbxUser.Text == "" || tbxPhone.Text == "" || tbxPassword.TextLength < 1 || tbxConfirm.Text != tbxPassword.Text)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            if (isValid)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void tbxUser_TextChanged(object sender, EventArgs e)
        {
            enableRegister();
        }

        private void tbxPhone_TextChanged(object sender, EventArgs e)
        {
            enableRegister();
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            enableRegister();
        }

        private void tbxConfirm_TextChanged(object sender, EventArgs e)
        {
            enableRegister();
        }

        private void cbxAngels_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableRegister();
        }
    }
}
