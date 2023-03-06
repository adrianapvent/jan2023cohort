#pragma warning disable CS8618 

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class SpecialPassword : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return ValidationResult.Success;
        }
        var pass = (string)value;
        bool hasUpper = false;
        bool hasLower = false;
        bool hasSpec = false;
        bool hasNum = false;
        char letter; 
        int i = 0;
        while (i < pass.Length)
        {
            letter = pass[i];
            if (char.IsDigit(letter))
            {
                hasNum = true;
            }
            if (char.IsLower(letter))
            {
                hasLower = true;
            }
            if (char.IsUpper(letter))
            {
                hasUpper = true;
            }
            if (char.IsLetterOrDigit(letter))
            {
                hasSpec = true;
            }
            //i+=1;
            if (hasNum && hasLower && hasUpper && hasSpec)
            {
                return ValidationResult.Success;
            }
            i++;
        }
        return new ValidationResult("must contain at least 1 uppercase, lowercase, number, and special character.");
    }
}