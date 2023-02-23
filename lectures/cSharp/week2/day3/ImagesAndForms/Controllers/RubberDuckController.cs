using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ImagesAndForms.Models;

namespace ImagesAndForms.Controllers;

public class RubberDuckController : Controller {

// httpget = render page
// httppost = talk to database/ models

    [HttpGet("rubberDuck")] // Will render the duckIndex.cshtml
    public IActionResult DuckIndex() {
        return View();
    }

    [HttpGet("rubberDuck/addDuck")] // render the addDuck.cshtml that contains the form to add a duck
    public IActionResult AddDuck() {
        return View();
    }

    [HttpPost("/createDuck")] // this will just create the duck object
    public IActionResult CreateDuck(RubberDuck duck) {
        return View("ViewDuck", duck);
    }

    [HttpGet("/viewDuck")] // this will render viewDuck.cshtml which due to the created function above has duck object passed in
    public IActionResult ViewDuck() {
        return View();
    }
}
