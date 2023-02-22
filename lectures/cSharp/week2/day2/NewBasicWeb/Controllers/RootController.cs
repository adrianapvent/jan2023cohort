using Microsoft.AspNetCore.Mvc;
namespace NewBasicWeb.Controllers;
    public class RootController : Controller
    {
        [HttpGet("")]
        public ViewResult Index() {
            return View();
        }
       [HttpGet("/fakeRoute")]
       public RedirectToActionResult Method() {
        return RedirectToAction("RealRoute");
       } 
    //    [HttpGet("/realRoute")]
    //    public ViewResult RealRoute() {
    //     return View("index");
    //    }
        [HttpGet("/realRoute")]
       public ViewResult RealRoute() {
        return View();
        }
        [HttpGet("/{name}")]
        public IActionResult Name(string name) {
            if(name == "melissa") {
                return RedirectToAction("RealRoute");
            }
            else if (name == "juli") {
                return Json(new {name = name});
            }
            // else {
            //     return $"Hello {name}";
            // }
            else {
                return View("index");
            }
        }
    }

