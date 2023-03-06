#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OneToMany.Models;

public class Monster {
    [Key]
    public int MonsterId {get; set;}
    [Required]
    public string Name {get; set;}
    [Required]
    public string Img {get; set;}
    public string Hidden {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int UserId {get; set;} // this FK needs to match the User class's PK
    public User? Owner {get; set;} // 1 user related to each Monster

}