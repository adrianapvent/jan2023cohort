using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionAssignment.Models;

namespace SessionAssignment.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HttpContext.Session.SetString("UserName", "Adriana");
        HttpContext.Session.SetInt32("MyNum", 12);
        return View();
    }

    public IActionResult Privacy()
    {
        HttpContext.Session.SetString("UserName", "Queen");
        string MyUsername = HttpContext.Session.GetString("UserName");
        int? number = HttpContext.Session.GetInt32("MyNum");
        Console.WriteLine(18 + (int)number);
        return View("Privacy", MyUsername);
    }

    [HttpGet("clear")]
    public IActionResult ClearSession()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
