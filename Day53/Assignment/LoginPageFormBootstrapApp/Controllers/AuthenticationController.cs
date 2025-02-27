using LoginFormWithValidation.Data;
using LoginPageFormBootstrapApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace LoginPageFormBootstrapApp.Controllers
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
        public ActionResult Login(LoginViewModel model)
        {
            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password))
            {
                ViewBag.ErrorMessage = "Username and password are required.";
                return View(model); 
            }

            if (_authService.ValidateUser(model.Username, model.Password))
            {
                ViewBag.SuccessMessage = "Login successful!";
                return View(model); 
            }

            ViewBag.ErrorMessage = "Invalid username or password. Please try again.";
            return View(model); 
        }
    }
}
