using Microsoft.AspNetCore.Mvc;

namespace Adoption.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
