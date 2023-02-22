using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers;
    public class ContactController : Controller
    {
        [HttpGet]
        [Route("/contacts")]
    
        public ViewResults Contact() 
        {
            return  View();
        }
    }