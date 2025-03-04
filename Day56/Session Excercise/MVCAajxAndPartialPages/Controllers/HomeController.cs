using Microsoft.AspNetCore.Mvc;

namespace MVCAajxAndPartialPages.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
