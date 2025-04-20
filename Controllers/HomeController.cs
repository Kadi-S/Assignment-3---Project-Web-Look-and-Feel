using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinanceHub.Models;

namespace FinanceHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action for the Home page
        public IActionResult Index()
        {
            return View(); // Returns the Index.cshtml view
        }

        // Action for the Charts page
        public IActionResult Charts()
        {
            return View(); // Returns the Charts.cshtml view
        }

        // Action for the About Us page
        public IActionResult About()
        {
            return View(); // Returns the About.cshtml view
        }

        // Action for Privacy page
        public IActionResult Privacy()
        {
            return View(); // Returns the Privacy.cshtml view
        }

        // Action for Get Started page
        public IActionResult GetStarted()  // <-- This is the one you just added
        {
            return View();
        }
        // Action for the Create page
        public IActionResult Create()
        {
            return View();
        }

        // Action for the Read page
        public IActionResult Read()
        {
            return View();
        }

        // Action for the Update page
        public IActionResult Update()
        {
            return View();
        }

        // Action for the Delete page
        public IActionResult Delete()
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