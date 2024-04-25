using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data;
using ParkingSystem.Models;
using System.Diagnostics;

namespace ParkingSystem.Controllers
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
            return View(DataAccess.Cars);
        }
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            DataAccess.Cars.Add(car);
            return Redirect("/");
        }
        [HttpPost]
        public IActionResult DeleteCar(string plateNumber) {
        var car = DataAccess.Cars.FirstOrDefault(x=>x.PlateNumber == plateNumber);
            if (car != null)
            {
                DataAccess.Cars.Remove(car);
            }
            return Redirect("/");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
