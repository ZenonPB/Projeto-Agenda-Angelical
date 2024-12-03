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
            dgvContato = new DataGridView();
            gbxContactInfo = new GroupBox();
            button3 = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            cbxCategoria = new ComboBox();
            lblCategoria = new Label();
            tbxPhone = new TextBox();
            lblPhone = new Label();
            tbxName = new TextBox();
            lblContactName = new Label();
            imgNuvem = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvContato).BeginInit();
            gbxContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgNuvem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvContato
            // 
            dgvContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContato.Location = new Point(217, 12);
            dgvContato.Name = "dgvContato";
            dgvContato.Size = new Size(235, 426);
            dgvContato.TabIndex = 0;
            // 
            // gbxContactInfo
            // 
            gbxContactInfo.BackColor = Color.SkyBlue;
            gbxContactInfo.Controls.Add(button3);
            gbxContactInfo.Controls.Add(btnDelete);
            gbxContactInfo.Controls.Add(btnAdd);
            gbxContactInfo.Controls.Add(cbxCategoria);
            gbxContactInfo.Controls.Add(lblCategoria);
            gbxContactInfo.Controls.Add(tbxPhone);
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
            btnAdd.Click += btnAdd_Click;
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
            // tbxPhone
            // 
            tbxPhone.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPhone.Location = new Point(6, 123);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.PlaceholderText = "16996305811";
            tbxPhone.Size = new Size(187, 27);
            tbxPhone.TabIndex = 3;
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
            // imgNuvem
            // 
            imgNuvem.BackColor = Color.Transparent;
            imgNuvem.Image = Properties.Resources.nuvemzinha;
            imgNuvem.Location = new Point(107, 288);
            imgNuvem.Name = "imgNuvem";
            imgNuvem.Size = new Size(410, 210);
            imgNuvem.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNuvem.TabIndex = 8;
            imgNuvem.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.nuvemzinha;
            pictureBox1.Location = new Point(-52, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(464, 450);
            Controls.Add(gbxContactInfo);
            Controls.Add(dgvContato);
            Controls.Add(imgNuvem);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAgenda";
            Text = "Agenda Telefônica";
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContato).EndInit();
            gbxContactInfo.ResumeLayout(false);
            gbxContactInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgNuvem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContato;
        private GroupBox gbxContactInfo;
        private Label lblContactName;
        private TextBox tbxName;
        private Label lblCategoria;
        private TextBox tbxPhone;
        private Label lblPhone;
        private Button button3;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cbxCategoria;
        private PictureBox imgNuvem;
        private PictureBox pictureBox1;
    }
}