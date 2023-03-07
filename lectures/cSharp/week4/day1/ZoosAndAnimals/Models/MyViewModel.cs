#pragma warning disable CS8618
namespace ZoosAndAnimals.Models;
public class MyViewModel
{    
    public Zoo Zoo {get;set;}
    public List<Zoo> AllZoos {get; set;}
    public User User {get; set;}
    public List<User> AllUsers {get;set;}
    public Animal Animal {get;set;}
    public List<Animal> AllAnimals {get;set;}

    public List<Assign> ZooWithAnimals {get;set;}
    public List<Assign> AnimalsWithZoo {get;set;}
}
