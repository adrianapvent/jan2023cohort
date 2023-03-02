#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace LogReg.Models;

public class Monster {
    [Key] // denotes PK, not needed if names ModelNameId
    public int MonsterId {get; set;}

    [Required(ErrorMessage="Hey you give your Monster it's name will ya")]
    public string Name {get; set;}

    [Required(ErrorMessage="Please let us know what it looks like")]
    public string Img {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}