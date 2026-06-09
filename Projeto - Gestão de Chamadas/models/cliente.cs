using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto___Gestão_de_Chamadas.components
{
    public class Cliente
    {
        // Propriedades do cliente ↓
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }

        // O construtor ↓
        public Cliente(int id, string nome, string contato) {
            ID = id;
            Nome = nome;
            Contato = contato;
        }
    }
}
