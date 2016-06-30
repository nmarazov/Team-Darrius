namespace BudgetCalculator.Core.Family
{
    using System.ComponentModel.DataAnnotations;

    public class ValidateAgeAttribute : ValidationAttribute
    {
        private const int minAge = 0;
        private const int maxAge = 130;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is int))
            {
                throw new ValidationException("The must be a positive integer.");
            }

            if ((int)value < minAge)
            {
                return new ValidationResult("Age cannot be negative.");
            }
            else if ((int)value > maxAge)
            {
                return new ValidationResult("Age is to high.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}