using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext db; 

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }

    //ViewAll Dishes
    [HttpGet("")]
    public IActionResult Index()
    {
        List<Dish> allDishes = db.Dishes.OrderByDescending(d => d.DishId).ToList();
        // ViewBag.allDishes = allDishes;
        return View(allDishes);
        // return View("Index");  
    }

    //create the dish
    [HttpGet("/addDish")]
    public IActionResult AddDish() {
        return View();
    }

    //post the created Dish
    [HttpPost("/Create")]
    public IActionResult CreateDish(Dish mydish)
    {
        if(ModelState.IsValid)
        {
            db.Add(mydish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("AddDish");
    }

    //view 1 dish w/details
    [HttpGet("Home/addDish/{DishId}")]
    public IActionResult ViewDish(int DishId)
    {
        Dish? item = db.Dishes.FirstOrDefault(i => i.DishId == DishId);

        if(item == null){
            return RedirectToAction("Index");
        }
        else {
        return View("ViewDish", item);
        }
    }

    //get item to edit
    [HttpGet("/Home/{TestId}/editDish")]
    public IActionResult EditDish(int TestId)
    {
        Console.WriteLine("================");
        Dish? item = db.Dishes
        // .Include(item => item.Name)
            .FirstOrDefault(item => item.DishId == TestId);
        if(item == null){
            return RedirectToAction("Index");
        } else {
        // Console.WriteLine("================");
        return View("editDish", item);
        }
    }
    //update item
    [HttpPost("/Home/updateDish/{TestId}")]
    public IActionResult Update(Dish newItem, int TestId){
        Console.WriteLine("What's happening");
        if(ModelState.IsValid){
            Dish? item = db.Dishes
            .FirstOrDefault(item => item.DishId == TestId);
            if(item == null){
                Console.WriteLine("failed dish id");
                return RedirectToAction("Index");
            } else {
            item.Name = newItem.Name;
            item.Chef = newItem.Chef;
            item.Tastiness = newItem.Tastiness;
            item.Calories = newItem.Calories;
            item.Description = newItem.Description;
            item.UpdatedAt = DateTime.Now;
            db.Dishes.Update(item);
            db.SaveChanges();
            return RedirectToAction("Index");
            }
        } else {
        Console.WriteLine("failed validations");
        return View("editDish");
        }
    }

    //delete item
    [HttpGet("/Home/{dishId}/Delete")]
    public IActionResult DeleteDish(int dishId) {
        Dish? item = db.Dishes
        .FirstOrDefault(item => item.DishId == dishId);
        if(item != null) {
            db.Dishes.Remove(item);
            db.SaveChanges();
            Console.WriteLine("Entry removed");
        }
        return RedirectToAction("Index");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
