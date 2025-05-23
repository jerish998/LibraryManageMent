using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSys.DbContextApp
{
    public class AdminProvider : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
