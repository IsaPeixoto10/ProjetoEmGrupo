using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Isoca_linda.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        [Required]
        public int PacoteId { get; set; }

        [ForeignKey("PacoteId")]
        public Pacote Pacote { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataReserva { get; set; }

        [Required]
        public string Status { get; set; } = "Ativa"; // Ativa ou Cancelada
    }
}
