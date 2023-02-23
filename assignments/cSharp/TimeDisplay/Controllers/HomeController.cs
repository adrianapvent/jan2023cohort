using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TimeDisplay.Models;

namespace TimeDisplay.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }
}
