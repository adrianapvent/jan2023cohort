#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRViewOneApp.Models;

public class Crochet {
    [Key]
    public int CrochetId {get; set;}
    [Required]
    public string Name {get; set;}
    [Required]
    public string Description {get; set;}
    [Required]
    public string Img {get; set;}
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now; 
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}