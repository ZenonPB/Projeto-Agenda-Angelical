namespace Projeto_Agenda_Angelical.Views
{
    partial class frmAddCat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCat));
            lblNova = new Label();
            lblCategoria = new Label();
            imgNuvem = new PictureBox();
            imgNuvem2 = new PictureBox();
            tbxCatName = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)imgNuvem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgNuvem2).BeginInit();
            SuspendLayout();
            // 
            // lblNova
            // 
            lblNova.AutoSize = true;
            lblNova.BackColor = Color.Transparent;
            lblNova.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNova.ForeColor = Color.White;
            lblNova.Location = new Point(161, 9);
            lblNova.Name = "lblNova";
            lblNova.Size = new Size(71, 27);
            lblNova.TabIndex = 0;
            lblNova.Text = "NOVA";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.FromArgb(255, 255, 192);
            lblCategoria.Location = new Point(82, 36);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(238, 48);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "CATEGORIA";
            // 
            // imgNuvem
            // 
            imgNuvem.BackColor = Color.Transparent;
            imgNuvem.Image = Properties.Resources.nuvemzinha;
            imgNuvem.Location = new Point(194, 87);
            imgNuvem.Name = "imgNuvem";
            imgNuvem.Size = new Size(326, 159);
            imgNuvem.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNuvem.TabIndex = 2;
            imgNuvem.TabStop = false;
            // 
            // imgNuvem2
            // 
            imgNuvem2.BackColor = Color.Transparent;
            imgNuvem2.Image = Properties.Resources.nuvemzinha;
            imgNuvem2.Location = new Point(-223, 45);
            imgNuvem2.Name = "imgNuvem2";
            imgNuvem2.Size = new Size(326, 159);
            imgNuvem2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNuvem2.TabIndex = 3;
            imgNuvem2.TabStop = false;
            // 
            // tbxCatName
            // 
            tbxCatName.Location = new Point(43, 89);
            tbxCatName.Name = "tbxCatName";
            tbxCatName.PlaceholderText = "Nome da Categoria";
            tbxCatName.Size = new Size(325, 23);
            tbxCatName.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SkyBlue;
            btnAdd.Location = new Point(106, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(186, 48);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(407, 178);
            Controls.Add(btnAdd);
            Controls.Add(tbxCatName);
            Controls.Add(lblCategoria);
            Controls.Add(lblNova);
            Controls.Add(imgNuvem);
            Controls.Add(imgNuvem2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAddCat";
            Text = "Adicionar categorias";
            FormClosed += frmAddCat_FormClosed;
            ((System.ComponentModel.ISupportInitialize)imgNuvem).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgNuvem2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNova;
        private Label lblCategoria;
        private PictureBox imgNuvem;
        private PictureBox imgNuvem2;
        private TextBox tbxCatName;
        private Button btnAdd;
    }
}