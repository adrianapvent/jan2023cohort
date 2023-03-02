#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LogReg.Models;

public class User {
    [Key]
    public int UserId {get; set;}
    [Required]
    [Display(Name="First Name")] // If using asp-for in label this lets you customize what the label shows
    public string FirstName {get; set;}

    [Required]
    public string LastName {get; set;}

    [Required]
    [EmailAddress] // Set the type of email
    [UniqueEmail]
    public string Email {get; set;}
    [Required]
    [DataType(DataType.Password)] // auto fills input type of password (specifically when using asp)
    public string Password {get; set;}

    [NotMapped] // please don't add me to the database
    [Compare("Password", ErrorMessage="Dang it passwords don't match try your luck again")]
    public string Confirm {get; set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
public class UniqueEmailAttribute : ValidationAttribute {
    protected override ValidationResult? IsValid(object? value, ValidationContext valContext) {
        if(value == null) { // if email input is empty
            return new ValidationResult("Email is required");
        }
        MyContext _context = (MyContext)valContext.GetService(typeof(MyContext));
        if(_context.Users.Any(e => e.Email == value.ToString())) {
            return new ValidationResult("Email is in use"); // if email is in database
        } else {
            return ValidationResult.Success; // email not in database good to go
        }
    }
}