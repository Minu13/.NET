using LoginFormWithValidation.Data;
using Microsoft.AspNetCore.Mvc;

namespace LoginFormWithValidation.Controllers
{
    public class AuthenticationController : Controller
    {
        private AuthorizationService _authService = new AuthorizationService();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "Username and password are required.";
                return View();
            }

            if (_authService.ValidateUser(username, password))
            {
               
                ViewBag.SuccessMessage = "Login successful!";
                return View(); 
            }

            ViewBag.ErrorMessage = "Invalid username or password. Please try again.";
            return View();
        }
    }
}