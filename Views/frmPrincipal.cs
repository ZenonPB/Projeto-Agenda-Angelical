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

        // Processos que iniciarão quando o formulario abrir
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Preenchendo a tabela
            CategoriaController categoriaController = new CategoriaController();
            DataTable tabela = categoriaController.GetCategorias();
            dgvCat.DataSource = tabela;

            // Mudando as infos para a do usuario
            lblNome.Text = $"{UserSession.Nome}";
            lblUserName.Text = $"{UserSession.Nome}";
            lblUsuario.Text = $"{UserSession.Usuario}";
            lblTelefone.Text = $"{UserSession.Telefone}";
            lblAnjo.Text = $"{UserSession.AnjoGuarda}";
        }

        // Fecha o form
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Quando clica no botão "Abrir Agenda"
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.ShowDialog();
        }

        // Atualiza a tabela sempre que clica no botão
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CategoriaController categoriaCtrl = new CategoriaController();
            DataTable tabelaAtualizada = categoriaCtrl.GetCategorias();
            dgvCat.DataSource = tabelaAtualizada;

        }

        // Abre o formulário para adicionar uma nova categoria
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCat frmAddCat = new frmAddCat();
            frmAddCat.ShowDialog();
        }

        // Quando selecionar uma célula, aparecer o nome da categoria no campo
        private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // evita que o caba pegue o negocio do cabeçalho e quebre tudo
            if (e.RowIndex >= 0)
            {
                // pega a linha que clicou
                DataGridViewRow selectedRow = dgvCat.Rows[e.RowIndex];

                // pega o valor da celula na coluna categoria
                string categoriaNome = selectedRow.Cells["Categoria"].Value.ToString();
                tbxCatName.Text = categoriaNome;
            }
        }

        // Editar a categoria
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // impede que tente editar sem estar com uma linha selecionada
            if(dgvCat.CurrentRow == null || dgvCat.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Selecione um campo válido para editar!");
            }

            int idCat = Convert.ToInt32(dgvCat.CurrentRow.Cells["ID"].Value);
            string novoNome = tbxCatName.Text.Trim();

            CategoriaController categoriaController = new CategoriaController();
            if(categoriaController.RenameCategoria(idCat, novoNome) == true)
            {
                MessageBox.Show("A categoria foi renomeada com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao renomear a categoria! Tente novamente");
            }
        }

        // Excluir a categoria
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // impede que tente excluir sem estar com uma linha selecionada
            if (dgvCat.CurrentRow == null || dgvCat.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Selecione um campo válido para editar!");
            }

            int idCat = Convert.ToInt32(dgvCat.CurrentRow.Cells["ID"].Value);

            CategoriaController categoriaController = new CategoriaController();
            if (categoriaController.DeleteCategoria(idCat) == true)
            {
                MessageBox.Show("A categoria foi excluída com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao excluir a categoria! Tente novamente");
            }
        }

        // Mudar a senha do usuário
        private void btnNewPass_Click(object sender, EventArgs e)
        {
            string newPass = tbxNewPass.Text;
            UserController userController = new UserController();
            if (userController.ModifySenha(UserSession.Usuario, newPass) == true)
            {
                MessageBox.Show("A senha foi alterada com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao alterar a senha! Tente novamente");
            }
        }

    }
}
