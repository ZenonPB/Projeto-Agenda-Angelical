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
            gridCat = new DataGridView();
            btnAdd = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCat).BeginInit();
            SuspendLayout();
            // 
            // gridCat
            // 
            gridCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCat.Location = new Point(36, 12);
            gridCat.Name = "gridCat";
            gridCat.Size = new Size(352, 374);
            gridCat.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 255, 192);
            btnAdd.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(36, 392);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(167, 46);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 192, 192);
            btnRemove.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(221, 392);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(167, 46);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remover";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // frmAddCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(427, 450);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(gridCat);
            Name = "frmAddCat";
            Text = "Adicionar Categorias";
            ((System.ComponentModel.ISupportInitialize)gridCat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCat;
        private Button btnAdd;
        private Button btnRemove;
    }
}