using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;
public class SurveyController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("/result")]
    public IActionResult Submission(Survey data)
    {
        if (ModelState.IsValid)
        {
            return View("Result", data);
        } else {
            return View("Index");
        }
    }
}