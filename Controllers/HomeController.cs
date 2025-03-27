using Microsoft.AspNetCore.Mvc;
using BusSchedule.Models;

namespace BusSchedule.Controllers
{
    public class BusController : Controller
    {
        private static List<Bus> Buses = new List<Bus>
        {
            new Bus { Id = 1, Route = "Dhaka to Chittagong", DepartureTime = "08:00 AM", ArrivalTime = "02:00 PM", BusType = "AC" },
            new Bus { Id = 2, Route = "Dhaka to Sylhet", DepartureTime = "09:00 AM", ArrivalTime = "01:00 PM", BusType = "Non-AC" },
            new Bus { Id = 3, Route = "Dhaka to Khulna", DepartureTime = "10:00 AM", ArrivalTime = "04:00 PM", BusType = "AC" },
        };
        public IActionResult Index()
        {
            return View(Buses);
        }
        public IActionResult Details(int id)
        {
            var bus = Buses.Find(b => b.Id == id);
            if (bus == null)
            {
                return NotFound();
            }
            return View(bus);
        }
    }
}
