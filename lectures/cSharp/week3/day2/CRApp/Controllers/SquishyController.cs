using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRApp.Models;

namespace CRApp.Controllers;

public class SquishyController : Controller
{
    private MyContext db;

    public SquishyController(MyContext context)
    {
        db = context;
    }
    [HttpGet("/squishy/allsquishys")] // Once the page is loaded in the browser this function is activated and thus our platter appears
    public IActionResult AllSquishys() { 
        // Is like us asking the waitress for the all you can shrimp platter
        List<Squishy> allSquishys = db.Squishys.ToList();
        // This is saying ok when done I will return that to you
        return View("AllSquishys", allSquishys);
    }
    [HttpGet("/squishy/addSquishy")]
    public IActionResult AddSquishy() {
        return View();
    }

    [HttpPost("/squishy/createSquishy")]
    public IActionResult CreateSquishy(Squishy s) {
        if(ModelState.IsValid) {
            // says hey db I got some info for you
            db.Squishys.Add(s);
            // says hey save that info I showed you
            db.SaveChanges();
            // Now since we saved it into the db there is an id attached so we can now print it as a way of verifying its there
            Console.WriteLine(s.SquishyId);
            return Redirect("/squishy/allSquishys");
        } else {
            return View("AddSquishy");
        }

    }
}
