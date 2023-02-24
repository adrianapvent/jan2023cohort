#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace SecondVersion.Models;

public class Pet
{
    [Required(ErrorMessage="You must enter a name")]
    [MinLength(2, ErrorMessage="You must use at least 2 characters")]
    public string Name {get; set;}
}