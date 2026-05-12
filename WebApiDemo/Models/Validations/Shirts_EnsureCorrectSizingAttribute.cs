using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models.Validations
{
    public class Shirts_EnsureCorrectSizingAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            var shirt = validationContext.ObjectInstance as Shirt;
            if (shirt != null && !string.IsNullOrWhiteSpace(shirt.Gender)) {

                if (shirt.Gender.Equals("men", StringComparison.OrdinalIgnoreCase) && shirt.Size < 8) {
                    return new ValidationResult("For men's shirt size has to be greater or eqaul to 8.");
                }
                else if (shirt.Gender.Equals("women", StringComparison.OrdinalIgnoreCase) && shirt.Size < 6) {
                    return new ValidationResult("For women's shirt size has to be greater or eqaul to 6.");
                }
            }

            return ValidationResult.Success;
        }

    }
}
