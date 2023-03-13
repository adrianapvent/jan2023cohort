using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PostReplyLike.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace PostReplyLike.Controllers;

public class ReplyController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public ReplyController(MyContext context)
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
    [HttpGet("/reply/{postId}/addReply")]
    public IActionResult AddReply(int postId) {
        int thePost = postId;
        HttpContext.Session.SetInt32("thePost", thePost);
        return View("AddReply");
    }
    [SessionCheck]
    [HttpPost("/reply/{postId}/createReply")]
    public IActionResult CreateReply(Reply r, int postId) {
        Console.WriteLine($" am i in the function? {r}");
        r.UserId = (int)uid;
        r.PostId = postId;
        Console.WriteLine("before val check after id sets");
        if(ModelState.IsValid) {
            Console.WriteLine("inside val check before .add");
            db.Replys.Add(r);
            db.SaveChanges();
            return Redirect("/");
        }     

        return View("AddReply");
    }
    
}