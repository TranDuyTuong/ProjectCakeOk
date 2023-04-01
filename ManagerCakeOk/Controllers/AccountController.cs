using Library.ServiceAdmin.ServiceAdminInjection.Account;
using Library.Utilities;
using Library.ViewModel.Admin.V_Account;
using Library.ViewModel.Admin.V_SignIn;
using ManagerCakeOk.Models.M_Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ManagerCakeOk.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccount _context;
        public AccountController(IAccount context)
        {
            _context = context;
        }

        // TODO: LOGIN SYSTEM
        [HttpGet]
        public IActionResult Login(string requestPath)
        {
            ViewBag.RequestPath = requestPath ?? "/";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(V_Login request)
        {
            if (request.Password != "123" && request.Username != "duytuong0503@gmail.com")
            {
                return new JsonResult(0);
            }
            else
            {
                var result_Model = new V_ResultIdentityLogin();
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email, request.Username),
                    };
                var identity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var authProperties = new AuthenticationProperties();
                await HttpContext.SignInAsync(
                      CookieAuthenticationDefaults.AuthenticationScheme,
                      new ClaimsPrincipal(principal), authProperties);
                HttpContext.Response.Cookies.Append("Token", "tuong");

                return RedirectToAction("Index", "Home");
            }
           
        }

        //TODO: Forbidden SYSTEM
        [HttpGet]
        public IActionResult Forbidden()
        {
            return View();
        }


    }
}
