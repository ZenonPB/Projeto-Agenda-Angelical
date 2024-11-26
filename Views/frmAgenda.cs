using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Agenda_Angelical.Controller;

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
            CategoriaController categoriacontroller = new CategoriaController();
            DataTable tabela = categoriacontroller.GetCategorias();
            cbxCategoria.DataSource = tabela;
            cbxCategoria.DisplayMember = "categoria";
            cbxCategoria.ValueMember = "id_categoria";
        }
    }
}
