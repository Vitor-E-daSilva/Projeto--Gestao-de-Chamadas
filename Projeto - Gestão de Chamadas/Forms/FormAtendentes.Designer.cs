namespace Projeto___Gestão_de_Chamadas
{
    partial class FormAtendentes
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
            dgvAtendente = new DataGridView();
            labelTitle2 = new Label();
            labelEmail = new Label();
            labelNome = new Label();
            txtSetor = new TextBox();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAtendente).BeginInit();
            SuspendLayout();
            // 
            // dgvAtendente
            // 
            dgvAtendente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtendente.Location = new Point(461, 138);
            dgvAtendente.Name = "dgvAtendente";
            dgvAtendente.RowHeadersWidth = 51;
            dgvAtendente.Size = new Size(300, 231);
            dgvAtendente.TabIndex = 19;
            // 
            // labelTitle2
            // 
            labelTitle2.BackColor = SystemColors.Highlight;
            labelTitle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle2.Location = new Point(-4, -2);
            labelTitle2.Name = "labelTitle2";
            labelTitle2.Size = new Size(831, 91);
            labelTitle2.TabIndex = 18;
            labelTitle2.Text = "Atendentes";
            labelTitle2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(69, 240);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 20);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Setor :";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(65, 186);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(57, 20);
            labelNome.TabIndex = 15;
            labelNome.Text = "Nome :";
            // 
            // txtSetor
            // 
            txtSetor.Location = new Point(132, 233);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(217, 27);
            txtSetor.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(155, 291);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(132, 183);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(217, 27);
            txtNome.TabIndex = 23;
            // 
            // FormAtendentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(txtNome);
            Controls.Add(dgvAtendente);
            Controls.Add(labelTitle2);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(txtSetor);
            Controls.Add(btnCadastrar);
            Name = "FormAtendentes";
            Text = "FormAtendentes";
            ((System.ComponentModel.ISupportInitialize)dgvAtendente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvAtendente;
        private Label labelTitle2;
        private Label labelTelefone;
        private Label labelEmail;
        private Label labelNome;
        private TextBox textBoxNome;
        private TextBox textBoxTelefone;
        private TextBox txtSetor;
        private Button btnCadastrar;
        private TextBox txtNome;
    }
}