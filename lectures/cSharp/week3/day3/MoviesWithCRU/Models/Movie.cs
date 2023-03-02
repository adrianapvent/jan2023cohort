#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace MoviesWithCRU.Models;

public class Movie {
    [Key]
    public int MovieId {get; set;}
    // add more attributes here
    [Required]
    public string Title {get; set;}
    [Required]
    public string Genre {get; set;}
    [Required]
    public int Year {set; get;}
    [Required]
    public int Rating {set; get;}
    [Required]
    public string Img {get; set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}