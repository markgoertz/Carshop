using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces.BLL.interfaces;
using System.Reflection.Metadata.Ecma335;
using Car_To_Go.Models;

namespace Car_To_Go.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarBLL _carBLL;
        public CarController(ICarBLL carBLL)
        {
            _carBLL = carBLL;
        }
        public ActionResult Index()
        {
            var allcars = _carBLL.GetCars();
            var cars = new List<CarViewModel>();

            foreach (var car in allcars)
            {
                cars.Add(new CarViewModel
                {
                    ID = car.ID,
                    Seat = car.Seat,
                    Enginepower = car.Enginepower,
                    Acceleration = car.Acceleration,
                    Brandname = car.Brandname,
                    Cargospace = car.Cargospace,
                    Modelname = car.Modelname,
                    RentalPrice = car.RentalPrice,
                    Transmission = car.Transmission,
                    Weight = car.Weight,
                    Fueltype = car.Fueltype,
                    

                });
            }
            return View(cars);
        }


        [HttpGet]
        public ActionResult Create()
        {
            var carviewmodel = new CarViewModel();
            return View(carviewmodel);
        }

        [HttpPost]
        public ActionResult Create(CarViewModel car)
        {
            _carBLL.Createcar(car);

            return RedirectToAction("Index");
        }



    }
}
