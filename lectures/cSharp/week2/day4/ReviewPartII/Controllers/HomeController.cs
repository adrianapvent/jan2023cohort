using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReviewPartII.Models;

namespace ReviewPartII.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    // [HttpGet("{**path}")]
    // public RedirectToActionResult Unknown()
    // {
    //     Console.WriteLine("Page not found");
    //     return RedirectToAction("Index");
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
