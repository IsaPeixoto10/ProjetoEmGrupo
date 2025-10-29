using System.ComponentModel.DataAnnotations;

namespace Projeto_Isoca_linda.Models
<<<<<<< HEAD
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 dígitos")]
        public string CPF { get; set; }

        public string Telefone { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido")]
        public string Email { get; set; }

        public string Endereco { get; set; }
    }
}
=======
{   
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Telefone { get; set; }

        // Relacionamento
        public ICollection<Reserva>? Reservas { get; set; }
    }
}
>>>>>>> Ryan
