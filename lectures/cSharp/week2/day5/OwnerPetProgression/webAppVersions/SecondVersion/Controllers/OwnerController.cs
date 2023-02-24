using Microsoft.AspNetCore.Mvc;

namespace SecondVersion.Controllers;   
public class OwnerController : Controller   
{      
    [HttpGet("")]
    public IActionResult Index() {
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
    [HttpGet("viewOwner")]
    public IActionResult ViewOwner() {
        return View();
    }
    [HttpGet("wrongOwner")]
    public IActionResult WrongOwner() {
        return RedirectToAction("Index");
    }
}