using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public ViewResult Index() {
        return View();
    }

    [HttpPost("/user/create")]
    public IActionResult Submission(User user)
    {
        if (ModelState.IsValid)
        {
            return View("ViewUser", user);
        } else {
            return View("Index");
        }
    }

    [HttpGet("/viewUser")]
    public ViewResult ViewUser() {
        return View();
    }
}
