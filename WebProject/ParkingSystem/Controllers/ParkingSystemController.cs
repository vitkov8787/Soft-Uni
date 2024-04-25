using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data;
using ParkingSystem.Models;

namespace ParkingSystem.Controllers
{
    public class ParkingSystemController : Controller
    {
        private readonly AplicationDbContext _db;
        public ParkingSystemController(AplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Car> objCarsList = _db.Cars.ToList();

            return View(objCarsList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Car obj)
        {
            if (!ModelState.IsValid)
            {

                // Model validation failed, return the view with errors
                return View(obj);
            }
            //track what to add
            obj.ParkingStartTime = DateTime.Now;
            _db.Cars.Add(obj);
            // and when ready then save it
            _db.SaveChanges();
            // redirect action and controller !!!
            return RedirectToAction("Index");
        }



        [HttpPost]
        public IActionResult RemoveCar(int id)
        {
            var carToRemove = _db.Cars.FirstOrDefault(c => c.Id == id);
            if (carToRemove != null)
            {
                _db.Cars.Remove(carToRemove);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditCar(int id)
        {
            var carToEdit = _db.Cars.FirstOrDefault(c => c.Id == id);
            if (carToEdit == null)
            {
                // Handle case when car is not found (e.g., show an error message)
                return RedirectToAction("Index");
            }
            return View(carToEdit);
        }

        [HttpPost]
        public IActionResult EditCar(Car editedCar)
        {
            var existingCar = _db.Cars.FirstOrDefault(c => c.Id == editedCar.Id);
            if (existingCar != null)
            {

                // Update other properties
                // Update car properties with edited values
                existingCar.Mark = editedCar.Mark;
                existingCar.Plate = editedCar.Plate;
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}