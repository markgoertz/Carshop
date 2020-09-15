using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Handlers
{
    public interface ICarDatabaseHandler
    {
        List<ICar> GetCars();
    }
}
