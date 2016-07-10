using System;
using System.ComponentModel.DataAnnotations;

namespace BudgetCalculator.Core.Family
{
    public class ValidateNameAttribute : ValidationAttribute
    {
        private const int minLength = 3;
        private const int maxLength = 50;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is string))
            {
                throw new ValidationException("The must be a literal.");
            }

            if (value.ToString().Length < minLength)
            {
                return new ValidationResult("Name cannot be shorter than 3 characters.");
            }
            else if (value.ToString().Length > maxLength)
            {
                return new ValidationResult("Name cannot be longer than 50 characters.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
