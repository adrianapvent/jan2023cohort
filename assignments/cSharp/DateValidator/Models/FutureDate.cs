#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DateValidator.Models;

public class FutureDateAttribute : ValidationAttribute 
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime InputDate = Convert.ToDateTime(value);

        if (DateTime.Now < (DateTime)value) {
            return new ValidationResult ("No future dates are allowed");
        } else
        {
            return ValidationResult.Success;
        }
    }
}