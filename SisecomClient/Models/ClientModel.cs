using System.ComponentModel.DataAnnotations;

namespace SisecomClient.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome/Razão Social")]    
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o Nome Abreviado/Nome Fantasia")]
        public string Abreviado { get; set; }
        [Required(ErrorMessage = "Digite o e-mail de contato!")]
        [EmailAddress(ErrorMessage = "O E-mail informado não é valido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o telefone de contato")]
        [Phone(ErrorMessage = "O telefone informado não é valido!")]
        public string Telefone { get; set; }        
    }
}
