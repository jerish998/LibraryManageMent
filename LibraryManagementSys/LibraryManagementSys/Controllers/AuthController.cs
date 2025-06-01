using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


using LibraryManagementSys.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using LibraryManagementSys.Models;

namespace LibraryManagementSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthProviderService _authService;
        public AuthController(IAuthProviderService authProviderService) {
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

      

    }
}
