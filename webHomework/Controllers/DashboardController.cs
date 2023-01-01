using Microsoft.AspNetCore.Mvc;
using webHomework.Data;
using webHomework.Interfaces;
using webHomework.ViewModels;

namespace webHomework.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _dashboardRepository;

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

        public async Task<IActionResult> Index()
        {
            var UserRaces = await _dashboardRepository.GetAllUserRaces();
            var userClubs = await _dashboardRepository.GetAllUserClubs();
            var dashboardViewModel = new DashboardViewModel()
            {
                Races = UserRaces,
                Clubs = userClubs

            };
            return View(dashboardViewModel);
        }
    }
}
