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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // colocando as informações do usuario nas variaveis para adicionar
            string contatoNome = tbxName.Text;
            string telefone = tbxPhone.Text;
         //   int categoriaId = 

  //          ContatoController contatoController = new ContatoController();
    //        if(contatoController.CreateContato(contatoNome, telefone, ))
        }
    }
}
