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
            UserController userController = new UserController();

            if(userController.UserExists(tbxUser.Text, tbxPassword.Text))
            {
                UserSession.Usuario = tbxUser.Text;

                UserSession.Conexao = ConexaoDB.Connection(tbxUser.Text, tbxPassword.Text);

                frmPrincipal frmPrincipal = new frmPrincipal();
                this.Hide();

                frmPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta.", "Tente Novamente!");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
