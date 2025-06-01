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



        //[HttpPost]
        //public async Task<IActionResult>  AddUser(User user_details)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);


        //         return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);

        //     }


        //    if (!user_details.ContactNumber.Any())
        //{
        //        return BadRequest("Requires Data missing");
        //}
        //UserDto user_dto = new UserDto();
        //    user_dto.Name = user_details.UserName;
        //    user_dto.Password = user_details.Password;
        //    user_dto.Email = user_details.Email;
        //      await _userService.CreateUser(user_dto);


        //    //_context.Users.Add(user);
        //    //await _context.SaveChangesAsync();

        //    //return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);

        //}


        //[HttpPost]
        //public async Task<IActionResult> CreateUser()
        //{


        //    //var user = new User
        //    //{
        //    //    FullName = dto.FullName,
        //    //    Email = dto.Email
        //    //};

        //   var s =  await _user_service.UserPing();
        //    return Ok(s);
        //}

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
