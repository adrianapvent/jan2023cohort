using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers;
    public class ProjectsController : Controller
    {
        [HttpGet]
        [Route("/projects")]

        public ViewResult Project()
        {
            return View();
        }
    }