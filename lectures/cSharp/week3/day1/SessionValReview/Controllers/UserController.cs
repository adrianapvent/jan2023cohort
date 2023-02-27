using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionValReview.Models;

namespace SessionValReview.Controllers;

public class UserController : Controller {

    [HttpGet("/regUser")]
    public IActionResult RegUser() {
        return View();
    }

    [HttpPost("/regUser")]
    public IActionResult RegUser(User theUser) {
        if(ModelState.IsValid) {
            string user = theUser.FirstName;
            HttpContext.Session.SetString("FirstName", user);
            // HttpContext.Session.GetString("FirstName");
            return RedirectToAction("Dashboard", theUser);
        } else {
            return View("RegUser");
        }
    }

    [HttpGet("/dashboard")]
    public IActionResult Dashboard(User theUser) {
        return View(theUser);
    }
    
    [HttpGet("/logout")]
    public IActionResult Logout() {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}