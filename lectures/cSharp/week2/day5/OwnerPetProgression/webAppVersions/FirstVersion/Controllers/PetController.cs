using Microsoft.AspNetCore.Mvc;

namespace FirstVersion.Controllers;   
public class PetController : Controller   
{      
    [HttpGet("pet")]
    public string Pet()        
    {            
        return "Welcome to the Pet Route!";        
    }    
}