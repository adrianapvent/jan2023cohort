using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ImagesAndForms.Models;

namespace ImagesAndForms.Controllers;

public class SquishyController : Controller {
    // httpget = render page
// httppost = talk to database/ models

    [HttpGet("squishy")] // Will render the squishyIndex.cshtml
    public IActionResult SquishyIndex() {
        return View();
    }

    [HttpGet("squishy/addSquishy")] // render the addSquishy.cshtml that contains the form to add a squishy
    public IActionResult AddSquishy() {
        return View();
    }

    [HttpPost("addSquishy")] // this will just create the squishy object
    public IActionResult CreateSquishy(Squishy a) {
        //                              className whatWeWillCallItInFunction
        return View("viewSquishy", a);
    }

    [HttpGet("viewSquishy")] // this will render viewSquishy.cshtml which due to the created function above has Squishy object passed in
    public IActionResult ViewSquishy() {
        return View();
    }
}