using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevsOnDeck.Models;
// using DevsOnDeck.RegCode;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DevsOnDeck.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext db;  // or use _context instead of db

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        db = context; // if you use _context above use it here too
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

    [HttpGet("/")]
    public IActionResult Index()
    {
        if(HttpContext.Session.GetInt32("uid") != null) {
            return RedirectToAction("Dashboard");
        } else {
            return View("Index");
        }
    }
    [HttpGet("/logreg")]
    public IActionResult LogReg() {
        if(HttpContext.Session.GetInt32("uid") != null) {
            return RedirectToAction("Dashboard");
        } else {
            return View("LogReg");
        }
    }

    [HttpPost("/register")]
    public IActionResult Register(User newUser) {
        if(ModelState.IsValid) {
            if(db.Users.Any(User => User.Email == newUser.Email)) {
                ModelState.AddModelError("Email", "is taken");
            }
        } 
        if(ModelState.IsValid == false) {
            return View("LogReg");
        }
        PasswordHasher<User> hash = new PasswordHasher<User>();
        newUser.Password = hash.HashPassword(newUser, newUser.Password);
        db.Users.Add(newUser);
        db.SaveChanges();
        HttpContext.Session.SetInt32("uid", newUser.UserId);
        HttpContext.Session.SetString("name", newUser.FullName());
        HttpContext.Session.SetInt32("level", newUser.AccessLevel);
        HttpContext.Session.SetString("type", "Gen");
        HttpContext.Session.SetString("role", newUser.AccessType);
        return RedirectToAction("Dashboard");
    }
    [HttpPost("/login")]
    public IActionResult Login(Login getUser) {
        if(!ModelState.IsValid) {
            return View("LogReg");
        } else {
            User? userInDb = db.Users.FirstOrDefault(u => u.Username == getUser.LoginUserName);
            if(userInDb == null) {
                ModelState.AddModelError("LoginUserName", "Invalid UserName");
                return View("LogReg");
            } else {
                PasswordHasher<Login> hash = new PasswordHasher<Login>();
                var result = hash.VerifyHashedPassword(getUser, userInDb.Password, getUser.LoginPassword);
                if(result == 0)  { 
                    ModelState.AddModelError("LoginPassword", "Invalid Password");
                    return View("LogReg");
                } else {
                    HttpContext.Session.SetInt32("uid", userInDb.UserId);
                    HttpContext.Session.SetString("name", userInDb.FullName());
                    HttpContext.Session.SetInt32("level", userInDb.AccessLevel);
                    HttpContext.Session.SetString("type", "Gen");
                    HttpContext.Session.SetString("role", userInDb.AccessType);
                    return RedirectToAction("Dashboard");
                }
            }   
        }
    }
    [HttpGet("/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }


    [SessionCheck]
    [HttpGet("/Dashboard")]
    public IActionResult Dashboard() {
        User? theUser = db.Users.FirstOrDefault(u => uid == u.UserId);
        // Console.WriteLine($"uid: {uid}, userId {theUser.UserId}, accessLevel: {theUser.AccessLevel}");
        if(uid == 1 && theUser.AccessLevel == 1) {
            theUser.AccessLevel = 24;
            theUser.AccessType = "SuperAdmin";
            db.Users.Update(theUser);
            db.SaveChanges();
            HttpContext.Session.SetString("role", theUser.AccessType);
            ViewBag.Access = "Access updated to SuperAdmin";
            return View("AdminDash", "Admin");
        }
        else if(theUser.AccessLevel == 24) {
            theUser.AccessType = "SuperAdmin";
            db.Users.Update(theUser);
            db.SaveChanges();
            HttpContext.Session.SetString("role", theUser.AccessType);
            ViewBag.Access = "Welcome back Super Admin";
            return View("AdminDash", "Admin");
        }
        // User? dev = db.Users
        //     .Include(d => d.myDev)
        //     .FirstOrDefault(d => d.UserId == uid);
        //     // .ToList();
        // if(dev.myDev == null) {
        //     Console.WriteLine($"dev: {dev.myDev}, mydevId");
        // } else {
        //     Console.WriteLine($"not null");
        // }
        else if(theUser.AccessLevel == 22) {
            theUser.AccessType = "Admin";
            db.Users.Update(theUser);
            db.SaveChanges();
            HttpContext.Session.SetString("role", theUser.AccessType);
            ViewBag.Access = "Welcome back Admin User";
            return View("AdminDash", "Admin");
        }
        // else if(theUser.AccessLevel > 10) {
        //     theUser.AccessType = "Org"
        // }
        return View("Dashboard");
    }
    [SessionCheck]
    [HttpGet("/Profile")]
    public IActionResult UserProfile() {
        User? theUser = db.Users.FirstOrDefault(u => uid == u.UserId);
        return View("Profile", theUser);
    }

    [HttpGet("/NotAuth")]
    public IActionResult NotAuth() {

        return View("NotAuth");
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        int? uid = context.HttpContext.Session.GetInt32("uid");
        if(uid == null)
        {
            context.Result = new RedirectToActionResult("NotAuth", "Home", null);
        }
    }
}
public class AdminCheckAttribute : ActionFilterAttribute {
    public override void OnActionExecuting(ActionExecutingContext context) {
        int? level = context.HttpContext.Session.GetInt32("level");
        if(level < 24) {
            Console.WriteLine("You are not authorized to view this page");
            context.Result = new RedirectToActionResult("NotAuth", "Home", 24);
            // !!!!! Can not have receiving page have view back on load
        }
    }
}