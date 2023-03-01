using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Toons.Models;

namespace TuneController.Controllers;

public class TuneController : Controller
{
    private MyContext db;

    public TuneController(MyContext context)
    {
        db = context;
    }
    [HttpGet("/tune/alltunes")] // Once the page is loaded in the browser this function is activated and thus our platter appears
    public IActionResult AllTunes() { 
        // Is like us asking the waitress for the all you can shrimp platter
        List<Tune> allTunes = db.Tunes.ToList();
        // This is saying ok when done I will return that to you
        return View("AllTunes", allTunes);
    }
    [HttpGet("/tune/addTune")]
    public IActionResult AddTune() {

        // this is saying hey my file name is addTune
        return View("addTune");
    }
    [HttpPost("/tune/createTune")]
    public IActionResult CreateTune(Tune t) {
        if(ModelState.IsValid) {
            db.Tunes.Add(t);
            db.SaveChanges();
            return Redirect("/tune/allTunes");
        } else {
            // Please reload the page that is part of the AddTune function
            return View("AddTune");
        }
    }
}