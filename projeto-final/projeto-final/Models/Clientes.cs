using System.ComponentModel.DataAnnotations;

namespace projeto_final.Models
{
    public class Clientes
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Digite o nome do cliente")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Digite o CPF do cliente")]        
        public string cpf { get; set; }
        [Required(ErrorMessage = "Digite o Telefone do cliente")]
        [Phone(ErrorMessage ="O Telefone informado não é válido")]
        public string telefone { get; set; }

    }
}
