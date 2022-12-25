using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Recyle_Project.Web.Models;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using NETCore.Encrypt.Extensions;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography;
using EntityLayer.Concrete;
using DataAccesLayer.Concrete;
using BussinessLayer.Concrete;
using DataAccesLayer.EntityFramework;

namespace Recyle_Project.Web.Controllers
{
    public class accountController : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());
        private readonly Context _context;
        public int userIDAccount;
        public accountController(Context databasecontext)
        {
           this._context= databasecontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {

            User user = _context.users.SingleOrDefault(x => x.userName.ToLower() == model.UserName.ToLower() && x.password == model.Password);
            if (user != null)
                {
                TempData["usid"] = user.UserID;

                TempData["userId"] = user.UserID;
                return RedirectToAction("recyle", "Recyle",user);
                }
                else
                {
                return RedirectToAction("Login", "Account");
                }
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            
            
                User user = new()
                {
                    password = model.Password,
                    userName = model.UserName,
                    walletAddress = EncryptWithSHA256(model.WalletName),
                    phoneNumber = model.phoneNumber,
                    ReValueWallet = 100000000,
                    ProfileImage = "/PhotoFolio/assets/img/gallery/Profil1.jpg",
                    SendValue = 0,
                    SendAddress = ""

                };
                um.USerAdd(user);
                return RedirectToAction("Login","Account");
            

            //return View(model);
        }
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
        public IActionResult Logouts()
        {
            return RedirectToAction("Login", "Account");
        }
    }
}
