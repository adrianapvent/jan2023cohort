#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstDB.Models;

public class Squishy {
    [Key]
    public int SquishyId {get; set;} // Auto generated Id
    public string Name {get; set;}
    public string Img {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now; // Auto Generated
    public DateTime UpdatedAt { get; set; } = DateTime.Now; // Auto Generated
}