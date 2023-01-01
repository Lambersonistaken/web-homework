using Microsoft.AspNetCore.Mvc;

namespace webHomework.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("users")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
