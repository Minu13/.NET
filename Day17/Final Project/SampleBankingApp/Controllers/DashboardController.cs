using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleBankingApp.DTOs;
using SampleBankingApp.Services;
using System.Security.Claims;

namespace SampleBankingApp.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        
        public async Task<IActionResult> Index()
        {
            
            var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            if (string.IsNullOrEmpty(userEmail))
            {
                return RedirectToAction("Login", "Auth");
            }

            UserDashboardDTO dashboardData = new UserDashboardDTO();

             dashboardData = await _dashboardService.GetUserDashboard(userEmail);

            return View(dashboardData);
        }
    }
}
