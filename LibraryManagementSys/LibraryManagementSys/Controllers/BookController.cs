using LibraryManagementSys.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace LibraryManagementSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("ping")]
        public IActionResult Ping() => Ok("pong");

        //api/Book/id
        // [HttpGet()]
        //public async IActionResult BookDetails_Get(int id)
        //{
        //    await 
        //}



    }
}
