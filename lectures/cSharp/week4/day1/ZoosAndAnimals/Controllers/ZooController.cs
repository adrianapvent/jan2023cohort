using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ZoosAndAnimals.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace ZoosAndAnimals.Controllers;

public class ZooController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public ZooController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    
    // Recommend routeName and FunctionName be the same
    [SessionCheck]
    [HttpGet("/zoo/dashboard")]
    public IActionResult Dashboard() {
        List<Zoo> allTheZoos = db.Zoos
            .Include(o => o.Owner)
            // .Include(z => z.AllAnimals)
            // .ThenInclude(a => a.TheAnimal)
            // .ThenInclude(theA => theA.AllZoos)
            // .OrderBy(z => z.Location)
            .ToList();

        return View("Dashboard", allTheZoos);
    }
    [SessionCheck]
    [HttpGet("/zoo/addZoo")]
    public IActionResult AddZoo() {
        MyViewModel theUsers = new MyViewModel {
            AllUsers = db.Users.ToList()
        };
        return View("AddZoo", theUsers);
        // return View("AddZoo");
    }

    [SessionCheck]
    [HttpPost("/zoo/createZoo")]
    public IActionResult CreateZoo(Zoo z) {
        Console.WriteLine($"uid: {uid}, z.Name: {z.Name}, z.Location: {z.Location}");
        // z.UserId = (int)uid;
        if(ModelState.IsValid) {
            db.Zoos.Add(z);
            db.SaveChanges();
            return Redirect("Dashboard");
        }
        return View("AddZoo");
    }

    // [SessionCheck]
    // [HttpGet("/zoo/{zooId}/viewZoo")]
    // public IActionResult ViewZoo(int theZoo) {
    //     MyViewModel zooInfo = new MyViewModel {
    //         Zoo? aZoo = db.Zoos
    //             .Include(o => o.Owner)
    //             // .Include(m => m.AllAnimals)
    //             // .Where(z => (int)z.ZooId)
    //             .ToList()
    //     };
    //     return View("ViewZoo");
    // }

    // [SessionCheck]
    // [HttpGet("/zoo/{zooId}/editZoo")]
    // public IActionResult EditZoo() {
        
    // }
    // [SessionCheck]
    // [HttpPost("/zoo/{zooId}/updateZoo")]
    // public IActionResult UpdateZoo() {
        
    // }
    // [SessionCheck]
    // [HttpGet("/zoo/{zooId}/deleteZoo")]
    // public IActionResult DeleteZoo() {
        
    // }
}