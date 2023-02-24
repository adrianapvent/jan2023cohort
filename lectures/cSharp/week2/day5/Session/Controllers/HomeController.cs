using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Session.Models;

namespace Session.Controllers;

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
        return View();
    }
    [HttpGet("sessionTest")]
    public IActionResult SessionTest () {
        HttpContext.Session.SetString("FirstName", "Brianna");

        string TestOne = HttpContext.Session.GetString("FirstName");

        return View();
    }
    [HttpGet("testTwo")]
    public IActionResult TestTwo () {

        return View();
    }
    [HttpGet("humanTest")]
    public IActionResult HumanTest() {
        return View();
    }

    [HttpPost("humanTest")]
    public IActionResult HumanTest(Human theHuman){
        string h = theHuman.FirstName;
        HttpContext.Session.SetString("FirstName", h);
        string TestTwo = HttpContext.Session.GetString("FirstName");

        return RedirectToAction("newHuman", theHuman);
    }
    [HttpGet("newHuman")]
    public IActionResult NewHuman(Human theHuman) {
        return View(theHuman);
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
