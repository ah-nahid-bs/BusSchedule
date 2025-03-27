using Microsoft.AspNetCore.Mvc;

namespace BusSchedule.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}