using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks2014.Controllers
{
    
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string name, string pass, string returnUrl)
        {
            if (name == "admin" && pass == "admin")
            {
                var claims = new List<Claim>() {
                    new Claim("username", name),
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimPrincipal = new ClaimsPrincipal(claimIdentity);
                await HttpContext.SignInAsync(claimPrincipal);

                return Redirect(returnUrl ?? "/");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
