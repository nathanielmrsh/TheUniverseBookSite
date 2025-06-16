using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheUniverseBookSite.Models;

namespace TheUniverseBookSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult The_Packs()
        {
            return View();
        }

        public IActionResult Grounded()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Work()
        {
            return View();
        }

        public IActionResult Storyboard()
        {
            return View();
        }

        public IActionResult Comic()
        {
            return View();
        }

        public IActionResult Writing()
        {
            return View();
        }

        public IActionResult Animatics()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Voice_Acting()
        {
            return View();
        }

        public IActionResult Fanart()
        {
            return View();
        }


        public IActionResult Other()
        {
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
