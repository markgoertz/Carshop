using Data_access_layer.Entities;
using Interfaces.Entities;
using Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data_access_layer.Handlers
{
    public class CarDatabaseHandler:ICarDatabaseHandler
    {

        private readonly string DataConnectionstring = @"Server=mssql.fhict.local;Database=dbi434548;User Id = dbi434548; Password=MijnFontysServer2020";
        public List<ICar> GetCars()
        {
            var cars = new List<ICar>();
            using (SqlConnection connection = new SqlConnection(DataConnectionstring))
            {
                string query = "SELECT * FROM [dbi434548].[dbo].[Car]";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Car CarDTO = new Car
                        {
                            ID = reader.GetInt32(0),
                            Brandname = reader.GetString(1),
                            Modelname = reader.GetString(2),
                            Transmission = reader.GetString(3),
                            Enginepower = reader.GetInt32(4),
                            Weight = reader.GetInt32(5),
                            Acceleration = reader.GetDouble(6),
                            Cargospace = reader.GetInt32(7),
                            Seat = reader.GetInt32(8),
                            RentalPrice = reader.GetDouble(9)
                        };

                        cars.Add(CarDTO);
                    }
                }
            }
            return cars;
        }
    }
}
        
