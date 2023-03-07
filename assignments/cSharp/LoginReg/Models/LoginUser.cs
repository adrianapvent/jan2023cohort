#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models;

[NotMapped] // don't add column to database
public class LoginUser
{
    [Required(ErrorMessage = "is required.")]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LoginEmail { get; set; }

    [Required(ErrorMessage = "is required.")]
    [DataType(DataType.Password)] // auto fills input type attr
    [Display(Name = "Password")]
    public string LoginPassword { get; set; }
}