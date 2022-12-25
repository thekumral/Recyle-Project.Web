using BussinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.RulesetToEditorconfig;
using Recyle_Project.Web.Models;

namespace Recyle_Project.Web.Controllers
{
    
    public class RecyleController : Controller
    {
        private Context _context;
        RecyleObjectManager om = new RecyleObjectManager(new EfRecyleObjectRepository());
        UserManager um=new UserManager(new EfUserRepository());
        
        public RecyleController(Context context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Recyle()
        {
            var reobjects = om.GetAllPoints();
            return View(reobjects);
        }
        [HttpGet]
        public IActionResult RecyleObjects(int id) 
        {
            TempData["Reobjectid"] = id;
            var ids = _context.recyleObjects.Find(id).TypeID;
            var reobject = _context.recyleObjects.Find(id);
            reobject.Recyletype = _context.recyletypes.Find(ids);
            return View(reobject);
        }
        [HttpPost]
        public IActionResult RecyleObjects(RecyleObjects updateReobject, int ReobjectId)
        {
            updateReobject.ObjectID = ReobjectId;
            return View(updateReobject);
        }
        [HttpGet]
        public IActionResult Wallet(int id)
        {
            var user=um.GetById(id);
            var reobjectinfo = om.GetById(Convert.ToInt32(TempData["ReObjectid"]));
            user.ReValueWallet += reobjectinfo.ReValue;
            um.UserUpdate(user);
            return View(user);
        }
        
    }
}
