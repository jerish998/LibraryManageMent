using Microsoft.AspNetCore.Mvc;
using LibraryManagementSys.Models;
using LibraryManagementSys.Services;

namespace LibraryManagementSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpPost({newuser})]
        public IActionResult AddUser(User user_details)
        {
        if (user_details.UserId.ToString().Any())
        {
            Console.WriteLine("invalid user");
        }





        }
    }
}
