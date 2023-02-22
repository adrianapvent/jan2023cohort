using Microsoft.AspNetCore.Mvc;
namespace BasicWebReviewPartOne.Controllers;
    public class RootController : Controller
    {
        [HttpGet("")]
        public ViewResult Index() {
            return View();
        }

        [HttpGet]
        [Route("/alt")]
        public string AltIndex()
        {
            return "Hello World from HelloController! How are you today?";
        }
        [HttpGet("/newAlt")]
        public ViewResult NewAlt() {
            return View();
        }
    }

