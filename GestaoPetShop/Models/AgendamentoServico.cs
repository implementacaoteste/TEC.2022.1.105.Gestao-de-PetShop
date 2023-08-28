namespace Models
{
    public class AgendamentoServico
    {
        public int Id { get; set; }
        public string Servico { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public int IdServico { get; set; }
        public int Tempo { get; set; }

    }
}
