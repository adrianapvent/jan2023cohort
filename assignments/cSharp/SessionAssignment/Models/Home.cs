#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace SessionAssignment.Models;

public class Username
{
    [Required(ErrorMessage="You must enter a name")]
    [MinLength(2, ErrorMessage="You must use at least 2 characters")]
    public string name {get; set;}
}
