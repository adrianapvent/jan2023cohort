using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controllers;
    public class UserController : Controller
    {
        [HttpGet]
        [Route("")]
        // public string Index()
        // {
        //     return "Hello World from HelloController!";
        // }
        public string Index() 
        {
            return  "This is my Index.";
        }

        [HttpGet]
        [Route("projects")]

        public string Project()
        {
            return "These are my projects.";
        }

        [HttpGet]
        [Route("contact")]

        public string Contact()
        {
            return "This is my Contact!";
        }
    }
