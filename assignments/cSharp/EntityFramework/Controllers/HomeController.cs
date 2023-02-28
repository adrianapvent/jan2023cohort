using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EntityFramework.Models;

namespace EntityFramework.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context; 

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context; 
    }

    public IActionResult Index()
    {
       //  List<ClassName> All<ClassName> = _context.<VarOnContextFile>.ToList();
        return View();  
    }
    // Inside HomeController
[HttpPost("monsters/create")]
public IActionResult CreateMonster(Monster newMon)
    {    
    if(ModelState.IsValid)
    {
        // We can take the Monster object created from a form submission
        // and pass the object through the .Add() method  
        // Remember that _context is our database  
        _context.Add(newMon);    
        // OR _context.Monsters.Add(newMon); if we want to specify the table
        // EF Core will be able to figure out which table you meant based on the model  
        // VERY IMPORTANT: save your changes at the end! 
        _context.SaveChanges();
        return RedirectToAction("SomeAction");
    } else {
        // Handle unsuccessful validations
    }
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

