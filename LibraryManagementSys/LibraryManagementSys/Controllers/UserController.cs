using Microsoft.AspNetCore.Mvc;
using LibraryManagementSys.Models;
using LibraryManagementSys.Services;

namespace LibraryManagementSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        #region const 
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        #endregion
        [HttpPost]
        public async Task<IActionResult>  AddUser(User user_details)
        {
        if (!user_details.ContactNumber.Any())
        {
                return BadRequest("Requires Data missing");
        }

           var result = await _userService.CreateUser();
            



        }
    }
}
