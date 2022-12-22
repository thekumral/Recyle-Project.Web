﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Recyle_Project.Web.Models;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using NETCore.Encrypt.Extensions;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography;

namespace Recyle_Project.Web.Controllers
{
    public class accountController : Controller
    {
        private AppDbContext _context;
        private readonly userRepository _userRepository;

        public accountController(AppDbContext context)
        {
            _userRepository = new userRepository();
           _context= context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                user user = _context.users.SingleOrDefault(x => x.userName.ToLower() == model.UserName.ToLower() && x.password== model.Password);

                if (user != null)
                {
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, user.userName?? string.Empty));
                    claims.Add(new Claim("userName", user.userName));
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    AuthenticationProperties properties = new AuthenticationProperties()
                    {

                        AllowRefresh = true,
                        IsPersistent = model.KeepLoggedIn
                    };
                    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, properties);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                   new ClaimsPrincipal(identity), properties);

                    return RedirectToAction("index", "Recyle");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is incorrect.");
                }
            }

            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Login()
        {

            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Recyle");

            return View();


        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(RegisterViewModel model)
        {
            if (_context.users.Any(x => x.userName.ToLower() == model.UserName.ToLower()))
            {
                ModelState.AddModelError(nameof(model.UserName), "Username is already exist.");
                return View(model);
            }
            if (ModelState.IsValid)
            {
                user user = new()
                {
                    password = model.Password,
                    userName = model.UserName,
                    walletAddress= EncryptWithSHA256(model.WalletName),
                    phoneNumber = model.phoneNumber,
                };
                _context.users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login","Account");
            }

            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        private string EncryptWithSHA256(string password)
        {
            string md5salt = "911892D7";
            string saltedPassword = md5salt + password;
            string hashedPassword = saltedPassword.SHA256();
            return hashedPassword;
        }
    }
}