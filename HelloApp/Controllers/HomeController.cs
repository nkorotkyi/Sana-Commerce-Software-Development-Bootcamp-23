using HelloApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            string authData = $"Hello, {name}";
            return Content(authData);
        }
    }
}