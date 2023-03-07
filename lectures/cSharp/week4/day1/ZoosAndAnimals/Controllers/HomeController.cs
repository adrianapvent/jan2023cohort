using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ZoosAndAnimals.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ZoosAndAnimals.Controllers;

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

    [HttpGet("")]
    public IActionResult Index()
    {
        if(HttpContext.Session.GetInt32("uid") != null) {
            return RedirectToAction("Dashboard", "Zoo");
        } else {
            return View("Index");
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
            return View("Index");
        }
        PasswordHasher<User> hash = new PasswordHasher<User>();
        newUser.Password = hash.HashPassword(newUser, newUser.Password);
        db.Users.Add(newUser);
        db.SaveChanges();
        HttpContext.Session.SetInt32("uid", newUser.UserId);
        HttpContext.Session.SetString("name", newUser.FullName());
        return RedirectToAction("Dashboard", "Zoo");
    }
    [HttpPost("/login")]
    public IActionResult Login(LoginUser getUser) {
        if(!ModelState.IsValid) {
            return View("Index");
        } else {
            User? userInDb = db.Users.FirstOrDefault(u => u.Email == getUser.LoginEmail);
            if(userInDb == null) {
                ModelState.AddModelError("LoginEmail", "Invalid Email");
                return View("Index");
            } else {
                PasswordHasher<LoginUser> hash = new PasswordHasher<LoginUser>();
                var result = hash.VerifyHashedPassword(getUser, userInDb.Password, getUser.LoginPassword);
                if(result == 0)  { 
                    ModelState.AddModelError("LoginPassword", "Invalid Password");
                    return View("Index");
                } else {
                    HttpContext.Session.SetInt32("uid", userInDb.UserId);
                    HttpContext.Session.SetString("name", userInDb.FullName());
                    return RedirectToAction("Dashboard", "Zoo");
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

    public IActionResult Privacy()
    {
        return View();
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
        // Find the session, but remember it may be null so we need int?
        int? uid = context.HttpContext.Session.GetInt32("uid");
        // Check to see if we got back null
        if(uid == null)
        {
            // Redirect to the Index page if there was nothing in session
            // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
            context.Result = new RedirectToActionResult("Index", "Home", null);
        }
    }
}