﻿using Business_Logic_Layer.Helper;
using Data_Access_Layer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Presentaion_Layer.Models;
using System.Threading.Tasks;

namespace Presentaion_Layer.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<ApplicationUser> UserManager { get; }
        public SignInManager<ApplicationUser> SignInManager { get; }
        #region Constructor
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        #endregion
        #region Sign up
        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    IsAgree = model.IsAgree
                };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded) 
                {
                    return RedirectToAction(nameof(Login));
                }
                else 
                {
                    foreach(var error in result.Errors) 
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
        #endregion
        #region Sign in
        public IActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid) 
            {
                var user = await UserManager.FindByEmailAsync(model.Email);
                if(user != null) 
                {
                    await SignInManager.SignInAsync(user,true);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "Invalid Email");
            }
            return View(model);
        }
        #endregion
        #region Sign Out
        public async new Task<IActionResult> SignOut() 
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
        #endregion
        #region Forgot password
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model) 
        {
            if (ModelState.IsValid) 
            {
                //send an email with the link to reset page
                var user = await UserManager.FindByEmailAsync(model.Email);
                if(user != null) 
                {
                    var Token = await UserManager.GeneratePasswordResetTokenAsync(user);
                    var ResetPasswordLink = Url.Action("ResetPassword", "Account", new { Email = user.Email , Token = Token},Request.Scheme);
                    var email = new Email()
                    {
                        Title = "Reset Password",
                        Body = ResetPasswordLink
                    };
                    EmailSettings.SendEmail(email, user);
                    return RedirectToAction(nameof(CompleteForgotPassword));
                }
            }
            return View(model);
        }
        public IActionResult CompleteForgotPassword()
        {
            return View();
        }
        #endregion
        #region Reset Password
        public IActionResult ResetPassword()
        {
            string Email = Request.Query["Email"].ToString();
            string Token = Request.Query["Token"].ToString();
            ViewData["token"] = Token;
            ViewData["email"] = Email;

            return View(new ResetPasswordViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = null;
                if(model.Email != null && model.Token != null) 
                {
                    
                    user = await UserManager.FindByEmailAsync(model.Email);
                }
                if (user != null) 
                {
                    var result = await UserManager.ResetPasswordAsync(user, model.Token, model.Password);
                    if(result.Succeeded)
                        return RedirectToAction(nameof(ResetPasswordDone));
                    foreach(var error in result.Errors) 
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
        public IActionResult ResetPasswordDone()
        {
            return View();
        }
        #endregion
    }
}
