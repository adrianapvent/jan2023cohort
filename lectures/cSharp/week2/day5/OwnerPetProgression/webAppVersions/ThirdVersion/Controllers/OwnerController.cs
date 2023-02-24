using Microsoft.AspNetCore.Mvc;

namespace ThirdVersion.Controllers;   
public class OwnerController : Controller   
{      
    [HttpGet("")]
    public IActionResult Index() {
        return View();
    }
    [HttpPost("createOwner")]
    public IActionResult CreateOwner(string Name) {
        ViewBag.Name = Name;
        return View("FormOwner", Name);
    }
    [HttpGet("formOwner")]
    public IActionResult FormOwner(string Name) {
        
        return View();
    }
    [HttpGet("oneOwner")]
    public IActionResult OneOwner() {
        return View();
    }
    [HttpGet("newOwner")]
    public IActionResult NewOwner() {
        ViewBag.Name = "Melissa from Controller";
        return View();
    }
    [HttpGet("anotherOwner")]
    public IActionResult AnotherOwner() {
        ViewBag.Name = "Juli from Controller";
        return View("NewOwner");
    }
    [HttpGet("viewOwner")]
    public IActionResult ViewOwner() {
        return View();
    }
    [HttpGet("wrongOwner")]
    public IActionResult WrongOwner() {
        return RedirectToAction("Index");
    }
}