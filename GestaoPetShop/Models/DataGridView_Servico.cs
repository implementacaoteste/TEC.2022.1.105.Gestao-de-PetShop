using System;

namespace Models
{
    public class DataGridView_Servico
    {
        public int Id { get; set; }
        public string Servico { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorComDesconto { get; set; }
        public decimal ValorTotal { get; set; }

       
    }
}
