using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        string message = "Hello out there!";
        return View("Index", message);
    }

    [HttpGet("/new-message")]
    public IActionResult Message() {
        string[] words = new string[] {
            "Here",
            "Is",
            "A",
            "Message",
        };
        return View(words);
    }

    [HttpGet("/users")]
    public IActionResult Users() {
        List<User> users = new List<User>();
        users.Add(new User("Moose", "Phillips"));
        users.Add(new User("Sarah", "Jane"));
        users.Add(new User("Yankee Boy", "Doe"));
        users.Add(new User("Rainbow", "Clouds"));

        return View(users);
    }

    [HttpGet("/number")]
    public IActionResult Numbers() {
        int[] Numbers = new int[] {
            1,
            2,
            3,
            10,
        };
        return View(Numbers);
    }

    [HttpGet("/user")]
    public IActionResult User()
    {
        User firstUser = new User("Moose", "Phillips");
        return View(firstUser);
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
