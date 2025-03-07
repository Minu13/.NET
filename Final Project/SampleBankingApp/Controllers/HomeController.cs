using Microsoft.AspNetCore.Mvc;

namespace SampleBankingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
