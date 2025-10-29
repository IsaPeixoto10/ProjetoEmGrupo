using System.ComponentModel.DataAnnotations;

namespace Projeto_Isoca_linda.Models
{
    public class Pacote
    {
            public int PacoteId { get; set; }

            [Required]
            public string Nome { get; set; }

            [Required]
            public string Destino { get; set; }

            [Required]
            [DataType(DataType.Currency)]
            public decimal Preco { get; set; }

            [Required]
            public int VagasTotais { get; set; }

            [Required]
            public int VagasDisponiveis { get; set; }

            // Relacionamento
  }
}
