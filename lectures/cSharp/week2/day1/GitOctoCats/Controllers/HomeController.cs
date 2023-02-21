using Microsoft.AspNetCore.Mvc;
namespace GitOctoCats.Controllers;
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        // public string Index()
        // {
        //     return "Hello World from HelloController!";
        // }
        public ViewResult Index() {
            return View();
        }
    }

