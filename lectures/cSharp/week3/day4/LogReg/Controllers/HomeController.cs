using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LogReg.Models;

namespace LogReg.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext db;  // or use _context instead of db

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        db = context; // if you use _context above use it here too
    }

    // public IActionResult Index()
    // {
    //     return Redirect("monster");  
    // }

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