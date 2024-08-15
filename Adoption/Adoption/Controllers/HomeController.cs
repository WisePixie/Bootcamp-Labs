using Adoption.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Adoption.Controllers
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
            var breeds = DbContext.Animals.Select(a => a.Breed).Distinct().ToList();
            return View(breeds);
        }

        public IActionResult Result()
        {
            return View();
        }

        public IActionResult Adopt()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        
        public IActionResult AddAnimal()
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
