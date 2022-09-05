using Microsoft.AspNetCore.Mvc;

namespace BurnoutGaming.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
