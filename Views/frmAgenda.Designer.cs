namespace Projeto_Agenda_Angelical.Views
{
    partial class frmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            gdvContato = new DataGridView();
            gbxContactInfo = new GroupBox();
            button3 = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            cbxCategoria = new ComboBox();
            lblCategoria = new Label();
            textBox1 = new TextBox();
            lblPhone = new Label();
            tbxName = new TextBox();
            lblContactName = new Label();
            imgNuvem1 = new PictureBox();
            imgNuvem2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gdvContato).BeginInit();
            gbxContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgNuvem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgNuvem2).BeginInit();
            SuspendLayout();
            // 
            // gdvContato
            // 
            gdvContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvContato.Location = new Point(217, 12);
            gdvContato.Name = "gdvContato";
            gdvContato.Size = new Size(235, 426);
            gdvContato.TabIndex = 0;
            // 
            // gbxContactInfo
            // 
            gbxContactInfo.BackColor = Color.SkyBlue;
            gbxContactInfo.Controls.Add(button3);
            gbxContactInfo.Controls.Add(btnDelete);
            gbxContactInfo.Controls.Add(btnAdd);
            gbxContactInfo.Controls.Add(cbxCategoria);
            gbxContactInfo.Controls.Add(lblCategoria);
            gbxContactInfo.Controls.Add(textBox1);
            gbxContactInfo.Controls.Add(lblPhone);
            gbxContactInfo.Controls.Add(tbxName);
            gbxContactInfo.Controls.Add(lblContactName);
            gbxContactInfo.FlatStyle = FlatStyle.System;
            gbxContactInfo.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxContactInfo.Location = new Point(12, 5);
            gbxContactInfo.Name = "gbxContactInfo";
            gbxContactInfo.Size = new Size(199, 433);
            gbxContactInfo.TabIndex = 1;
            gbxContactInfo.TabStop = false;
            gbxContactInfo.Text = "Gerenciar Contatos";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.SkyBlue;
            button3.Location = new Point(6, 378);
            button3.Name = "button3";
            button3.Size = new Size(187, 39);
            button3.TabIndex = 7;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(6, 322);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 39);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Remover";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(6, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 39);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // cbxCategoria
            // 
            cbxCategoria.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(6, 193);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(187, 24);
            cbxCategoria.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(5, 174);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 16);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(4, 104);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(56, 16);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Telefone";
            // 
            // tbxName
            // 
            tbxName.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.Location = new Point(6, 52);
            tbxName.Name = "tbxName";
            tbxName.PlaceholderText = "Fulano Ciclano";
            tbxName.Size = new Size(187, 27);
            tbxName.TabIndex = 2;
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactName.Location = new Point(5, 33);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(104, 16);
            lblContactName.TabIndex = 2;
            lblContactName.Text = "Nome do Contato";
            // 
            // imgNuvem1
            // 
            imgNuvem1.BackColor = Color.Transparent;
            imgNuvem1.Image = Properties.Resources.nuvemzinha;
            imgNuvem1.Location = new Point(132, 304);
            imgNuvem1.Name = "imgNuvem1";
            imgNuvem1.Size = new Size(414, 225);
            imgNuvem1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNuvem1.TabIndex = 2;
            imgNuvem1.TabStop = false;
            // 
            // imgNuvem2
            // 
            imgNuvem2.BackColor = Color.Transparent;
            imgNuvem2.Image = Properties.Resources.nuvemzinha;
            imgNuvem2.Location = new Point(-53, -18);
            imgNuvem2.Name = "imgNuvem2";
            imgNuvem2.Size = new Size(414, 225);
            imgNuvem2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNuvem2.TabIndex = 3;
            imgNuvem2.TabStop = false;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(464, 450);
            Controls.Add(gbxContactInfo);
            Controls.Add(gdvContato);
            Controls.Add(imgNuvem1);
            Controls.Add(imgNuvem2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAgenda";
            Text = "Agenda Telefônica";
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)gdvContato).EndInit();
            gbxContactInfo.ResumeLayout(false);
            gbxContactInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgNuvem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgNuvem2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gdvContato;
        private GroupBox gbxContactInfo;
        private Label lblContactName;
        private TextBox tbxName;
        private Label lblCategoria;
        private TextBox textBox1;
        private Label lblPhone;
        private Button button3;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cbxCategoria;
        private PictureBox imgNuvem1;
        private PictureBox imgNuvem2;
    }
}