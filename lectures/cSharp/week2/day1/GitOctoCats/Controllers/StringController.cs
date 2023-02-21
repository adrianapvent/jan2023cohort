using Microsoft.AspNetCore.Mvc;
namespace GitOctoCats.Controllers;
    public class StringController : Controller
    {
        [HttpGet]
        [Route("/strings")]
        public string Strings()
        {
            return "Fun with Strings!";
        }
        // public ViewResult Index() {
        //     return View();
        // }
        [HttpGet("/strings/{name}")]
        public string HelloName(string name) {
            return $"Hello there {name}, how are you today?";
        }

        [HttpGet("/strings/math/{a}/{b}")]
        public string Math(int a, int b) {
            int c = a * b;
            return $"You gave me {a} and {b}.  I have added them to now give you back {c}";
        }
    }

