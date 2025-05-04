using Backend.Model;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
public class AuthController : ControllerBase
{
    
    
    [HttpPost]
    public IActionResult Login(Users user)
    {
        var email = user.Email;
        var password = user.Password;

        if (true)
        {
            Console.WriteLine("do this");
        }
        return Ok();
    }
}