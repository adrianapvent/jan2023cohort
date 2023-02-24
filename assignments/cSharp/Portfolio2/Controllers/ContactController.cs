using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers;
    public class ContactController : Controller
    {
        [HttpGet]
        [Route("/contact")]
    
        public ViewResult Contact() 
        {
            return View();
        }
    }