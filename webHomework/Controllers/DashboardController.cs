using Microsoft.AspNetCore.Mvc;

namespace webHomework.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
