using BussinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
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
            var ids = _context.recyleObjects.Find(id).TypeID;
            var reobject = _context.recyleObjects.Find(id);
            reobject.Recyletype = _context.recyletypes.Find(ids);
            //return View(reobject);
            //var reobject = om.GetById(id);
            return View(reobject);
        }
        [HttpPost]
        public IActionResult RecyleObjects(RecyleObjects updateProduct, int productId, string type)
        {
            updateProduct.ObjectID = productId;
            return View(updateProduct);
        }
        [HttpGet]
        public IActionResult Wallet(int id)
        {
            //var 
            //var reobjects=om.GetById(id);
            //return View(reobjects);
            return View();
        }
    }
}
