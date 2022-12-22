using Microsoft.AspNetCore.Mvc;

namespace webHomework.Controllers
{
    public class ClubController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
