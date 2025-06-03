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
