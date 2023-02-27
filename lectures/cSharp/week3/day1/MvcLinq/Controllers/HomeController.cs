using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcLinq.Models;

namespace MvcLinq.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        List<Trainer> trainers = new List<Trainer> {
            new Trainer(1, "Jane", "Doe", "jane@doe.com",2),
            new Trainer(2, "Bob", "Ross", "bob@ross.com", 5),
            new Trainer(3, "John", "Smith", "john@smith.com", 4),
            new Trainer(4, "John", "Doe", "john@doe.com", 2),
            new Trainer(5, "Cesar", "Milan", "cesar@milan.com", 10),
        };
        List<Dog> dogs = new List<Dog> {
            new Dog(1, "Copper Tone", "Longenberger","Beagle", 2, "Melissa"),
            new Dog(2, "Mr. Tucker", "Longenberger", "Cane Corso Mix", 1, "Melissa"),
            new Dog(3, "Lincoln", "Sepulveda", "Yorkie", 4, "Jackie"),
            new Dog(4, "Bethoven", "Gross", "St Bernard", 8, "Mar'Kebta"),
            new Dog(5, "Clifford", "Pena", "Big Red", 20, "Adriana"),
            new Dog(6, "Snoopy", "Villatoro", "Beagle", 20, "Lizette"),
            new Dog(7, "Iowa", "Fossi", "Lab", 3, "Muriel"),
        };
        Random rand = new Random();
        int i = rand.Next(dogs.Count);
        string choice = dogs[i].FirstName;
        Console.WriteLine(choice);
        Dog? oneDog = dogs.FirstOrDefault(dog => dog.FirstName == choice);
        if(oneDog != null) {
            Console.WriteLine(oneDog.Print());
            string theDog = oneDog.Print();
            ViewBag.theDog = theDog;
            return View("Index", theDog);
        } else {
            Console.WriteLine("Dog not in list");
            return View();
        }
    }
    [HttpGet("/orderedDogs")]
    public IActionResult OrderedDogs() {
        List<Dog> dogs = new List<Dog> {
            new Dog(1, "Copper Tone", "Longenberger","Beagle", 2, "Melissa"),
            new Dog(2, "Mr. Tucker", "Longenberger", "Cane Corso Mix", 1, "Melissa"),
            new Dog(3, "Lincoln", "Sepulveda", "Yorkie", 4, "Jackie"),
            new Dog(4, "Bethoven", "Gross", "St Bernard", 8, "Mar'Kebta"),
            new Dog(5, "Clifford", "Pena", "Big Red", 20, "Adriana"),
            new Dog(6, "Snoopy", "Villatoro", "Beagle", 20, "Lizette"),
            new Dog(7, "Iowa", "Fossi", "Lab", 3, "Muriel"),
        };
        // where FamilyName == "Longenberger"
        // OrderBy(age)
        var filteredBy = dogs
            .Where(dog => dog.FamilyName == "Longenberger")
            .Select(dog => dog.Age)
            .OrderBy(a => a)
            .ToList();
        // foreach(var dog in filteredBy) {
        //     Console.WriteLine(dog.Print());
        // }
        // List<Dog> filterDogs = dogs.OrderBy(dog => dog.FirstName).ToList();
        return View();
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
