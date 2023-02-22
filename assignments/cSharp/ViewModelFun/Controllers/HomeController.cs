using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

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
        return View("Index", message);
    }
    [HttpGet("/home/new-message")]
    public IActionResult Message() {
        string[] words = new string[] {
            "Here",
            "Is",
            "A",
            "Message",
        };
        return View(words);
    }
    [HttpGet("/home/users")]
    public IActionResult Users() {
        List<User> Users = new List<User>();
        users.Add(new User("Moose", "Phillips"));
        users.Add(new User("Sarah", "Jane"));
        users.Add(new User("Yankee Boy", "Doe"));
        users.Add(new User("Rainbow", "Clouds"));

        return View(users);
    }
    [HttpGet("/home/number")]
    public IActionResult Numbers() {
        int[] Numbers = new string[] {
            1,
            2,
            3,
            10,
        };
        return View(Numbers);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
