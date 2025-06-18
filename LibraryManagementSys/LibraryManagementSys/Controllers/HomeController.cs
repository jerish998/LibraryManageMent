using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSys.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
