using System.ComponentModel.DataAnnotations;

namespace RevisaoBimestral.Models
{
    public class Ausencia
    {
        [Required]
        public string CPF { get; set; }

        [Required]
        [Range(1, 2)]
        public int Turno { get; set; }

        [Required]
        public string Justificativa { get; set; }
    }
}