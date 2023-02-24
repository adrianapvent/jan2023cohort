using Microsoft.AspNetCore.Mvc;

namespace SecondVersion.Controllers;   
public class PetController : Controller   
{      
    [HttpGet("pet")]
    public IActionResult Pet() {
        return View();
    }
    [HttpGet("onePet")]
    public IActionResult OnePet() {
        return View();
    }
    [HttpGet("newPet")]
    public IActionResult NewPet() {
        ViewBag.PetName = "Copper from PetController";
        return View();

    }
    [HttpGet("viewPet")]
    public IActionResult ViewPet() {
        return View();
    }
    [HttpGet("wrongPet")]
    public IActionResult WrongPet() {
        return RedirectToAction("Pet");
    }
}