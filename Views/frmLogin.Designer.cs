namespace Projeto_Agenda_Angelical
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBemVindo = new Label();
            lblParaiso = new Label();
            tbxUser = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            lblRegister = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Yu Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.White;
            lblBemVindo.Location = new Point(176, 9);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(212, 38);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Bem Vindo ao";
            // 
            // lblParaiso
            // 
            lblParaiso.AutoSize = true;
            lblParaiso.Font = new Font("Yu Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParaiso.ForeColor = Color.FromArgb(255, 255, 192);
            lblParaiso.Location = new Point(126, 62);
            lblParaiso.Name = "lblParaiso";
            lblParaiso.Size = new Size(322, 82);
            lblParaiso.TabIndex = 1;
            lblParaiso.Text = "PARAÍSO";
            // 
            // tbxUser
            // 
            tbxUser.Location = new Point(111, 156);
            tbxUser.Name = "tbxUser";
            tbxUser.PlaceholderText = "Nome do Anjo";
            tbxUser.Size = new Size(350, 23);
            tbxUser.TabIndex = 2;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(111, 194);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.PlaceholderText = "Senha";
            tbxPassword.Size = new Size(350, 23);
            tbxPassword.TabIndex = 3;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 255, 192);
            btnLogin.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(197, 223);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(177, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Adentrar o Céu";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.White;
            lblRegister.Location = new Point(165, 271);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(238, 25);
            lblRegister.TabIndex = 5;
            lblRegister.Text = "Não foi agraciado ainda?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 224, 192);
            btnRegister.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(197, 299);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(177, 45);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Julgamento Final";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(577, 360);
            Controls.Add(btnRegister);
            Controls.Add(lblRegister);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUser);
            Controls.Add(lblParaiso);
            Controls.Add(lblBemVindo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmLogin";
            Text = "Autenticar-se";
            FormClosed += frmLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBemVindo;
        private Label lblParaiso;
        private TextBox tbxUser;
        private TextBox tbxPassword;
        private Button btnLogin;
        private Label lblRegister;
        private Button btnRegister;
    }
}
