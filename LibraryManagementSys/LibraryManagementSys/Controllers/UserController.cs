using Microsoft.AspNetCore.Mvc;
using LibraryManagementSys.Models;
using LibraryManagementSys.Services;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        #region const 
        private readonly IUserService _user_service;
        public UserController(IUserService userService)
        {
            _user_service = userService;


        }

        #endregion

        [HttpGet("{id}")]
        public ActionResult GetUsers(int id)
        {
            var users = _user_service.FindUser(id);



            return Ok(users); //  automatically serialized to JSON
        }

        [HttpPost("signup")]
        public async Task<IActionResult> AddUser(UserDto user_dto) {
            //if any phone number check for that
            if (await _user_service.UserExists(user_dto))
            {
                return BadRequest("Email already in use.");
            }

            var user = new User
            {
                UserName = user_dto.Name,
                Email = user_dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user_dto.Password) // Hash password
            };

            await _user_service.CreateUserAsync(user);
            return Ok("User registered successfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int user_id)
        {
            var result = await _user_service.DeleteUser(user_id);
            if (!result)
                return NotFound("User not found.");

            return Ok("User deleted successfully.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserDto user_dto)
        {

        }




        [HttpGet("userping")]
        public async Task<IActionResult> UserPing()
        {


            //var user = new User
            //{
            //    FullName = dto.FullName,
            //    Email = dto.Email
            //};

            var s = await _user_service.UserPing();
            return Ok(s);
        }
    }
}
