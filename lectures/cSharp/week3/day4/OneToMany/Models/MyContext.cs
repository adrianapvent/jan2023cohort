#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace OneToMany.Models;

public class MyContext : DbContext 
{    
    public MyContext(DbContextOptions options) : base(options) { }    
   
    public DbSet<User> Users { get; set; } 
    public DbSet<Monster> Monsters {get; set;}
}