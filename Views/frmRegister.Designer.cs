namespace Projeto_Agenda_Angelical.Views
{
    partial class frmBack
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
            textBox1 = new TextBox();
            btnRegister = new Button();
            button1 = new Button();
            gbxUserInfos = new GroupBox();
            gbxUserInfos.SuspendLayout();
            SuspendLayout();
            // 
            // lblJulgamentoFinal
            // 
            lblJulgamentoFinal.AutoSize = true;
            lblJulgamentoFinal.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJulgamentoFinal.ForeColor = Color.FromArgb(255, 255, 192);
            lblJulgamentoFinal.Location = new Point(71, 9);
            lblJulgamentoFinal.Name = "lblJulgamentoFinal";
            lblJulgamentoFinal.Size = new Size(384, 45);
            lblJulgamentoFinal.TabIndex = 2;
            lblJulgamentoFinal.Text = "JULGAMENTO FINAL";
            // 
            // tbxUser
            // 
            tbxUser.Location = new Point(6, 16);
            tbxUser.Name = "tbxUser";
            tbxUser.PlaceholderText = "Nome";
            tbxUser.Size = new Size(373, 23);
            tbxUser.TabIndex = 3;
            // 
            // cbxAngels
            // 
            cbxAngels.FormattingEnabled = true;
            cbxAngels.Items.AddRange(new object[] { "Anjo Gabriel", "Anjo Miguel", "Anjo Rafael", "Anjo Daniel" });
            cbxAngels.Location = new Point(77, 84);
            cbxAngels.Name = "cbxAngels";
            cbxAngels.Size = new Size(373, 23);
            cbxAngels.TabIndex = 4;
            cbxAngels.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblAnjoGuarda
            // 
            lblAnjoGuarda.AutoSize = true;
            lblAnjoGuarda.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnjoGuarda.ForeColor = Color.White;
            lblAnjoGuarda.Location = new Point(121, 54);
            lblAnjoGuarda.Name = "lblAnjoGuarda";
            lblAnjoGuarda.Size = new Size(287, 25);
            lblAnjoGuarda.TabIndex = 6;
            lblAnjoGuarda.Text = "Selecione seu Anjo da Guarda";
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(6, 74);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.PlaceholderText = "Senha";
            tbxPassword.Size = new Size(373, 23);
            tbxPassword.TabIndex = 7;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(6, 45);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.PlaceholderText = "Telefone";
            tbxPhone.Size = new Size(373, 23);
            tbxPhone.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 103);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Confirme a Senha";
            textBox1.Size = new Size(373, 23);
            textBox1.TabIndex = 9;
            textBox1.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 255, 192);
            btnRegister.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ControlText;
            btnRegister.Location = new Point(77, 257);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(183, 43);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Fazer a Passagem";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(267, 256);
            button1.Name = "button1";
            button1.Size = new Size(183, 43);
            button1.TabIndex = 11;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            // 
            // gbxUserInfos
            // 
            gbxUserInfos.Controls.Add(tbxUser);
            gbxUserInfos.Controls.Add(tbxPhone);
            gbxUserInfos.Controls.Add(tbxPassword);
            gbxUserInfos.Controls.Add(textBox1);
            gbxUserInfos.Location = new Point(71, 113);
            gbxUserInfos.Name = "gbxUserInfos";
            gbxUserInfos.Size = new Size(384, 137);
            gbxUserInfos.TabIndex = 12;
            gbxUserInfos.TabStop = false;
            gbxUserInfos.Text = "Informações";
            // 
            // frmBack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(499, 312);
            Controls.Add(gbxUserInfos);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(lblAnjoGuarda);
            Controls.Add(cbxAngels);
            Controls.Add(lblJulgamentoFinal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmBack";
            Text = "Registar-se";
            gbxUserInfos.ResumeLayout(false);
            gbxUserInfos.PerformLayout();
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
        private TextBox textBox1;
        private Button btnRegister;
        private Button button1;
        private GroupBox gbxUserInfos;
    }
}