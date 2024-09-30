namespace Locacoes.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public DateOnly DataLocacao { get; set; }
        public decimal ValorTotal { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
