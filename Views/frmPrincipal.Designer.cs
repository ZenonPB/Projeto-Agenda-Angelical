namespace Projeto_Agenda_Angelical.Views
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblBemVindo = new Label();
            lblUserName = new Label();
            dgvCat = new DataGridView();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRefresh = new Button();
            gbxSecurity = new GroupBox();
            txtNovaSenha = new Label();
            tbxNewPass = new TextBox();
            btnNewPass = new Button();
            gbxUserInfo = new GroupBox();
            lblAnjo = new Label();
            lblAnjoTitle = new Label();
            lblTelefone = new Label();
            lblUsuario = new Label();
            lblTelefoneTitle = new Label();
            lblUsuarioTitle = new Label();
            lblNome = new Label();
            lblNomeTitle = new Label();
            btnAgenda = new Button();
            lblCategorias = new Label();
            tbxCatName = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            gbxSecurity.SuspendLayout();
            gbxUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.BackColor = Color.Transparent;
            lblBemVindo.Font = new Font("Yu Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.White;
            lblBemVindo.Location = new Point(221, -1);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(317, 42);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Seja bem-vindo(a),";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(255, 255, 192);
            lblUserName.Location = new Point(250, 35);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(252, 61);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "USUÁRIO";
            // 
            // dgvCat
            // 
            dgvCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCat.Location = new Point(20, 99);
            dgvCat.Name = "dgvCat";
            dgvCat.Size = new Size(224, 246);
            dgvCat.TabIndex = 2;
            dgvCat.CellClick += dgvCat_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(250, 271);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Apagar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(250, 179);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(192, 192, 255);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(250, 225);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(144, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonFace;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(250, 134);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(144, 29);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Atualizar tabela";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // gbxSecurity
            // 
            gbxSecurity.Controls.Add(txtNovaSenha);
            gbxSecurity.Controls.Add(tbxNewPass);
            gbxSecurity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxSecurity.Location = new Point(434, 99);
            gbxSecurity.Name = "gbxSecurity";
            gbxSecurity.Size = new Size(245, 72);
            gbxSecurity.TabIndex = 7;
            gbxSecurity.TabStop = false;
            gbxSecurity.Text = "Segurança";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.AutoSize = true;
            txtNovaSenha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNovaSenha.Location = new Point(5, 19);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(85, 15);
            txtNovaSenha.TabIndex = 1;
            txtNovaSenha.Text = "Alterar a senha";
            // 
            // tbxNewPass
            // 
            tbxNewPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNewPass.Location = new Point(6, 34);
            tbxNewPass.Name = "tbxNewPass";
            tbxNewPass.PlaceholderText = "Nova senha";
            tbxNewPass.Size = new Size(233, 23);
            tbxNewPass.TabIndex = 0;
            // 
            // btnNewPass
            // 
            btnNewPass.Location = new Point(492, 158);
            btnNewPass.Name = "btnNewPass";
            btnNewPass.Size = new Size(122, 31);
            btnNewPass.TabIndex = 8;
            btnNewPass.Text = "Confirmar";
            btnNewPass.UseVisualStyleBackColor = true;
            btnNewPass.Click += btnNewPass_Click;
            // 
            // gbxUserInfo
            // 
            gbxUserInfo.Controls.Add(lblAnjo);
            gbxUserInfo.Controls.Add(lblAnjoTitle);
            gbxUserInfo.Controls.Add(lblTelefone);
            gbxUserInfo.Controls.Add(lblUsuario);
            gbxUserInfo.Controls.Add(lblTelefoneTitle);
            gbxUserInfo.Controls.Add(lblUsuarioTitle);
            gbxUserInfo.Controls.Add(lblNome);
            gbxUserInfo.Controls.Add(lblNomeTitle);
            gbxUserInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxUserInfo.Location = new Point(436, 206);
            gbxUserInfo.Name = "gbxUserInfo";
            gbxUserInfo.Size = new Size(243, 138);
            gbxUserInfo.TabIndex = 9;
            gbxUserInfo.TabStop = false;
            gbxUserInfo.Text = "Informações do Usuário";
            // 
            // lblAnjo
            // 
            lblAnjo.AutoSize = true;
            lblAnjo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnjo.Location = new Point(145, 102);
            lblAnjo.Name = "lblAnjo";
            lblAnjo.Size = new Size(72, 15);
            lblAnjo.TabIndex = 14;
            lblAnjo.Text = "Anjo Gabriel";
            // 
            // lblAnjoTitle
            // 
            lblAnjoTitle.AutoSize = true;
            lblAnjoTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnjoTitle.Location = new Point(135, 87);
            lblAnjoTitle.Name = "lblAnjoTitle";
            lblAnjoTitle.Size = new Size(91, 15);
            lblAnjoTitle.TabIndex = 13;
            lblAnjoTitle.Text = "Anjo da Guarda";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(37, 102);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(43, 15);
            lblTelefone.TabIndex = 12;
            lblTelefone.Text = "123456";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(161, 48);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "user123";
            // 
            // lblTelefoneTitle
            // 
            lblTelefoneTitle.AutoSize = true;
            lblTelefoneTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefoneTitle.Location = new Point(32, 87);
            lblTelefoneTitle.Name = "lblTelefoneTitle";
            lblTelefoneTitle.Size = new Size(56, 15);
            lblTelefoneTitle.TabIndex = 11;
            lblTelefoneTitle.Text = "Telefone";
            // 
            // lblUsuarioTitle
            // 
            lblUsuarioTitle.AutoSize = true;
            lblUsuarioTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioTitle.Location = new Point(158, 33);
            lblUsuarioTitle.Name = "lblUsuarioTitle";
            lblUsuarioTitle.Size = new Size(49, 15);
            lblUsuarioTitle.TabIndex = 10;
            lblUsuarioTitle.Text = "Usuário";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(37, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "samuel";
            // 
            // lblNomeTitle
            // 
            lblNomeTitle.AutoSize = true;
            lblNomeTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeTitle.Location = new Point(37, 33);
            lblNomeTitle.Name = "lblNomeTitle";
            lblNomeTitle.Size = new Size(41, 15);
            lblNomeTitle.TabIndex = 2;
            lblNomeTitle.Text = "Nome";
            // 
            // btnAgenda
            // 
            btnAgenda.BackColor = SystemColors.ButtonFace;
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgenda.ForeColor = SystemColors.ActiveCaptionText;
            btnAgenda.Location = new Point(250, 316);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(144, 29);
            btnAgenda.TabIndex = 10;
            btnAgenda.Text = "Acessar Agenda";
            btnAgenda.UseVisualStyleBackColor = false;
            btnAgenda.Click += btnAgenda_Click;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategorias.ForeColor = Color.White;
            lblCategorias.Location = new Point(65, 65);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(139, 31);
            lblCategorias.TabIndex = 11;
            lblCategorias.Text = "Categorias";
            // 
            // tbxCatName
            // 
            tbxCatName.Location = new Point(250, 99);
            tbxCatName.Name = "tbxCatName";
            tbxCatName.PlaceholderText = "Nome da Categoria";
            tbxCatName.Size = new Size(144, 23);
            tbxCatName.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.nuvemzinha;
            pictureBox1.Location = new Point(473, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.nuvemzinha;
            pictureBox2.Location = new Point(-143, -93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(387, 189);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(691, 356);
            Controls.Add(lblUserName);
            Controls.Add(lblBemVindo);
            Controls.Add(tbxCatName);
            Controls.Add(lblCategorias);
            Controls.Add(btnAgenda);
            Controls.Add(gbxUserInfo);
            Controls.Add(btnNewPass);
            Controls.Add(gbxSecurity);
            Controls.Add(pictureBox1);
            Controls.Add(btnRefresh);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvCat);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "Menu Principal";
            FormClosed += frmPrincipal_FormClosed;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCat).EndInit();
            gbxSecurity.ResumeLayout(false);
            gbxSecurity.PerformLayout();
            gbxUserInfo.ResumeLayout(false);
            gbxUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBemVindo;
        private Label lblUserName;
        private DataGridView dgvCat;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRefresh;
        private GroupBox gbxSecurity;
        private Label txtNovaSenha;
        private TextBox tbxNewPass;
        private Button btnNewPass;
        private GroupBox gbxUserInfo;
        private Label lblTelefoneTitle;
        private Label lblUsuarioTitle;
        private Label lblNome;
        private Label lblNomeTitle;
        private Label lblUsuario;
        private Label lblAnjo;
        private Label lblAnjoTitle;
        private Label lblTelefone;
        private Button btnAgenda;
        private Label lblCategorias;
        private TextBox tbxCatName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}