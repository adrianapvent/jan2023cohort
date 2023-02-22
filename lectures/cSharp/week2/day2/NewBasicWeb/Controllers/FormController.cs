using Microsoft.AspNetCore.Mvc;
namespace NewBasicWeb.Controllers;
    public class FormController : Controller
    {
        [HttpGet("/result")]
        public ViewResult User() {
            return View("result");
        }

        [HttpPost("/result")]
        public IActionResult CreateUser(string firstName, string lastName, int age, string password, string confirm) {
            ViewBag.firstName = $"{firstName}";
            ViewBag.lastName = $"{lastName}";
            ViewBag.age = $"{age}";
            if(confirm != password) {
                ViewBag.Error = $"Your passwords to not match";
            } else {
                ViewBag.Good = $"{firstName} you have a good password";
            }

            return View("result");
        }

    }

