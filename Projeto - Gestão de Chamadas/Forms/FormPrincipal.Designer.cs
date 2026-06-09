namespace Projeto___Gestão_de_Chamadas.Forms
{
    partial class FormPrincipal
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
            label1 = new Label();
            btnDashboard = new Button();
            btnCliente = new Button();
            btnAtendente = new Button();
            btnChamado = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-5, -1);
            label1.Name = "label1";
            label1.Size = new Size(808, 72);
            label1.TabIndex = 0;
            label1.Text = "Gestão de Chamados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DodgerBlue;
            btnDashboard.Location = new Point(98, 87);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(142, 59);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Visualizador";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.ActiveCaption;
            btnCliente.Location = new Point(493, 98);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(250, 50);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Gerenciar Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnClientes_Click;
            // 
            // btnAtendente
            // 
            btnAtendente.BackColor = SystemColors.ActiveCaption;
            btnAtendente.Location = new Point(493, 174);
            btnAtendente.Name = "btnAtendente";
            btnAtendente.Size = new Size(250, 50);
            btnAtendente.TabIndex = 3;
            btnAtendente.Text = "Gerenciar Atendentes";
            btnAtendente.UseVisualStyleBackColor = false;
            btnAtendente.Click += btnAtendente_Click;
            // 
            // btnChamado
            // 
            btnChamado.BackColor = SystemColors.ActiveCaption;
            btnChamado.Location = new Point(493, 250);
            btnChamado.Name = "btnChamado";
            btnChamado.Size = new Size(250, 50);
            btnChamado.TabIndex = 4;
            btnChamado.Text = "Gerenciar Chamados";
            btnChamado.UseVisualStyleBackColor = false;
            btnChamado.Click += btnChamados_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(22, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 251);
            panel1.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 350);
            Controls.Add(panel1);
            Controls.Add(btnChamado);
            Controls.Add(btnAtendente);
            Controls.Add(btnCliente);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnDashboard;
        private Button btnCliente;
        private Button btnAtendente;
        private Button btnChamado;
        private Panel panel1;
    }
}