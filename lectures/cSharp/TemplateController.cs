using Microsoft.AspNetCore.Mvc;
namespace <ProjName>.Controllers;
    public class <ControllerName> : Controller
    {
        [HttpGet("")]
        public ViewResult Index() {
            return View();
        }

        // [HttpGet]
        // [Route("/alt")]
        // public string AltIndex()
        // {
        //     return "Hello World from HelloController!";
        // }
    }

