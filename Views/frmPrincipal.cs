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
    }
}
