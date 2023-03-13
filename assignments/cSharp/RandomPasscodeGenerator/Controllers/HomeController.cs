using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPasscodeGenerator.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RandomPasscodeGenerator.Controllers;

// [SessionCheck]
public class HomeController : Controller
{
    public string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    Random rand = new Random();
    public StringBuilder RandString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 14; i++)
        {
            sb.Append(str[rand.Next(0, str.Length)]);
        }
        return sb;
    }
    public IActionResult Index()
    {
        StringBuilder sb = new StringBuilder();
        sb = RandString();
        ViewBag.sb = sb;
        return View();
    }
}


// public IActionResult Privacy()
// {
//     return View();
// }

// [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
// public IActionResult Error()
// {
//     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
// }
// public class SessionCheckAttribute : ActionFilterAttribute
// {
//     public override void OnActionExecuting(ActionExecutingContext context)
//     {
//         // Find the session, but remember it may be null so we need int?
//         int? uid = context.HttpContext.Session.GetInt32("uid");
//         // Check to see if we got back null
//         if (uid == null)
//         {
//             // Redirect to the Index page if there was nothing in session
//             // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
//             context.Result = new RedirectToActionResult("Index", "User", null);
//         }
//     }
// }
