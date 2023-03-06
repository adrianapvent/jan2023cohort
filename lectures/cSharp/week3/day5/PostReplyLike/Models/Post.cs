#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PostReplyLike.Models;

public class Post {
    [Key]
    public int PostId {get; set;}
    public string Title {get; set;}
    public string Content {get; set;}
    // add more attributes here
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


// ****** One to Many
    public int UserId {get; set;}
    public User? Author {get; set;}


// ******* Many to Many
    public List<Reply> Comment {get; set;} = new List<Reply>(); 
}