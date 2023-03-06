#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PostMock.Models;

public class Post {
    [Key]
    public int PostId {get; set;}
    [Required]
    [MinLength(3, ErrorMessage="Title must be at least 3 characters long")] 
    public string Title {get; set;}

    [Required]
    [MinLength(3, ErrorMessage="Title must be at least 3 characters long")] 
    public string Content {get; set;}
    // add more attributes here
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int UserId {get; set;}
    public User? Author {get; set;} 
}