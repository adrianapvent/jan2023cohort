using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SquishyForms.Models;

namespace SquishyForms.Controllers;

public class HogwartController : Controller {

    [HttpGet("")]
    public IActionResult Index() {
        return View();
    }
    [HttpGet("/register")]
    public IActionResult RegForm() {
        return View();
    }
    [HttpPost("/register")]
    // public IActionResult CreateStudent(string theName, string theHouse, int theYear) {

    // }
    public IActionResult CreateStudent(Hogwart student) {
        // if (ModelState.IsValid) {
            return View("result", student);
        // }
        // else {
        //     return View("regform");
        // }
    }
    public IActionResult Result() {
        return View();
    }
}