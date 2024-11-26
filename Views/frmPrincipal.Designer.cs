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
            lblBemVindo = new Label();
            lblUserName = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Yu Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.White;
            lblBemVindo.Location = new Point(149, 9);
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
            lblUserName.Location = new Point(177, 41);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(252, 61);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "USUÁRIO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(151, 199);
            dataGridView1.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(603, 356);
            Controls.Add(dataGridView1);
            Controls.Add(lblUserName);
            Controls.Add(lblBemVindo);
            Name = "frmPrincipal";
            Text = "Menu Principal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBemVindo;
        private Label lblUserName;
        private DataGridView dataGridView1;
    }
}