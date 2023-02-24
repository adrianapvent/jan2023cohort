#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace SecondVersion.Models;

public class Owner
{
   [Required]
   [MinLength(3)]
   public string Name {get; set;}
}