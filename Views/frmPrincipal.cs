using Projeto_Agenda_Angelical;
using Projeto_Agenda_Angelical.Controller;
using Projeto_Agenda_Angelical.GlobalVariable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda_Angelical.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Preenchendo a tabela
            CategoriaController categoriaController = new CategoriaController();
            DataTable tabela = categoriaController.GetCategorias();
            dgvCat.DataSource = tabela;

            // Mudando as infos para a do usuario
            lblNome.Text = $"{UserSession.Nome}";
            lblUsuario.Text = $"{UserSession.Usuario}";
            lblTelefone.Text = $"{UserSession.Telefone}";
            lblAnjo.Text = $"{UserSession.AnjoGuarda}";
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.ShowDialog();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CategoriaController categoriaCtrl = new CategoriaController();
            categoriaCtrl.GetCategorias();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCat frmAddCat = new frmAddCat();
            frmAddCat.ShowDialog();
        }
        private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string catName = dgvCat.SelectedCells[1].Value.ToString();
            tbxCatName.Text = catName;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idCat = Convert.ToInt32(dgvCat.SelectedCells[0].Value);
            string newCategory = tbxCatName.Text;
            CategoriaController categoriaController = new CategoriaController();
            categoriaController.RenameCategoria(idCat, newCategory);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idCat = Convert.ToInt32(dgvCat.SelectedCells[0].Value);
            CategoriaController controller = new CategoriaController();
            controller.DeleteCategoria(idCat);
        }

        private void btnNewPass_Click(object sender, EventArgs e)
        {
            string newPass = tbxNewPass.Text;
            UserController userController = new UserController();
            userController.ModifySenha(UserSession.Usuario, newPass);
        }
    }
}
