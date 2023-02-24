using Microsoft.AspNetCore.Mvc;
namespace ReviewPartI.Controllers;
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index() {
            ViewBag.indexOnly = "I will only load if the index route is called";
            return View();
        }
        [HttpGet("bla")]
        public ViewResult Test() {
            return View();
        }
        [HttpGet("notIndex")]
        public ViewResult NotIndex() {
            ViewBag.notIndex = "I will showup if /notIndex is the route";
            return View("Index");
        }
        [HttpGet("justTesting")]
        public RedirectToActionResult JustTesting() {
            // ViewBag.justATest = "This is just a test";
            return RedirectToAction("bla");
            // return View(); //Can't use this  with the Redirectto action result as it is not part of that child class
        }
        // [HttpPost("postRequest")]
        // public IActionResult Form(string Name) {
        //     ViewBag.Name = Name;
        //     return RedirectToAction("Form");
        // }
        [HttpGet("form")]
        public IActionResult Form() {
            ViewBag.get = "I render on the HttpGet";
            return View();
        }

        [HttpPost("form")]
        public IActionResult Form(string Name) {
            if(Name == "fluffy") {
                // ViewBag.Name = Name;
                return RedirectToAction("test");
            }
            ViewBag.Name = Name;
            ViewBag.post = "I render on the HttpPost";
            return View();
        }
        [HttpGet("{**path}")]
        public RedirectToActionResult Unknown()
        {
            Console.WriteLine("Page not found");
            return RedirectToAction("Index");
        }
    }

