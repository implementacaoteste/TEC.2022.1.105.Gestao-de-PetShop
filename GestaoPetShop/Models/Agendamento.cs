using System;
using System.Collections.Generic;

namespace Models
{
    public class Agendamento
    {
        public int Id  { get; set; }
        public int IdAnimal { get; set; }
        public string NomeAnimal { get; set; }
        public int IdProfissional { get; set; }
        public string NomeProfissional { get; set; }
        public int IdSituacao { get; set; }
        public string DescricaoSituacao { get; set; }
        public DateTime  DataAg { get; set; }
        public string Horario { get; set; }
        public decimal Total { get; set; }
        public bool Ativo { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public List<AgendamentoServico> AgendamentoServicos { get; set; }
        public Agendamento()
        {
            AgendamentoServicos = new List<AgendamentoServico>();
        }
    }
}
