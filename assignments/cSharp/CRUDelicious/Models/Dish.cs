#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models;

public class Dish {
    [Key]
    public int DishId { get; set; }

    [Required(ErrorMessage = "Name of Dish is Required")]
    [MinLength(3)]
    [Display(Name= "Name of Dish")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Chef's Name is Required")]
    [MinLength(2)]
    [Display(Name = "Chef's Name:")]
    public string Chef { get; set; }

    [Required]
    [Range (1, 5, ErrorMessage = "Tastiness range is from 1 to 5")]
    public int? Tastiness { get; set; }

    [Required]
    [Range(1, 5000, ErrorMessage = "Calories must be input")]
    [Display(Name = "Enter number of Calories:")]
    public int? Calories { get; set; }

    [Required(ErrorMessage= "A description is required")]
    [MinLength(3, ErrorMessage= "Description must be at least 3 characters")]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}