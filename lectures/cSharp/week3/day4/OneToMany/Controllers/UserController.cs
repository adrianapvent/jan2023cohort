using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OneToMany.Models;
using Microsoft.AspNetCore.Identity;

namespace OneToMany.Controllers;

public class UserController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public UserController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    
    // Recommend routeName and FunctionName be the same
    
    [HttpGet("")]
    public IActionResult Index() {
        if(HttpContext.Session.GetInt32("uid") != null) {
            return RedirectToAction("Dashboard", "Monster");
        } else {
            return View("Index");
        }
    }

    [HttpPost("/register")]
    public IActionResult Register(User newUser) {
        if(!ModelState.IsValid) {
            return View("Index");
        } else {
            PasswordHasher<User> hash = new PasswordHasher<User>(); // This creates a new instance of the password hasher so that we can use it on the next line
            newUser.Password = hash.HashPassword(newUser, newUser.Password);
            // let newUser.Password equal a hashed version of the password
            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("uid", newUser.UserId);
            HttpContext.Session.SetString("name", newUser.FirstName + " " + newUser.LastName);
            return RedirectToAction("Dashboard", "Monster");
        }
    }
    [HttpPost("/login")]
    public IActionResult Login(LoginUser getUser) {
        if(!ModelState.IsValid) {
            return View("Index");
        } else {
            User? userInDb = db.Users.FirstOrDefault(u => u.Email == getUser.LoginEmail);
            // Please go to db and see if there is an email that matched the email coming from the form
            if(userInDb == null) {
                // If email is not in database go back to Index with new error for loginemail
                ModelState.AddModelError("LoginEmail", "Invalid Email");
                return View("Index");
            } else {
                PasswordHasher<LoginUser> hash = new PasswordHasher<LoginUser>();
                var result = hash.VerifyHashedPassword(getUser, userInDb.Password, getUser.LoginPassword);
                // has the getUser password and see if they match will give bool type response
                if(result == 0)  { // meaning not a match
                    ModelState.AddModelError("LoginPassword", "Invalid Password");
                    return View("Index");
                } else {
                    HttpContext.Session.SetInt32("uid", userInDb.UserId);
                    HttpContext.Session.SetString("name", userInDb.FirstName + " " + userInDb.LastName);
                    return RedirectToAction("Dashboard", "Monster");
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