using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DateTime  DataAg { get; set; }
        public int Horario { get; set; }
        public int Total { get; set; }
        public bool Ativo { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public List<AgendamentoServico> agendamentoServicos { get; set; }
    }
}
