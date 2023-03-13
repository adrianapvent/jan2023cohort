using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevsOnDeck.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace DevsOnDeck.Controllers;

public class AdminController: Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public AdminController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    private int? level {
        get {
            return HttpContext.Session.GetInt32("level");
        }
    }
    private string? name {
        get {
            return HttpContext.Session.GetString("name");
        }
    }
    private string? type {
        get {
            return HttpContext.Session.GetString("type");
        }
    }
    private string? role {
        get {
            return HttpContext.Session.GetString("role");
        }
    }
    
    [AdminCheck]
    [SessionCheck]
    [HttpPost("/Admin/Dashboard")]
    public IActionResult AdminDash() {
        HttpContext.Session.SetString("type", "Admin");
        return View("AdminDash");
    }
// *** Make Super Admin
// *** Make Admin
// *** Create Org code
// *** Remove User
// *** Remove Org
// *** Downgrade Admin
// *** Downgrade Super Admin
// *** All Users
// *** Update Password Link (/user/{key}/updatePassword)
    // [AdminCheck]
    // [SessionCheck]

    
}