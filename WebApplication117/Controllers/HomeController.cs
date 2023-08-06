using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication117.Database;
using WebApplication117.Models;

namespace WebApplication117.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext db;

        public HomeController(ILogger<HomeController> logger,ApplicationContext d)
        {
            _logger = logger;
            db = d;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Insert(User u)
        {
            db.Users.Add(u);
            await db.SaveChangesAsync();
            return RedirectToAction("Second");
        }
        public IActionResult Second()
        {
            ViewBag.Data = db.Users;
            return View();
        }
        public IActionResult Privacy()
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