using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data;
using ParkingSystem.Models;

namespace ParkingSystem.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            return View(DataAccess.Cars);
        }
            
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            DataAccess.Cars.Add(car);

            return Redirect(nameof(Index));
        }
        [HttpPost]
        public IActionResult DeleteCar(string plateNumber)
        {
            var car = DataAccess.Cars.FirstOrDefault(x => x.PlateNumber == plateNumber);
            if (car != null)
            {
                DataAccess.Cars.Remove(car);
            }
            return Redirect(nameof(Index));
        }
    }
}
