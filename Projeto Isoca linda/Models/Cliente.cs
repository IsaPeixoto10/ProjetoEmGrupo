using System.ComponentModel.DataAnnotations;

namespace Projeto_Isoca_linda.Models
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