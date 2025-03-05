using CustomTagHelpersApp.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CustomTagHelpersApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserDTO());
        }

        [HttpPost]
        public IActionResult Index(UserDTO model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Form submitted successfully!";
            }
            return View(model);
        }

    }
}