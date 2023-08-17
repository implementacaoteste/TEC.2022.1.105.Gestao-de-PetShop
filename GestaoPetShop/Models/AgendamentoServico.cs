using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AgendamentoServico
    {

        public int Id { get; set; }
        public string Servico { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorComDesconto { get; set; }
        public decimal ValorTotal { get; set; }
        public int IdServico { get; set; }
        public int Tempo { get; set; }

    }
}
