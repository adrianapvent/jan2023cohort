using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesWithCRU.Models;

namespace MoviesWithCRU.Controllers;

public class MovieController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public MovieController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    
    // Recommend routeName and FunctionName be the same
    
    [HttpGet("")]
    public IActionResult Dashboard() {
        List<Movie> allMovies = db.Movies.ToList();
        return View("Dashboard", allMovies);
    }
    [HttpGet("movie/{movieId}/view")]
    public IActionResult ViewMovie(int movieId){
        Movie? item = db.Movies.FirstOrDefault(item => item.MovieId == movieId);
        if(item == null) {
            return RedirectToAction("dashboard");
        } else {
            return View("ViewMovie", item);
        }
    }
    [HttpGet("/movie/addMovie")]
    public IActionResult AddMovie() {
        return View("createMovie");
    }

    [HttpPost("/movie/createMovie")]
    public IActionResult CreateMovie(Movie theMovie) {
        if(ModelState.IsValid) {
            db.Movies.Add(theMovie);
            db.SaveChanges();
            return Redirect("/");
        } else {
            Console.WriteLine("Error Error");
            return View("AddMovie");
        }
    }
    [HttpGet("movie/{movieId}/edit")]
    public IActionResult EditMovie(int movieId) {
        Movie? item = db.Movies.FirstOrDefault(item => item.MovieId == movieId);
        if(item == null) {
            return RedirectToAction("dashboard");
        } else {
            return View("EditMovie", item);
        }
    }
    [HttpPost("movie/{movieId}/update")]
    public IActionResult UpdateMovie(Movie theMovie, int movieId) {
        if(ModelState.IsValid) { // form entries meet validations continue on
            Movie? item = db.Movies.FirstOrDefault(item => item.MovieId == movieId); // pulling the single entry
            if(item == null) { // Id not valid leave edit page
                Console.WriteLine("Id not valid leave edit page");
                return RedirectToAction("dashboard");
            } else { // validations were good id is in db now please do the following
                item.Title = theMovie.Title;
                item.Genre = theMovie.Genre;
                item.Year = theMovie.Year;
                item.Rating = theMovie.Rating;
                item.Img = theMovie.Img;
                item.UpdatedAt = DateTime.Now;

                db.Movies.Update(item);
                db.SaveChanges();
                return Redirect("/");
            }
        } else { // validations failed get outa here
            Console.WriteLine("validations failed get outa here");
            return View("EditMovie", movieId);
        }
    }
    [HttpGet("movie/{movieId}/delete")]
    public IActionResult DeleteMovie(int movieId) {
        Movie? item = db.Movies.FirstOrDefault(item => item.MovieId == movieId);
        if(item != null) { // if the id exists do the following
            db.Movies.Remove(item);
            db.SaveChanges();
            Console.WriteLine("Entry removed");
        }
        return RedirectToAction("Dashboard"); // regardless of if statement results please just go back to all movies
    }
    
}