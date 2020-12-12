using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using EmployeeManagment.WebUI.Helpers.Abstarct;
using System.Text.Encodings.Web;

namespace EmployeeManagment.WebUI.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMailHelper _mailHelper;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IMailHelper mailHelper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mailHelper = mailHelper;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new UserLoginDto());
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("notAvailable.", "Hesap Bulunamadı");
                return View(model);
            }
            if (!user.IsActive)
            {
                ModelState.AddModelError("notAvailable.", "Hesap Aktif Değil");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home","");
            }
            ModelState.AddModelError(".", "Beklenmedik Hata Oluştu. Tekrar Deneyiniz.");

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new UserRegisterDto());
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            var exist = await _userManager.FindByEmailAsync(model.Email);

            if (exist != null)
            {
                ModelState.AddModelError("", "Email Kullanılmaktadır");
                return View(model);
            }
            var user = new User
            {
                UserName = model.Email.ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                NormalizedUserName = model.Email.ToUpper(),
                Email = model.Email,
                NormalizedEmail = model.Email.ToUpper(),
                PhoneNumber = "0",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                DateOfBirth = model.DateOfBirth,
                SecurityStamp = Guid.NewGuid().ToString(),
                IsActive = true
            };            
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");

                //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                //var callbackuRL = Url.Page("/Account/ConfirmEmail", pageHandler: null,
                //    values: new { area = "Identity", userId = user.Id, code = code },
                //    protocol: Request.Scheme);


                //await _mailHelper.SendMailAsync(model.Email, "Confirm Your Email", $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackuRL)}'>Click here </a>");


                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ViewResult AccessDenied() => View();
    }
}
