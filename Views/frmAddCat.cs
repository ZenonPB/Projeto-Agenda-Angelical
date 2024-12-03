using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Agenda_Angelical;
using Projeto_Agenda_Angelical.Controller;

namespace Projeto_Agenda_Angelical.Views
{
    public partial class frmAddCat : Form
    {
        public frmAddCat()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoriaController controller = new CategoriaController();
            string catName = tbxCatName.Text;

            if(controller.CreateCategoria(catName) == true)
            {
                MessageBox.Show($"Categoria {catName} foi adicionada com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar a categoria! Tente novamente");
            }

        }

        private void frmAddCat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
