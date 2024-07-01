using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : Controller
    {
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest registerRequest)
        {
            return Ok(registerRequest);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            return Ok(loginRequest);
        }

    }
}
