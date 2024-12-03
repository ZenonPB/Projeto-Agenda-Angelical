using Projeto_Agenda_Angelical.Controller;
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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            // criando e preenchendo a tabela de contatos
            ContatoController contatoController = new ContatoController();
            DataTable tabela = contatoController.GetContatos();
            dgvContato.DataSource = tabela;

            // preenchendo a combo box com as categorias criada pelo caba
            CategoriaController categoriaController = new CategoriaController();
            DataTable dataTable = categoriaController.GetCategorias();
            cbxCategoria.DataSource = dataTable;
            cbxCategoria.DisplayMember = "categoria";
            cbxCategoria.ValueMember = "ID";
        }

        private void dgvContato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // evita que o caba pegue o negocio do cabeçalho e quebre tudo
            if (e.RowIndex >= 0)
            {
                // pega a linha que clicou
                DataGridViewRow selectedRow = dgvContato.Rows[e.RowIndex];

                // pega o valor das colunas e substitue os valores
                string contatoNome = selectedRow.Cells["Nome"].Value.ToString();
                tbxName.Text = contatoNome;
                string telefoneContato = selectedRow.Cells["Telefone"].Value.ToString();
                tbxPhone.Text = telefoneContato;
                int categoriaId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                cbxCategoria.SelectedValue = categoriaId;
            }
        }

        private void AtualizarContatos()
        {
            ContatoController contatoController = new ContatoController();
            DataTable tabela = contatoController.GetContatos();
            dgvContato.DataSource = tabela;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // colocando as informações do usuario nas variaveis para adicionar
            string contatoNome = tbxName.Text;
            string telefone = tbxPhone.Text;
            int categoriaId = Convert.ToInt32(cbxCategoria.SelectedValue);

            // impedindo do zé bonitinho mandar sem tem algo preenchido
            if (string.IsNullOrEmpty(contatoNome) || string.IsNullOrEmpty(telefone) || categoriaId <= 0)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            ContatoController contatoController = new ContatoController();
            if (contatoController.CreateContato(contatoNome, telefone, categoriaId))
            {
                MessageBox.Show("Contato adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao adicionar o contato! Tente novamente");
            }

            AtualizarContatos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContato.CurrentRow == null || dgvContato.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Selecione um campo válido para excluir!");
            }
            // colocando as informações do usuario nas variaveis para adicionar
            int contatoId = Convert.ToInt32(dgvContato.CurrentRow.Cells["ID"].Value);

            ContatoController contatoController = new ContatoController();
            if (contatoController.DeleteContato(contatoId))
            {
                MessageBox.Show("Contato excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao excluir o contato! Tente novamente");
            }

            AtualizarContatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvContato.CurrentRow == null || dgvContato.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Selecione um campo válido para excluir!");
            }
            // colocando as informações do usuario nas variaveis para adicionar
            string novoContato = tbxName.Text;
            string novoTelefone = tbxPhone.Text;
            int contatoId = Convert.ToInt32(dgvContato.CurrentRow.Cells["ID"].Value);

            ContatoController contatoController = new ContatoController();
            if (contatoController.EditContato(contatoId, novoContato, novoTelefone))
            {
                MessageBox.Show("Contato editado com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao editar o contato! Tente novamente");
            }
        }

        private void frmAgenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }

    }
}
