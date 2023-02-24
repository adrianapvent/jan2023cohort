using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReviewPartII.Models;

namespace ReviewPartII.Controllers;
public class HumanController : Controller {

    [HttpGet("human")]
    public IActionResult Human() {
        return View();
        //return View() means that the cshtml it will look for is the Function/Action name
        // return View("hello") means that cshtml it will look for is the hello.cshtml file as that is what we specifically told it too look for
    }

    [HttpGet("addHuman")]
    public IActionResult AddHuman() {
        return View();
    }
    [HttpPost("createHuman")]
    public IActionResult AddHuman(Human h) {
        
        return RedirectToAction("ViewHuman", h);
        // RedirectToAction("ViewHuman", h) is looking for the function/ action of ViewHuman and giving it the instance of Human
        // return View("viewhuman",h);
        // View("viewHuman", h) is looking for the viewHuman.cshtml and giving it the instance of Human
    }
    [HttpGet("viewHuman")]
    public IActionResult ViewHuman(Human h) {
        return View(h);
    }
}