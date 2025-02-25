using Microsoft.AspNetCore.Mvc;

namespace RedirectControllerActionApp.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            ViewBag.Message = "Please enter your credentials to log in.";
            return View();
        }
    }
}
