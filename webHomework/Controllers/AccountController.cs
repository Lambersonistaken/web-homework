﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using webHomework.Data;
using webHomework.Models;
using webHomework.ViewModels;

namespace webHomework.Controllers
{
    public class AccountController : Controller
    {

        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public AccountController(Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

      
        public IActionResult Login()
        {

            var response = new LoginViewModel();
            return View(response);
        }

        [HttpPost]

        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {

            if (!ModelState.IsValid) return View(loginViewModel);

            var user = await _userManager.FindByEmailAsync(loginViewModel.EmailAddress);

            if(user!= null)
            {
                // User is found, check password
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Race");
                    }
                }
                // Password is incorrect
                TempData["Error"] = "Wrong credentials. Please try again";
                return View(loginViewModel);
            }
            TempData["Error"] = "Wrong credentials. Please try again";
            return View(loginViewModel);
        }

    }
}
