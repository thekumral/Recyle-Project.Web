using BussinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Recyle_Project.Web.Controllers
{
    public class WalletController : Controller
    {
        private Context _context;
        UserManager um = new UserManager(new EfUserRepository());
        public IActionResult Index(int id)
        {
            var user = um.GetById(id);
            //var reobjects=om.GetById(id);
            //return View(reobjects);
            return View(user);
        }
    }
}
