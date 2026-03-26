using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
