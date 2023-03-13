using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PostReplyLike.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace PostReplyLike.Controllers;

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
        .Include(p => p.Comment)
        // .ThenInclude(p => p.Author)
        .OrderByDescending(p => p.CreatedAt)
        .ToList();

        return View("Dashboard", allPosts);
    }

        // [HttpGet("/post/")]
    // public IActionResult FunctionName() {
    
    // }

    [SessionCheck]
    [HttpGet("/post/addPost")]
    public IActionResult AddPost() {
        return View("AddPost");
    }

    [SessionCheck]
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

        // [HttpGet("/post/")]
    // public IActionResult FunctionName() {
    
    // }
            // [HttpPost("/post/")]
    // public IActionResult FunctionName() {
    
    // }

        // [HttpGet("/post/")]
    // public IActionResult FunctionName() {
    
    // }

    
    
}