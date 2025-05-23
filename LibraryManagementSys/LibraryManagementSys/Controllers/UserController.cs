using Microsoft.AspNetCore.Mvc;
using LibraryManagementSys.Models;
using LibraryManagementSys.Services;
using DTO;

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
        UserDto user_dto = new UserDto();
            user_dto.Name = user_details.UserName;
            user_dto.Password = user_details.Password;
            user_dto.Email = user_details.Email;
              await _userService.CreateUser(user_dto);




        }
    }
}
