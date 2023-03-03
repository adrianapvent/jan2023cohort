using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DateValidator.Models;

namespace DateValidator.Controllers;

public class DateController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
       //  List<ClassName> All<ClassName> = _context.<VarOnContextFile>.ToList();
        return View();  
    }

    [HttpPost("result")]
    public IActionResult Submission(Form entry)
    {
        if(ModelState.IsValid)
        {
            return View("result", entry);
        } else 
        {
            return View("index");
        }
    }
}