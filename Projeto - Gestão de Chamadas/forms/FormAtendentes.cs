using Projeto___Gestão_de_Chamadas.components;
using Projeto___Gestão_de_Chamadas.dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto___Gestão_de_Chamadas
{
    public partial class FormAtendentes : Form
    {
        public FormAtendentes()
        {
            InitializeComponent();
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();

            formCliente.Show();
            this.Hide();
        }

        private void btnChamado_Click(object sender, EventArgs e)
        {
            FormAgendamento formAgendamento = new FormAgendamento();

            formAgendamento.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente(Banco.Atendentes.Count + 1,txtNome.Text,txtSetor.Text);

            Banco.Atendentes.Add(atendente);

            dgvAtendente.DataSource = null;
            dgvAtendente.DataSource = Banco.Atendentes;

            txtNome.Clear();
            txtSetor.Clear();
        }
    }
}
