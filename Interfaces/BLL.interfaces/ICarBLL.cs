using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.BLL.interfaces
{
    public interface ICarBLL
    {
        List<ICar> GetCars();
    }
}
