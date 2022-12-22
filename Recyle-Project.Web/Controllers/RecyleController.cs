using Microsoft.AspNetCore.Mvc;
using Recyle_Project.Web.Models;

namespace Recyle_Project.Web.Controllers
{
    public class RecyleController : Controller
    {
        private AppDbContext _context;
        private readonly userRepository _userRepository;

        public RecyleController(AppDbContext context)
        {
            _userRepository = new userRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Recyle");
        }
        public IActionResult Recyle()
        {
            var reobject = _context.recyleObjects.ToList();
            return View(reobject);
        }
        [HttpGet]
        public IActionResult RecyleObject(int id)
        {
            var ids = _context.recyleObjects.Find(id).TypeID;
            var reobject = _context.recyleObjects.Find(id);
            reobject.Recyletype = _context.recyletypes.Find(ids);
            return View(reobject);
        }
       
    }
}
