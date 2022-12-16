namespace projeto_final.Models
{
    public class CarrosModel : Carros
    {

        public List<Categoria> ListaCategorias { get; set; }
        public List<Carros> ListaCarros { get; set; }

        public string[] arrayCarro { get; set; }
    }
}
