using System.ComponentModel.DataAnnotations;

namespace BudgetCalculator.Core.ValidationAttributes
{
    public class ValidateAmount : ValidationAttribute
    {
        private const decimal minAmount = 0;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is decimal))
            {
                throw new ValidationException("The must be a positive decimal number.");
            }

            if ((int)value < minAmount)
            {
                return new ValidationResult("Amount cannot be negative.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
