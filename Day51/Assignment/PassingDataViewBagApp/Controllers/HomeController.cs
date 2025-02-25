using Microsoft.AspNetCore.Mvc;

namespace PassingDataViewBagApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string username)
        {
            ViewBag.Username = username;
            return View();
        }
    }
}
