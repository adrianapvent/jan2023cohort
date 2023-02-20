using Microsoft.AspNetCore.Mvc;
namespace SquishyViews.Controllers;
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index() {
            return View();
        }
    }

