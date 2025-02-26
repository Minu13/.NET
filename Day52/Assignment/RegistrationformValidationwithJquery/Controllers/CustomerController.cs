using Microsoft.AspNetCore.Mvc;

namespace RegistrationformValidationwithJquery.Controllers
{
    public class CustomerController : Controller
    {

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string firstName, string lastName)
        {
            if (firstName == null || lastName == null)
            {
                ViewBag.Message = "Registration Failed, all fields are required";
            }
            else
            {
                ViewBag.Message = $"Hello {firstName} {lastName}, registration successful! We will get back to you soon.";
            }
            return View();
        }
    }
}
