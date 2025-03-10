﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using FormAuthenticationEmpCRUD.DTOs;

namespace FormAuthenticationEmpCRUD.Controllers
{
    public class Login_Controller : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //authenctication service

            //  TempData["LoggedInUser"]= dto.UserName;

            var claims = new List<Claim> {
                new Claim (ClaimTypes.Name,dto.UserName),
                 new Claim (ClaimTypes.Email,dto.UserName)

            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction("DisplayAll", "Employee");
        }
    }
}

