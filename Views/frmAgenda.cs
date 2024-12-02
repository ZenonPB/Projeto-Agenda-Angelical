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

            cbxCategoria.Items.Add
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
