#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyValidation.Models;

public class User
{
    [Required(ErrorMessage="Name is required")]
    [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
    public string Name {get; set;}

    [Required(ErrorMessage="A location input is required")]
    public string Location {get; set;}

    [Required(ErrorMessage="A language input is required")]
    public string Language {get; set;}

    [MinLength(20, ErrorMessage="Comments are optional. If you wish to provide comments it must be at least 20 characters in length.")]
    public string? message {get; set;}
}