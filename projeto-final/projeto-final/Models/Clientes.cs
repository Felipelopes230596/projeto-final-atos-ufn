using System.ComponentModel.DataAnnotations;

namespace projeto_final.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }       
        public string cpf { get; set; }
        public string telefone { get; set; }

    }
}
