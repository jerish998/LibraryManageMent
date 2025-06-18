using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSys.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
