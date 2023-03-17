#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;
namespace DateValidator.Models;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (!(value is DateTime))
        {
            return new ValidationResult("Not a valid date");
        }

        DateTime d1 = DateTime.Now;
        DateTime d2 = (DateTime)value;

        if (d1 < d2)
        {
            return new ValidationResult("You cannot input a future date. Please check this and resubmit.");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}

// DateTime InputDate = Convert.ToDateTime(value);

// if (DateTime.Now < (DateTime)value) {
//     return new ValidationResult ("No future dates are allowed");
// } else
// {
//     return ValidationResult.Success;
// }