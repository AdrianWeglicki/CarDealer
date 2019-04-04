using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInMenager;
        private readonly UserManager<IdentityUser> userMenager;

        public AccountController(SignInManager<IdentityUser> signInMenager, UserManager<IdentityUser> userMenager)
        {
            this.signInMenager = signInMenager;
            this.userMenager = userMenager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            var user = await userMenager.FindByNameAsync(loginVM.UserName);

            if(user != null)
            {
                var result = await signInMenager.PasswordSignInAsync(user, loginVM.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Username/password incorrect");

            return View(loginVM);
        }
        
        [HttpGet]
        public IActionResult Registration()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public async Task<IActionResult> Registration(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = loginVM.UserName };
                var result = await userMenager.CreateAsync(user, loginVM.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(new LoginVM());
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInMenager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
