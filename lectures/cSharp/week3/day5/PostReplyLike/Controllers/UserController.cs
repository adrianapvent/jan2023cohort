using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PostReplyLike.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PostReplyLike.Controllers;

public class UserController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public UserController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    
    // Recommend routeName and FunctionName be the same
    
    [HttpGet("")]
    public IActionResult Index() {
        if(HttpContext.Session.GetInt32("uid") != null) {
            return RedirectToAction("Dashboard", "Post");
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
        return RedirectToAction("Dashboard", "Post");
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
                    return RedirectToAction("Dashboard", "Post");
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
    
    
    
}