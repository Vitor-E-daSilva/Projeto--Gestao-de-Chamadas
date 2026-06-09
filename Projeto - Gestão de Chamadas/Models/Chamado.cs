using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto___Gestão_de_Chamadas.components
{
    public class Chamado
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Atendente Atendente { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; } = string.Empty;

        public string Prioridade
        {
            get
            {
                if (Descricao.Contains("Urgente"))
                    return "Alta";
                else if (Descricao.Contains("Importante"))
                    return "Média";
                else
                    return "Baixa";
            }
        }

        public Chamado(int id,
                       Cliente cliente,
                       Atendente atendente,
                       string descricao)
        {
            Id = id;
            Cliente = cliente;
            Atendente = atendente;
            Descricao = descricao;
            Status = "Aberto";
        }
    }
}
