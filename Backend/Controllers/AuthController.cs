using Backend.DTO; using Backend.Services; using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController] [Route("api/[controller]")] public class AuthController(AuthService authService) : ControllerBase { private readonly AuthService _authService = authService;

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
    {
        try
        {
            var token = await _authService.RegisterAsync(registerDto);
            return Ok(new { Token = token });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }

}