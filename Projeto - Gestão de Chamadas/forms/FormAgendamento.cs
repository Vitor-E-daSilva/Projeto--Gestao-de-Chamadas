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
    public partial class FormAgendamento : Form
    {
        public FormAgendamento()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();

            formCliente.Show();
            this.Hide();
        }

        private void btnAtendente_Click(object sender, EventArgs e)
        {
            FormAtendentes formAtendente = new FormAtendentes();

            formAtendente.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarGrid()
        {
            dgvChamados.DataSource = null;

            dgvChamados.DataSource =
                Banco.Chamados
                     .Where(c => c.Status == "Aberto")
                     .ToList();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbClientes.SelectedItem;

            Atendente atendente = (Atendente)cmbAtendente.SelectedItem;

            Chamado chamado = new Chamado(
                Banco.Chamados.Count + 1,
                cliente,
                atendente,
                txtDescricao.Text
            );

            Banco.Chamados.Add(chamado);

            AtualizarGrid();

            txtDescricao.Clear();
        }

        private void FormAgendamento_Load(object sender, EventArgs e)
        {
            cmbClientes.DataSource = Banco.Clientes;
            cmbClientes.DisplayMember = "Nome";

            cmbAtendente.DataSource = Banco.Atendentes;
            cmbAtendente.DisplayMember = "Nome";

        }
    }
}
