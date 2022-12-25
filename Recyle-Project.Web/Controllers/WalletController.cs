using BussinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Recyle_Project.Web.Controllers
{
    public class WalletController : Controller
    {
        public readonly Context _context;

        public WalletController(Context context)
        {
            _context = context;
        }

        UserManager um = new UserManager(new EfUserRepository());
        [HttpGet]
        public IActionResult Index(int id)
        {
            var users = um.GetById(id);
            return View(users);
        }
        [HttpPost]
        public IActionResult Index(User user,int id)
        {
            var users = um.GetById(id);
            var userx = _context.users.FirstOrDefault(x => x.walletAddress == user.SendAddress);
            //var userss = um.GetByAdress(users.SendAddress);
            userx.ReValueWallet += user.SendValue;
            users.ReValueWallet -= user.SendValue;
            um.UserUpdate(users);
            um.UserUpdate(userx);
            return RedirectToAction("Index");
        }
    }
}
