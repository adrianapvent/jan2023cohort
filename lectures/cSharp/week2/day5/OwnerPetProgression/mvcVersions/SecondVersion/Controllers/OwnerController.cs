using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SecondVersion.Models;

namespace SecondVersion.Controllers;

public class OwnerController : Controller {
    [HttpGet("owner")]
    public IActionResult Owner() {
        return View();
    }
    [HttpPost("owner")]
    public IActionResult Owner(Owner theOwner) {

        if(ModelState.IsValid) {
            return RedirectToAction("NewOwner", theOwner);
        }
        return View("Owner");
    }
    [HttpGet("newOwner")]
    public IActionResult NewOwner(Owner theOwner) {
        return View(theOwner);
    }
}