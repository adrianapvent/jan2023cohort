using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers;
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
    
        public ViewResult Home() 
        {
            return View();
        }
    }