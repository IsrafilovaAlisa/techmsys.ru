using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using techmsys.ru.Models;

namespace techmsys.ru.Controllers
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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Dispetcher()
        {
            return View();
        }
        public IActionResult MathModel()
        {
            return View();
        }
        
        public IActionResult VR()
        {
            return View();
        }
        public IActionResult Building()
        {
            return View();
        }
        public IActionResult MobileInspection()
        {
            return View();
        }

        public IActionResult PersonnelMonitoring()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Cases()
        {
            return View();
        }

        public IActionResult MobileByPassCases()
        {
            return View();
        }

        public IActionResult SimulationModelingCases()
        {
            return View();
        }

        public IActionResult DispatchingCases()
        {
            return View();
        }

        public IActionResult VRCases()
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