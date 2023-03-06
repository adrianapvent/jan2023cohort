using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PostMock.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace PostMock.Controllers;

public class PostController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public PostController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    
    // Recommend routeName and FunctionName be the same
    [SessionCheck]
    [HttpGet("/post/dashboard")]
    public IActionResult Dashboard() {

        List<Post> allPosts = db.Posts
        .Include(p => p.Author)
        .ToList();
        return View("Dashboard", allPosts);
    }
    [SessionCheck]
    [HttpGet("/post/{postId}/view")]
    public IActionResult ViewPost(int postId) {
        Post? item = db.Posts
        .Include(item => item.Author)
        .FirstOrDefault(item => item.PostId == postId);
        if(item == null) {
            return RedirectToAction("Dashboard");
        } else {
            return View("ViewPost", item);
        }
    }

    // [HttpGet()]
    // public IActionResult () {
        
    // }
    [SessionCheck]
    [HttpGet("/post/addPost")]
    public IActionResult AddPost() {
        return View("AddPost");
    }
    [HttpPost("/post/createPost")]
    public IActionResult CreatePost(Post p) {
        p.UserId = (int)uid;
        if(ModelState.IsValid) {
            db.Posts.Add(p);
            db.SaveChanges();
            return Redirect("Dashboard");
        }
        return View("AddPost");
    }
    [SessionCheck]
    [HttpGet("/post/{postId}/edit")]
    public IActionResult EditPost(int postId) {
        Post? item = db.Posts
        .Include(item => item.Author)
        .FirstOrDefault(item => item.PostId == postId);
        if(item == null) {
            return RedirectToAction("Dashboard");
        } else {
            return View("EditPost", item);
        }
    }
    [HttpPost("/post/{postId}/updatePost")]
    public IActionResult UpdatePost(Post p, int postId) {
        if(ModelState.IsValid) {
            Post? item = db.Posts
            .FirstOrDefault(item => item.PostId == postId);
            if(item == null) {
                Console.WriteLine("failed post id");
                return RedirectToAction("Dashboard");
            } else {
                item.Title = p.Title;
                item.Content = p.Content;
                item.UpdatedAt = DateTime.Now;
                db.Posts.Update(item);
                db.SaveChanges();
                Console.WriteLine("passed update");
                return Redirect("/");
            }
        } else {
            Console.WriteLine("failed validations");
            return View("EditPost", postId);
        }
        
    }
    [HttpGet("/post/{postId}/delete")]
    public IActionResult DeletePost(int postId) {
        Post? item = db.Posts.FirstOrDefault(item => item.PostId == postId);
        if(item != null) {
            db.Posts.Remove(item);
            db.SaveChanges();
        }
        return RedirectToAction("Dashboard");
    }
}