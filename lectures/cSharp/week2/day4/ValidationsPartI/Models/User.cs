// Don't forget to disable the warnings!
// #pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
// namespace ValidationsPartI.Models;
public class User
{    
    // Each property in a model gets its own set of DataAnnotations
    // Each annotation applies only to the property that is directly below it
    [Required(ErrorMessage="Username is required")]   
    // We can stack annotations to apply multiple requirements to one property
    // In this case, a Username is required but must also be at least 3 characters long 
    [MinLength(3, ErrorMessage="Username must be at least 3 characters long")]    
    public string Username { get; set; }     
    // Notice how we must use [Required] again here to apply to the next property
    [Required]   
    // This will apply a standard Email format regex to this property 
    [EmailAddress]    
    public string Email { get; set; }
    [Required]
    [MinLength(2)]
    public string FavFood {get; set;}     
    
    [Required]    
    // You will see what the [DataType] annotation does when we get over to making our form
    [DataType(DataType.Password)]    
    public string Password { get; set; } 
}
