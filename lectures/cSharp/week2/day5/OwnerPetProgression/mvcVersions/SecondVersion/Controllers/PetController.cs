using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SecondVersion.Models;

namespace SecondVersion.Controllers;

public class PetController : Controller {
    [HttpGet("pet")]
    public IActionResult Pet() {
        return View();
    }
    [HttpPost("pet")]
    public IActionResult Pet(Pet thePet) {
        if(ModelState.IsValid) {
            return RedirectToAction("NewPet", thePet);
        }
        return View("Pet");
        
    }
    [HttpGet("newPet")]
    public IActionResult NewPet(Pet thePet) {
        return View(thePet);
    }
}