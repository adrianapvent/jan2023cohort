using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReviewPartII.Models;
namespace ReviewPartII.Controllers;

public class AnimalController : Controller {

    [HttpGet("animal")]
    public IActionResult Animal() {
        return View();
    }
}