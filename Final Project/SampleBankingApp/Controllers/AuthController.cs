using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SampleBankingApp.DTOs;
using SampleBankingApp.Services;
using System.Security.Claims;


namespace SampleBankingApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterDTO model)
        {
           
            if (!ModelState.IsValid)
            {
                
                foreach (var key in ModelState.Keys)
                {
                    foreach (var error in ModelState[key].Errors)
                    {
                        Console.WriteLine($"Validation Error - {key}: {error.ErrorMessage}");
                    }
                }

                var errors = ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray());

                return BadRequest(errors);
            }

            bool isRegistered = _userService.RegisterUser(model);
            

            if (isRegistered)
                return Json(new { success = true, redirectUrl = "/Auth/Login" });

            return BadRequest(new { message = "Registration failed!" });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
                return Json(new { success = false, message = string.Join(", ", errors) });
            }


            var user = _userService.GetUserByEmail(model.Email);

            if (user == null)
            {

                return Json(new { success = false, message = "Invalid email or password." });
            }

            bool passwordIsValid = BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash);


            if (!passwordIsValid)
            {
                return Json(new { success = false, message = "Invalid email or password." });
            }

            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, user.FullName),
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.Role, user.UserType)
    };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

    }
}
