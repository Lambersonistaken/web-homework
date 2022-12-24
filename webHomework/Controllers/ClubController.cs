using Microsoft.AspNetCore.Mvc;
using webHomework.Data;
using webHomework.Models;

namespace webHomework.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;

  
    public ClubController(ApplicationDbContext context)
         {
            _context = context;             
         }      
        public IActionResult Index()
        {
            List<Club> clubs = _context.Clubs.ToList();
            return View(clubs);
        }

        public IActionResult Detail(int id)
        {
            Club club = _context.Clubs.FirstOrDefault(C => C.Id == id);
            return View(club);
        }
    }
}
