using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LogReg.Models;

namespace LogReg.Controllers;

public class MonsterController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public MonsterController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    
    // Recommend routeName and FunctionName be the same
    
    [HttpGet("/monster/")]
    public IActionResult Dashboard() {
        if(HttpContext.Session.GetInt32("uid") == null){
            return RedirectToAction("Index", "User");
        }
        List<Monster> allMonsters = db.Monsters.ToList();
        return View("Dashboard", allMonsters);
    }

    // [HttpGet("/monster/{monsterId}/view")]
    // public IActionResult ViewMonster() {
        // if(HttpContext.Session.GetInt32("uid") = null){
        //     return RedirectToAction("Index", "User");
        // }
        
    // }

    [HttpGet("/monster/addMonster")]
    public IActionResult AddMonster() {
        if(HttpContext.Session.GetInt32("uid") == null){
            return RedirectToAction("Index", "User");
        }
        return View();
    }

    [HttpPost("/monster/createMonster")]
    public IActionResult CreateMonster(Monster m) {
        if(ModelState.IsValid) {
            db.Monsters.Add(m);
            db.SaveChanges();
            return Redirect("/monster");
        } else {
            return View("AddMonster");
        }
    }

    [HttpGet("/monster/{monsterId}/edit")]
    public IActionResult EditMonster(int monsterId) {
        if(HttpContext.Session.GetInt32("uid") == null){
            return RedirectToAction("Index", "User");
        }
        Monster? item = db.Monsters.FirstOrDefault(item => item.MonsterId == monsterId);
        if(item == null) {
            return RedirectToAction("dashboard");
        } else {
            return View("editMonster", item);
        }
    }

    [HttpPost("/monster/{monsterId}/update")]
    public IActionResult UpdateMonster(Monster m, int monsterId) {
        if(ModelState.IsValid) {
            Monster? item = db.Monsters.FirstOrDefault(item => item.MonsterId == monsterId);
            if(item == null) {
                return RedirectToAction("dashboard");
            } else {
                item.Name = m.Name;
                item.Img = m.Img;
                item.UpdatedAt = DateTime.Now;

                db.Monsters.Update(item);
                db.SaveChanges();
                return Redirect("/");
            }
        } else {
            return View("EditMonster",monsterId);
        }
    }

    [HttpGet("/monster/{monsterId}/delete")]
    public IActionResult DeleteMonster(int monsterId) {
        Monster? item = db.Monsters.FirstOrDefault(item => item.MonsterId == monsterId);
        if(item != null) {
            db.Monsters.Remove(item);
            db.SaveChanges();
        }
        return RedirectToAction("dashboard");
    }
    
    
}