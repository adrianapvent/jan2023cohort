using Microsoft.AspNetCore.Mvc;
namespace ReviewPartI.Controllers;
    public class FormController : Controller {

        [HttpGet("newForm")]
        public IActionResult NewForm() {
            ViewBag.get = "I render on the HttpGet";
            return View();
        }

        [HttpPost("newForm")]
        public IActionResult NewForm(string Name) {
            if(Name == "fluffy") {
                // ViewBag.Name = Name;
                return RedirectToAction("test");
            }
            ViewBag.Name = Name;
            ViewBag.post = "I render on the HttpPost";
            return View();
        }
    }