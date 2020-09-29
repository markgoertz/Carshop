using Bussines_Logic_Layer__BLL_.Model_BLL;
using Interfaces.BLL.interfaces;
using Interfaces.Entities;
using Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines_Logic_Layer__BLL_.Logic_BLL
{
    public class CarBLL:ICarBLL
    {
        private readonly ICarDatabaseHandler carDatabaseHandler;
        public CarBLL(ICarDatabaseHandler _CarDatabaseHandler)
        {
            carDatabaseHandler = _CarDatabaseHandler;
        }

        public List<ICar> GetCars()
        {
            return carDatabaseHandler.GetCars();
        }

        public void Createcar(ICar car)
        {
            var _car = new CarModel()
            {
                ID = car.ID,
                Brandname = car.Brandname,
                Modelname = car.Modelname,
                Transmission = car.Transmission,
                Enginepower = car.Enginepower,
                Weight = car.Weight,
                Acceleration = car.Acceleration,
                Cargospace = car.Cargospace,
                Seat = car.Seat,
                RentalPrice = car.RentalPrice,
                Fueltype = car.Fueltype
            };

            carDatabaseHandler.Createcars(_car);
        }
      
        public void DeleteCar(int ID)
        {
            carDatabaseHandler.DeleteCar(ID);
        }

        public ICar UpdateCar(ICar car)
        {
            carDatabaseHandler.UpdateCar(car);
            return car;
        }


    }
}
