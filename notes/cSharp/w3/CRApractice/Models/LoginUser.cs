#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRApractice.Models;

[NotMapped] // don't send to database
public class LoginUser{
    [Required]
    [EmailAddress]
    [Display(Name ="Email")]
    public string LoginEmail {get; set;}

    [Required]
    [DataType(DataType.Password)] // auto fills input type attr
    [Display(Name = "Password")]
    public string LoginPassword { get; set; }
}