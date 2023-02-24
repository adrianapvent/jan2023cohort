using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public ViewResult Index() {
        return View();
    }

    [HttpPost("/user")]
    public ViewResult UserIndex(string Name, string Location, string Language, string message) {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Message = message;
        return View();
    }

    // [HttpGet("/viewUser")]
    // public ViewResult ViewUser() {
    //     return View();
    // }
}
