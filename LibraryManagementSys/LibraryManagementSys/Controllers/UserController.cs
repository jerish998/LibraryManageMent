using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSys.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
