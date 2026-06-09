namespace Projeto___Gestão_de_Chamadas
{
    partial class FormCliente
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
            BotaoCadastroCliente = new Button();
            textBoxContato = new TextBox();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelContato = new Label();
            labelTitle1 = new Label();
            dgvClientes = new DataGridView();
            btnAtendente = new Button();
            btnChamados = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // BotaoCadastroCliente
            // 
            BotaoCadastroCliente.Location = new Point(137, 241);
            BotaoCadastroCliente.Name = "BotaoCadastroCliente";
            BotaoCadastroCliente.Size = new Size(94, 29);
            BotaoCadastroCliente.TabIndex = 0;
            BotaoCadastroCliente.Text = "Cadastrar";
            BotaoCadastroCliente.UseVisualStyleBackColor = true;
            BotaoCadastroCliente.Click += BotaoCadastroCliente_Click;
            // 
            // textBoxContato
            // 
            textBoxContato.Location = new Point(137, 180);
            textBoxContato.Name = "textBoxContato";
            textBoxContato.Size = new Size(217, 27);
            textBoxContato.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(137, 126);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(217, 27);
            textBoxNome.TabIndex = 3;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(70, 133);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(57, 20);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome :";
            labelNome.Click += labelNome_Click;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Location = new Point(58, 187);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(69, 20);
            labelContato.TabIndex = 5;
            labelContato.Text = "Contato :";
            // 
            // labelTitle1
            // 
            labelTitle1.AutoSize = true;
            labelTitle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle1.Location = new Point(346, 28);
            labelTitle1.Name = "labelTitle1";
            labelTitle1.Size = new Size(120, 38);
            labelTitle1.TabIndex = 7;
            labelTitle1.Text = "Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(378, 115);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(379, 188);
            dgvClientes.TabIndex = 8;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAtendente
            // 
            btnAtendente.BackColor = SystemColors.ButtonFace;
            btnAtendente.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtendente.Location = new Point(499, 28);
            btnAtendente.Name = "btnAtendente";
            btnAtendente.Size = new Size(173, 39);
            btnAtendente.TabIndex = 9;
            btnAtendente.Text = "Gerenciar Atendentes";
            btnAtendente.UseVisualStyleBackColor = false;
            btnAtendente.Click += btnAtendente_Click;
            // 
            // btnChamados
            // 
            btnChamados.BackColor = SystemColors.ButtonFace;
            btnChamados.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamados.Location = new Point(137, 33);
            btnChamados.Name = "btnChamados";
            btnChamados.Size = new Size(173, 39);
            btnChamados.TabIndex = 11;
            btnChamados.Text = "Gerenciar Chamados";
            btnChamados.UseVisualStyleBackColor = false;
            btnChamados.Click += btnChamados_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(247, 241);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnChamados);
            Controls.Add(btnAtendente);
            Controls.Add(dgvClientes);
            Controls.Add(labelTitle1);
            Controls.Add(labelContato);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxContato);
            Controls.Add(BotaoCadastroCliente);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotaoCadastroCliente;
        private TextBox textBoxContato;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelContato;
        private Label labelTitle1;
        private DataGridView dgvClientes;
        private Button btnAtendente;
        private Button btnChamados;
        private Button btnExcluir;
    }
}
