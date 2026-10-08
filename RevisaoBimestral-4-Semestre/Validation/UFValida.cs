using System.ComponentModel.DataAnnotations;

namespace RevisaoBimestral.Validation
{
    public class UFValida : ValidationAttribute
    {
        protected override ValidationResult IsValid(
            object value,
            ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("A UF é obrigatória.");
            }

            string uf = value.ToString().ToUpper();

            if (uf == "MG" || uf == "SP" || uf == "RJ" || uf == "ES")
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(
                "A UF deve ser MG, SP, RJ ou ES."
            );
        }
    }
}