using Microsoft.AspNetCore.Mvc;

namespace FirstVersion.Controllers;   
public class OwnerController : Controller   
{      
    [HttpGet("")]
    public string Index()        
    {            
    	return "the Owner Controller!";        
    }    
}