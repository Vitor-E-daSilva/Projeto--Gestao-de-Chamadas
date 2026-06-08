using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto___Gestão_de_Chamadas
{
    internal class Cliente
    {
        // Propriedades do cliente ↓
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        // O construtor ↓
        public Cliente(string nome, string email, string numero) {
            Nome = nome;
            Email = email;  
            Telefone = numero;
        }
    }
}
