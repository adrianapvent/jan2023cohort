#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ZoosAndAnimals.Models;

public class Zoo {
    [Key]
    public int ZooId {get; set;}
    public string Name {get; set;}
    public string Location {get; set;}
    // add more attributes here

    // ******* One to Many
    public int UserId {get; set;}
    public User? Owner {get; set;}

// *********  Many to Many
public List<Assign> AllAnimals {get; set;} = new List<Assign>(); 

    
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}