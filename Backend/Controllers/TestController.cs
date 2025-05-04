using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[Route("test")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet("public")]
    public ActionResult<object> PublicEndpoint()
    {
        return Ok(new { message = "This is a public endpoint, accessible by anyone." });
    }
    
    [Authorize]
    [HttpGet("user")]
    public ActionResult<object> UserEndpoint()
    {
        return Ok(new { message = "This endpoint is accessible by any authenticated user." });
    }
    
    [Authorize(Roles = "ADMIN")]
    [HttpGet("admin")]
    public ActionResult<object> AdminEndpoint()
    {
        return Ok(new { message = "This endpoint is only accessible by administrators." });
    }
}
