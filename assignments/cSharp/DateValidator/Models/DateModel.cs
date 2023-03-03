#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DateValidator.Models;

public class Form {
    [FutureDate]
    [Required]
    public DateTime Date { get; set; }
}