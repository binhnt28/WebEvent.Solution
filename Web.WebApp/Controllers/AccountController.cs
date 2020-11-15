using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Data.DataContext;
using Web.Data.Entities;
using Web.Data.Model;

namespace Web.WebApp.Controllers
{
    
        [Route("account")]
        public class AccountController : Controller
        {
            private readonly UserManager<AppUser> userManager;
        private readonly DataDbContext dataDbContext;
            private readonly SignInManager<AppUser> signInManager;
            public AccountController(UserManager<AppUser> userManager,DataDbContext dataDbContext, SignInManager<AppUser> signInManager)
            {
            this.dataDbContext = dataDbContext;
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
                        LastName =register.LastName,
                        FirstName =register.FirstName,
                        FullName =register.LastName+" "+register.FirstName
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
        [HttpGet]
        [Route("detailsuser/{id}")]
        public async Task<IActionResult> DetailsUser(Guid? id)
        {
            var ticket = dataDbContext.Participants.Where(x => x.UserId == id).ToList();

            ViewBag.ticket =ticket;
            var user = await userManager.FindByIdAsync(id.ToString());
            return View(user);
        }
        [HttpGet]
        [Route ("edit/{id}")]
        public async Task<IActionResult> Update(Guid? id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            var model = new UserViewModel()
            {
                Id =user.Id,
                FirstName =user.FirstName,
                LastName =user.LastName,
                Email =user.Email,
                DateOfBirth =user.DateOfBirth,
                Gender =user.Gender,
                PhoneNumber =user.PhoneNumber,
                Address =user.Address,
                
            };
            return View(model);

        }
        [HttpPost]
        [Route("edit/{id}")]
        public async Task<IActionResult> Update(UserViewModel app)
        {
            var user = await userManager.FindByIdAsync(app.Id.ToString());
            if (ModelState.IsValid)
            {
                user.FirstName = app.FirstName;
                user.UserName = app.Email;
                user.LastName = app.LastName;
                user.FullName = app.LastName + " " + app.FirstName;
                user.DateOfBirth = app.DateOfBirth;
               user.Gender = app.Gender;
               user.PhoneNumber = app.PhoneNumber;
               user.Address = app.Address;
                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return Redirect("/account/detailsuser/" + app.Id);
                }
            }
            return View(app);
        }

        [Route("logout")]
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
