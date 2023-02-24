using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstVersion.Models;

namespace FirstVersion.Controllers;

public class OwnerController : Controller {
    [HttpGet("owner")]
    public IActionResult Owner() {
        return View();
    }
    [HttpPost("owner")]
    public IActionResult Owner(Owner theOwner) {
        return RedirectToAction("NewOwner", theOwner);
    }
    [HttpGet("newOwner")]
    public IActionResult NewOwner(Owner theOwner) {
        return View(theOwner);
    }
}