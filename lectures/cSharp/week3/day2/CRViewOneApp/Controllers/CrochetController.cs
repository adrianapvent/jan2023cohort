using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRViewOneApp.Models;

namespace CRViewOneApp.Controllers;

public class CrochetController : Controller
{
    private MyContext db; 
    public CrochetController(MyContext context)
    {
        db = context;
    }  
    [HttpGet("")] 
    public IActionResult Dashboard() {
        List<Crochet> allItems = db.Crochets.ToList();
        return View("Dashboard", allItems);
    }
    [HttpGet("/crochet/addProject")]
    public IActionResult AddProject() {
        return View();
    }
    [HttpPost("/crochet/createProject")]
    public IActionResult CreateProject(Crochet c) {
        if(ModelState.IsValid) {
            db.Crochets.Add(c);
            db.SaveChanges();
            Console.WriteLine(c.CrochetId);
            return Redirect("/");
        } else {
            Console.WriteLine("Error Will Robinson");
            return View("AddProject");
        }
    }
    [HttpGet("/crochet/{crochetId}/view")]
    public IActionResult ViewProject(int crochetId) {
        Crochet? item = db.Crochets.FirstOrDefault(item => item.CrochetId == crochetId);

        if(item == null) {
            return RedirectToAction("dashboard");
        } else {
            return View("ViewProject", item);
        }
    }
}
