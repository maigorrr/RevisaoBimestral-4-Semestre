using System.ComponentModel.DataAnnotations;
using RevisaoBimestral.Validation;

namespace RevisaoBimestral.Models
{
    public class Eleitor
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11)]
        public string CPF { get; set; }

        [Required]
        [StringLength(50)]
        public string TituloEleitor { get; set; }

        [Required]
        [UFValida]
        public string UF { get; set; }
    }
}