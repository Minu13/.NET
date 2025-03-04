using Microsoft.AspNetCore.Mvc;

namespace MVCAajxAndPartialPages.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
