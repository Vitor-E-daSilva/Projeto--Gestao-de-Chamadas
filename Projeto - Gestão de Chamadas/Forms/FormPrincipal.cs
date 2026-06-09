using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto___Gestão_de_Chamadas.Forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAtendente_Click(object sender, EventArgs e)
        {
            FormAtendentes formAtendente = new FormAtendentes();

            formAtendente.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            FormAgendamento formAgendamento = new FormAgendamento();
            formAgendamento.Show();
        }
    }
}
