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


        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }
        public List<ICar> GetCars()
        {
            var cars = new List<ICar>();
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                            RentalPrice = reader.GetDouble(9),
                            Fueltype = reader.GetString(10)
                        };

                        cars.Add(CarDTO);
                    }
                }
            }
            return cars;
        }

        public void Createcars (ICar C1)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [dbi434548].[dbo].[Car] VALUES (@Brandname,@Modelname, @Transmission, @Enginepower, @Weight, @Acceleration, @Cargospace, @Seat, @Rentalprice, @Fueltype);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   

                    command.Parameters.AddWithValue("@ID", C1.ID);
                    command.Parameters.AddWithValue("@Brandname", C1.Brandname);
                    command.Parameters.AddWithValue("@Modelname", C1.Modelname);
                    command.Parameters.AddWithValue("@Transmission", C1.Transmission);
                    command.Parameters.AddWithValue("@Enginepower", C1.Enginepower);
                    command.Parameters.AddWithValue("@Weight", C1.Weight);
                    command.Parameters.AddWithValue("@Acceleration", C1.Acceleration);
                    command.Parameters.AddWithValue("@Cargospace", C1.Cargospace);
                    command.Parameters.AddWithValue("@Seat", C1.Seat);
                    command.Parameters.AddWithValue("@Rentalprice", C1.RentalPrice);
                    command.Parameters.AddWithValue("@Fueltype", C1.Fueltype);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
           
        }
    }
}
        
