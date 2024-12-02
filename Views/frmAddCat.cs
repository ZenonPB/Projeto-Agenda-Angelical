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

            controller.CreateCategoria(catName);

        }

        private void frmAddCat_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
