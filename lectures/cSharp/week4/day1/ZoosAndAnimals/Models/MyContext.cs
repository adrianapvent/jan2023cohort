#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace ZoosAndAnimals.Models;

public class MyContext : DbContext 
{    
    public MyContext(DbContextOptions options) : base(options) { }    
   
    public DbSet<User> Users { get; set; } 
    public DbSet<Zoo> Zoos {get; set;}
    public DbSet<Animal> Animals {get; set;}
}