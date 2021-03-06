using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Domain.Enums;
using MedicalStoreManagement.Web.ViewModels.Accounts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);


                var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, isPersistent: false, lockoutOnFailure: false);

                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "MedicalStore");
                    //return View(model);
                }

                ModelState.AddModelError(string.Empty, "Invalid User Login Details...");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login", "Account");
            //return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            var result = await _userManager.CreateAsync(PrepareUser(model), model.Password);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "RegistrationError");
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            await _userManager.AddToRoleAsync(user, "Employee");

            foreach (var claim in PrepareClaims(user))
            {
                await _userManager.AddClaimAsync(user, claim);
            }

            return RedirectToAction("Login", "Account");
            //return View(model);
        }

        private User PrepareUser(UserViewModel model)
        {
            return new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.Email.Split()[0],
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                PhoneNumberConfirmed = true,
                Email = model.Email,
                EmailConfirmed = true
            };
        }

        private IList<Claim> PrepareClaims(MedicalStoreManagement.Domain.Entities.User user)
        {
            
            return new List<Claim>()
            {
                new Claim(ClaimTypes.Role, RoleTypes.Employee),
                new Claim(ClaimTypes.Name, user.Id),
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Surname, user.LastName)
            };
        }
    }
}