using Projeto___Gestão_de_Chamadas.components;
using Projeto___Gestão_de_Chamadas.dados;
using System;

namespace Projeto___Gestão_de_Chamadas
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void BotaoCadastroCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(Banco.Clientes.Count + 1, textBoxNome.Text, textBoxContato.Text);

            Banco.Clientes.Add(cliente);

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Banco.Clientes;

            textBoxNome.Clear();
            textBoxContato.Clear();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtendente_Click(object sender, EventArgs e)
        {
            FormAtendentes formAtendente = new FormAtendentes();

            formAtendente.Show();
            this.Hide();
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            FormAgendamento formAgendamento = new FormAgendamento();

            formAgendamento.Show();
            this.Hide();
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }
    }
}
