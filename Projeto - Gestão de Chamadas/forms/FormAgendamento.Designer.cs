namespace Projeto___Gestão_de_Chamadas
{
    partial class FormAgendamento
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
            btnAtendente = new Button();
            dgvChamados = new DataGridView();
            labelTitle3 = new Label();
            btnCadastrar = new Button();
            btnClientes = new Button();
            cmbClientes = new ComboBox();
            cmbAtendente = new ComboBox();
            label1 = new Label();
            labelCliente = new Label();
            labelDescrição = new Label();
            txtDescricao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).BeginInit();
            SuspendLayout();
            // 
            // btnAtendente
            // 
            btnAtendente.BackColor = SystemColors.ButtonFace;
            btnAtendente.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtendente.Location = new Point(531, 59);
            btnAtendente.Name = "btnAtendente";
            btnAtendente.Size = new Size(173, 39);
            btnAtendente.TabIndex = 20;
            btnAtendente.Text = "Gerenciar Atendentes";
            btnAtendente.UseVisualStyleBackColor = false;
            btnAtendente.Click += btnAtendente_Click;
            // 
            // dgvChamados
            // 
            dgvChamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamados.Location = new Point(452, 168);
            dgvChamados.Name = "dgvChamados";
            dgvChamados.RowHeadersWidth = 51;
            dgvChamados.Size = new Size(300, 188);
            dgvChamados.TabIndex = 19;
            // 
            // labelTitle3
            // 
            labelTitle3.AutoSize = true;
            labelTitle3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle3.Location = new Point(341, 54);
            labelTitle3.Name = "labelTitle3";
            labelTitle3.Size = new Size(153, 38);
            labelTitle3.TabIndex = 18;
            labelTitle3.Text = "Chamados";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(115, 296);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.ButtonFace;
            btnClientes.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(132, 59);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(173, 39);
            btnClientes.TabIndex = 21;
            btnClientes.Text = "Gerenciar Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(115, 149);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(151, 28);
            cmbClientes.TabIndex = 22;
            // 
            // cmbAtendente
            // 
            cmbAtendente.FormattingEnabled = true;
            cmbAtendente.Location = new Point(113, 196);
            cmbAtendente.Name = "cmbAtendente";
            cmbAtendente.Size = new Size(151, 28);
            cmbAtendente.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 204);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 24;
            label1.Text = "Atendente :";
            label1.Click += label1_Click;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(45, 157);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(62, 20);
            labelCliente.TabIndex = 25;
            labelCliente.Text = "Cliente :";
            // 
            // labelDescrição
            // 
            labelDescrição.AutoSize = true;
            labelDescrição.Location = new Point(26, 252);
            labelDescrição.Name = "labelDescrição";
            labelDescrição.Size = new Size(81, 20);
            labelDescrição.TabIndex = 26;
            labelDescrição.Text = "Descrição :";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(113, 245);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(125, 27);
            txtDescricao.TabIndex = 27;
            // 
            // FormAgendamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescricao);
            Controls.Add(labelDescrição);
            Controls.Add(labelCliente);
            Controls.Add(label1);
            Controls.Add(cmbAtendente);
            Controls.Add(cmbClientes);
            Controls.Add(btnClientes);
            Controls.Add(btnAtendente);
            Controls.Add(dgvChamados);
            Controls.Add(labelTitle3);
            Controls.Add(btnCadastrar);
            Name = "FormAgendamento";
            Text = "FormAgendamento";
            Load += FormAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChamados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAtendente;
        private DataGridView dgvChamados;
        private Label labelTitle3;
        private Button btnCadastrar;
        private Button btnClientes;
        private ComboBox cmbClientes;
        private ComboBox cmbAtendente;
        private Label label1;
        private Label labelCliente;
        private Label labelDescrição;
        private TextBox txtDescricao;
    }
}