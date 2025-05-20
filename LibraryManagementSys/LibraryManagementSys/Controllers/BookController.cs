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

        //api/Book/id
        [HttpGet({id})]
        public async IActionResult BookDetails_Get(int id)
        {
        await 
            Book book = new Book();
            return Ok(book);
        }



    }
}
