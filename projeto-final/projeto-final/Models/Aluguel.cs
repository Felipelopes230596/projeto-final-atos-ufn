namespace projeto_final.Models
{
    public class Aluguel
    {
        public int id { get; set; }
        public string quantidadeDiarias { get; set; }
        public double valorTotal { get; set; }
        public virtual Clientes cliente { get; set; }
        public virtual Categoria Categoria { get; set; }
        
    }
}
