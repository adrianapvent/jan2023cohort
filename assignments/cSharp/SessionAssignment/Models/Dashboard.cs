#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace SessionAssignment.Models;

public class Num
{
   [Required]
   [MinLength(3)]
   public int MyNum {get; set;}
}