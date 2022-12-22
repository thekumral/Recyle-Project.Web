using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recyle_Project.Web.Models;
using System.Diagnostics;

namespace Recyle_Project.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public AppDbContext _context;

        public HomeController(ILogger<HomeController> logger,AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Login","Account");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult AddWallet()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}