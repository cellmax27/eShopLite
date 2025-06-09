using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        // Logique d’authentification ici
        if (request.Name == "admin" && request.Password == "motdepasse")
            return Ok();

        return Unauthorized();
    }
}
