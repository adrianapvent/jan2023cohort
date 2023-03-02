#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace MoviesWithCRU.Models;

public class MyContext : DbContext 
{    
    public MyContext(DbContextOptions options) : base(options) { }    
   
    public DbSet<Movie> Movies { get; set; } 
}