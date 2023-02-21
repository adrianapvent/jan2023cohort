using Microsoft.AspNetCore.Mvc;
namespace GitOctoCats.Controllers;
    public class OctoCatController : Controller
    {
        [HttpGet]
        [Route("/octocats")]

        public ViewResult OctoCats() {
            return View();
        }
        [HttpGet("/octocats/{id}")] 
        public ViewResult OctoCat(int id) {
            Dictionary<int, string> OctoCats = new Dictionary<int, string>() {
                {1, "~/images/bookWorkOctocat.png"},
                {2, "~/images/computerOctocat.png"},
                {3, "~/images/investigativeOctocat.png"},
                {4, "~/images/madScientistOctocat.png"},
                {5, "~/images/powerOctocat.png"},
                {6, "~/images/wizardOctocat.png"}
            };
            if(id == 1) {
                Console.WriteLine("image 1");
            }
            Console.WriteLine(id);

            return View();
        }
    }

