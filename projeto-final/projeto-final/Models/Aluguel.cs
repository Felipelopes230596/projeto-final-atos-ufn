namespace projeto_final.Models
{
    public class Aluguel
    {
        public int id { get; set; }
        public DateTime dataInicial { get; set; }
        public DateTime dataFinal { get; set; }
        public double valorTotal { get; set; }
        public virtual Clientes cliente { get; set; }
        public virtual Carros carro { get; set; }
    }
}
