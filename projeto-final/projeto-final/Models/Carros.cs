namespace projeto_final.Models
{
    public class Carros
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int categoriaId { get; set; } 
        public Categoria categoria { get; set; }
    }
}
