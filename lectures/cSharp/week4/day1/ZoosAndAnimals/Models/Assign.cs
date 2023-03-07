#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ZoosAndAnimals.Models;

public class Assign {
    [Key]
    public int AssignId {get; set;}
    public int Count {get; set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int ZooId {get; set;}
    public Zoo? TheZoo {get; set;}
    public int AnimalId {get; set;}
    public Animal? TheAnimal {get; set;}
}