using Microsoft.AspNetCore.Mvc.Rendering;

namespace projeto_final.Models
{
    public class AlugarModel : Aluguel
    {
        public Categoria categoria { get; set; }        
        public List<Clientes> listaClientes { get; set; }
        public List<Categoria> listaCategorias { get; set; }
        public List<Aluguel> listaAluguel { get; set; }
        
    }
}
