using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using LibraryManagementSys.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LibraryManagementSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthProviderService _authService;
        public AuthController(AuthProviderService authProviderService) {
            _authService = authProviderService;
        }



        [HttpPost("login")]
        public IActionResult Login( [FromBody] LoginModels login)
        {
            if (login.Username == "admin" && login.Password == "password") // Replace with real validation
            {
                var token = _authService.GenerateJwtToken(login.Username);
                return Ok(new { token });
            }
            return Unauthorized("unauthorized");
        }

        public class LoginModels
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

    }
}
