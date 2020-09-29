using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.BLL.interfaces
{
    public interface ICarBLL
    {
        List<ICar> GetCars();
        void Createcar(ICar car);
<<<<<<< HEAD
        ICar GetByID(ICar car);
        void DeleteCar(int ID);
        ICar UpdateCar(ICar car);
=======
>>>>>>> parent of 4e70de7... Push
    }
}
