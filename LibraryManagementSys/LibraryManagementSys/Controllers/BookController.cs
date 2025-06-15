using LibraryManagementSys.Models;
using LibraryManagementSys.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace LibraryManagementSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookDetails _book_details;

        public BookController(IBookDetails bookDetails)
        {
            _book_details = bookDetails;
        }
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
        [Authorize]
        [HttpGet]
        public IActionResult Favorite() => Ok("authorized");



        [HttpGet("{id}")]
        public async Task<IActionResult> BookDetails_Get(int id)
        {
            var book_details = _book_details.BookDetails_Get(id);
        }





    }
}
