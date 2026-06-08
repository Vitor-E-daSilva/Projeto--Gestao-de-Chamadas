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
            textBoxEmail = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelEmail = new Label();
            labelTelefone = new Label();
            labelTitle1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BotaoCadastroCliente
            // 
            BotaoCadastroCliente.Location = new Point(137, 274);
            BotaoCadastroCliente.Name = "BotaoCadastroCliente";
            BotaoCadastroCliente.Size = new Size(94, 29);
            BotaoCadastroCliente.TabIndex = 0;
            BotaoCadastroCliente.Text = "Cadastrar";
            BotaoCadastroCliente.UseVisualStyleBackColor = true;
            BotaoCadastroCliente.Click += BotaoCadastroCliente_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(137, 155);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(217, 27);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.Text = "exemplo@email.com";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(137, 205);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(217, 27);
            textBoxTelefone.TabIndex = 2;
            textBoxTelefone.Text = "79912345678";
            textBoxTelefone.TextChanged += textBoxTelefone_TextChanged;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(137, 101);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(217, 27);
            textBoxNome.TabIndex = 3;
            textBoxNome.Text = "Seu nome";
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(74, 108);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(57, 20);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome :";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(74, 162);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(53, 20);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email :";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(54, 212);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(73, 20);
            labelTelefone.TabIndex = 6;
            labelTelefone.Text = "Telefone :";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(457, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(labelTitle1);
            Controls.Add(labelTelefone);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxEmail);
            Controls.Add(BotaoCadastroCliente);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotaoCadastroCliente;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefone;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelTitle1;
        private DataGridView dataGridView1;
    }
}
