#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PostReplyLike.Models;

public class Reply {
    [Key]
    public int ReplyId {get; set;}
    // add more attributes here
    public string Word {get; set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

// **** This is a many to many only table so it needs to just have the id's for both and connect with a name
    public int UserId {get; set;}
    public User? User {get; set;}

    public int PostId {get; set;}
    public Post? Post {get; set;}


}