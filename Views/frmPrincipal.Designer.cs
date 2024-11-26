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
            groupBox1 = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            gbxSecurity.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Yu Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.White;
            lblBemVindo.Location = new Point(210, 0);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(317, 42);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Seja bem-vindo(a),";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(255, 255, 192);
            lblUserName.Location = new Point(238, 32);
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
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(250, 236);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Apagar";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(250, 145);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(192, 192, 255);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(250, 190);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(144, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonFace;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(250, 99);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(144, 40);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Atualizar";
            btnRefresh.UseVisualStyleBackColor = false;
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAnjo);
            groupBox1.Controls.Add(lblAnjoTitle);
            groupBox1.Controls.Add(lblTelefone);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(lblTelefoneTitle);
            groupBox1.Controls.Add(lblUsuarioTitle);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblNomeTitle);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(436, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 138);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Usuário";
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
            lblTelefone.Location = new Point(24, 102);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(73, 15);
            lblTelefone.TabIndex = 12;
            lblTelefone.Text = "16996305811";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(158, 48);
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
            lblNome.Location = new Point(29, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(62, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "flavin silva";
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
            btnAgenda.Location = new Point(250, 304);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(144, 40);
            btnAgenda.TabIndex = 10;
            btnAgenda.Text = "Acessar Agenda";
            btnAgenda.UseVisualStyleBackColor = false;
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
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(691, 356);
            Controls.Add(lblCategorias);
            Controls.Add(btnAgenda);
            Controls.Add(groupBox1);
            Controls.Add(btnNewPass);
            Controls.Add(gbxSecurity);
            Controls.Add(btnRefresh);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvCat);
            Controls.Add(lblUserName);
            Controls.Add(lblBemVindo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "Menu Principal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCat).EndInit();
            gbxSecurity.ResumeLayout(false);
            gbxSecurity.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
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
    }
}