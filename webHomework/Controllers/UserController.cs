using Microsoft.AspNetCore.Mvc;
using webHomework.Interfaces;

namespace webHomework.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("users")]
        public async IActionResult Index()
        {
            var users = await _userRepository.GetAllUsers();
            return View();
        }
    }
}
