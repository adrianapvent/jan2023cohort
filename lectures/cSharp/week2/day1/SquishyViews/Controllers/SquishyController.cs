using Microsoft.AspNetCore.Mvc;
namespace SquishyViews.Controllers;
public class SquishyController : Controller {
    
    [HttpGet("/squishy")]
    public ViewResult Squishy() {
        return View();
    }
}