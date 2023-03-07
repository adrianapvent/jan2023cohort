using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ZoosAndAnimals.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace ZoosAndAnimals.Controllers;

public class AnimalController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public AnimalController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    
    // Recommend routeName and FunctionName be the same
    
    [HttpGet("/animal/dashboard")]
    public IActionResult AnimalDashboard() {
        List<Animal> allTheAnimals = db.Animals
            .OrderBy(a => a.Habitat)
            .ToList();
        return View("AnimalDashboard", allTheAnimals);
    }
    [HttpGet("/animal/addAnimal")]
    public IActionResult AddAnimal() {
        return View("AddAnimal");
    }
    
    [HttpPost("/animal/createAnimal")]
    public IActionResult CreateAnimal(Animal a) {
        if(ModelState.IsValid) {
            db.Animals.Add(a);
            db.SaveChanges();
            return Redirect("/animal/dashboard");
        }
        return View("AddAnimal");
    }
}