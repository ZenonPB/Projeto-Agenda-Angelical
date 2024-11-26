namespace Projeto_Agenda_Angelical.Views
{
    partial class frmRegister
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
            lblJulgamentoFinal = new Label();
            tbxUser = new TextBox();
            cbxAngels = new ComboBox();
            lblAnjoGuarda = new Label();
            tbxPassword = new TextBox();
            tbxPhone = new TextBox();
            tbxConfirm = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            gbxUserInfos = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            gbxUserInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblJulgamentoFinal
            // 
            lblJulgamentoFinal.AutoSize = true;
            lblJulgamentoFinal.BackColor = Color.Transparent;
            lblJulgamentoFinal.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJulgamentoFinal.ForeColor = Color.FromArgb(255, 255, 192);
            lblJulgamentoFinal.Location = new Point(62, 9);
            lblJulgamentoFinal.Name = "lblJulgamentoFinal";
            lblJulgamentoFinal.Size = new Size(384, 45);
            lblJulgamentoFinal.TabIndex = 2;
            lblJulgamentoFinal.Text = "JULGAMENTO FINAL";
            // 
            // tbxUser
            // 
            tbxUser.Location = new Point(6, 20);
            tbxUser.Name = "tbxUser";
            tbxUser.PlaceholderText = "Usuário";
            tbxUser.Size = new Size(373, 23);
            tbxUser.TabIndex = 3;
            tbxUser.TextChanged += tbxUser_TextChanged;
            // 
            // cbxAngels
            // 
            cbxAngels.FormattingEnabled = true;
            cbxAngels.Items.AddRange(new object[] { "Anjo Gabriel", "Anjo Miguel", "Anjo Rafael", "Anjo Daniel", "Anjo Mateus", "Anjo Belzebu", "Anjo Metatron", "ANUNAKIS" });
            cbxAngels.Location = new Point(68, 70);
            cbxAngels.Name = "cbxAngels";
            cbxAngels.Size = new Size(373, 23);
            cbxAngels.TabIndex = 4;
            cbxAngels.SelectedIndexChanged += cbxAngels_SelectedIndexChanged;
            // 
            // lblAnjoGuarda
            // 
            lblAnjoGuarda.AutoSize = true;
            lblAnjoGuarda.BackColor = Color.Transparent;
            lblAnjoGuarda.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnjoGuarda.ForeColor = Color.White;
            lblAnjoGuarda.Location = new Point(112, 45);
            lblAnjoGuarda.Name = "lblAnjoGuarda";
            lblAnjoGuarda.Size = new Size(287, 25);
            lblAnjoGuarda.TabIndex = 6;
            lblAnjoGuarda.Text = "Selecione seu Anjo da Guarda";
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(6, 78);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.PlaceholderText = "Senha";
            tbxPassword.Size = new Size(373, 23);
            tbxPassword.TabIndex = 7;
            tbxPassword.UseSystemPasswordChar = true;
            tbxPassword.TextChanged += tbxPassword_TextChanged;
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(6, 49);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.PlaceholderText = "Telefone";
            tbxPhone.Size = new Size(373, 23);
            tbxPhone.TabIndex = 8;
            tbxPhone.TextChanged += tbxPhone_TextChanged;
            // 
            // tbxConfirm
            // 
            tbxConfirm.Location = new Point(6, 107);
            tbxConfirm.Name = "tbxConfirm";
            tbxConfirm.PasswordChar = '*';
            tbxConfirm.PlaceholderText = "Confirme a Senha";
            tbxConfirm.Size = new Size(373, 23);
            tbxConfirm.TabIndex = 9;
            tbxConfirm.UseSystemPasswordChar = true;
            tbxConfirm.TextChanged += tbxConfirm_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 255, 192);
            btnRegister.Enabled = false;
            btnRegister.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ControlText;
            btnRegister.Location = new Point(68, 247);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(183, 43);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Fazer a Passagem";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 192, 192);
            btnBack.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(258, 247);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(183, 43);
            btnBack.TabIndex = 11;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // gbxUserInfos
            // 
            gbxUserInfos.BackColor = Color.Transparent;
            gbxUserInfos.Controls.Add(tbxUser);
            gbxUserInfos.Controls.Add(tbxPhone);
            gbxUserInfos.Controls.Add(tbxPassword);
            gbxUserInfos.Controls.Add(tbxConfirm);
            gbxUserInfos.Location = new Point(62, 99);
            gbxUserInfos.Name = "gbxUserInfos";
            gbxUserInfos.Size = new Size(384, 142);
            gbxUserInfos.TabIndex = 12;
            gbxUserInfos.TabStop = false;
            gbxUserInfos.Text = "Informações";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nuvemzinha;
            pictureBox1.Location = new Point(248, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 411);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.nuvemzinha;
            pictureBox2.Location = new Point(-269, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(535, 279);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(499, 312);
            Controls.Add(gbxUserInfos);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(lblAnjoGuarda);
            Controls.Add(cbxAngels);
            Controls.Add(lblJulgamentoFinal);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmRegister";
            Text = "Registar-se";
            gbxUserInfos.ResumeLayout(false);
            gbxUserInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJulgamentoFinal;
        private TextBox tbxUser;
        private ComboBox cbxAngels;
        private Label lblAnjoGuarda;
        private TextBox tbxPassword;
        private TextBox tbxPhone;
        private TextBox tbxConfirm;
        private Button btnRegister;
        private Button btnBack;
        private GroupBox gbxUserInfos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}