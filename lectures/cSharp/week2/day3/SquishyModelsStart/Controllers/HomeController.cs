using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SquishyModelsStart.Models;

namespace SquishyModelsStart.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        string message = "Hello out there!";
        string[] words = new string[] {
            "Hello",
            "What",
            "Is",
            "Happening",
            "Here?",
        };
        return View("Index", message);
    }
    [HttpGet("new-message")]
    public IActionResult Message() {
        string[] words = new string[] {
            "Hello",
            "What",
            "Is",
            "Happening",
            "Here?",
        };
        return View(words);
    }
    [HttpGet("/home/squishy")]
    public IActionResult Squishies() {
        List<Squishy> squishies = new List<Squishy>();
        squishies.Add(new Squishy("Fluffy", 4));
        squishies.Add(new Squishy("Cyclopz", 2));
        squishies.Add(new Squishy("Yankee Boy", 5));
        squishies.Add(new Squishy("Rainbow", 1));

        return View(squishies);
    }
    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
