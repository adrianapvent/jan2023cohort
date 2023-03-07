#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ZoosAndAnimals.Models;

public class Animal {
    [Key]
    public int AnimalId {get; set;}
    // add more attributes here
    public string Species {get; set;}
    public string Diet {get; set;}
    public string Habitat {get; set;}
    
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    List<Assign> AllZoos {get; set;} = new List<Assign>();
}