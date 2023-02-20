using Microsoft.AspNetCore.Mvc;
namespace <ProjName>.Controllers;
    public class <ControllerName> : Controller
    {
        [HttpGet]
        [Route("")]
        // public string Index()
        // {
        //     return "Hello World from HelloController!";
        // }
        public ViewResult Index() {
            return View();
        }
    }

