using Projeto_Agenda_Angelical.Controller;
using Projeto_Agenda_Angelical.Data;
using Projeto_Agenda_Angelical.GlobalVariable;
using Projeto_Agenda_Angelical.Views;

namespace Projeto_Agenda_Angelical
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void tbxUser_TextChanged(object sender, EventArgs e)
        {
            if (
                tbxUser.Text != "" && tbxPassword.Text.Length >= 8)
            {
                btnLogin.Enabled = true;
            }

            else
            {
                btnLogin.Enabled = false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = tbxUser.Text;
            string senha = tbxPassword.Text;

            UserController userController = new UserController();

            if(userController.UserExists(usuario, senha) == true)
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao fazer login! Reveja as informações e tente novamente!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
            this.Hide();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
