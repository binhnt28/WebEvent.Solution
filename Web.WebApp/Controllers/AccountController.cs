using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Data.Entities;
using Web.Data.Model;

namespace Web.WebApp.Controllers
{
  
        [Route("account")]
        public class AccountController : Controller
        {
            private readonly UserManager<AppUser> userManager;
            private readonly SignInManager<AppUser> signInManager;
            public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
            {
                this.userManager = userManager;
                this.signInManager = signInManager;
            }
            // GET: AccountController

            [HttpGet]
            [Route("register")]
            [AllowAnonymous]
            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            [Route("register")]
            [AllowAnonymous]

            public async Task<IActionResult> Register(RegisterViewModel register)
            {
                if (ModelState.IsValid)
                {
                    var user = new AppUser
                    {
                        UserName = register.Email,
                        Email = register.Email,
                    };
                    var result = await userManager.CreateAsync(user, register.Password);
                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("index", "home");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                return View(register);

            }
            [HttpGet]
            [Route("login")]
            [AllowAnonymous]
            public async Task<IActionResult> Login(string returnUrl)
            {
                LoginViewModel model = new LoginViewModel
                {
                    ReturnUrl = returnUrl,
                    ExternalLogins =
                    (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
                };

                return View(model);
            }

            [HttpPost]
            [AllowAnonymous]
            [Route("login")]
            public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
            {
                if (ModelState.IsValid)
                {
                    var result = await signInManager.PasswordSignInAsync(
                        model.Email,
                        model.Password,
                        model.RememberMe,
                        false);
                    if (result.Succeeded)
                    {
                        if (!string.IsNullOrEmpty(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("index", "home");
                        }
                    }

                }
                return View(model);
            }
            public async Task<IActionResult> Logout()
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("index", "home");
            }

            // This method added for role tutorial
            [HttpGet]
            [Route("AccessDenied")]
            [AllowAnonymous]
            public IActionResult AccessDenied()
            {
                return View();
            }
        }
}
