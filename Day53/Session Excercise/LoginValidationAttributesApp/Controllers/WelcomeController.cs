using Microsoft.AspNetCore.Mvc;

namespace LoginValidationAttributesApp.Views.Home
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
