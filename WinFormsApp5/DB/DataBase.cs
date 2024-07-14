using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Data.SqlClient;
using System.Text.Json;
using WinFormsApp5.Models;
namespace WinFormsApp5.DB;
public static class DataBase
{
    public static List<Car> cars { get; set; } = new List<Car>();
    private static SqlConnection connection = null;
    private static SqlCommand command = null;
    private static SqlDataReader reader = null;
    private static string connectionString = null;

    public static void ReadCarsFromDb()
    {
        using (connection = new(connectionString))
        {
            connection.Open();
            command = new($@"SELECT * FROM [Cars]", connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Car car = new Car();
                car.Id = int.Parse(reader["Id"].ToString());
                car.Marka = reader["Marka"].ToString();
                car.Model = reader["Model"].ToString();

                cars.Add(car);
            }
        }
    }

    public static List<Car> FindCarByMarka(string marka)
    {
        using (connection = new(connectionString))
        {

            connection.Open();
            command = new($@"SELECT * FROM [Cars] 
                                        WHERE Marka = @Cr", connection);
            command.Parameters.Add("@Cr", System.Data.SqlDbType.NVarChar).Value = marka;
            reader = command.ExecuteReader();
            List<Car> mCARS = new();
            while (reader.Read())
            {
                Car car = new Car();
                car.Id = int.Parse(reader["Id"].ToString()!);
                car.Marka = reader["Marka"].ToString()!;
                car.Model = reader["Model"].ToString()!;
                mCARS.Add(car);
            }

            return mCARS;
        }
    }

    public static List<Car> FindCarByModel(string model)
    {
        using (connection = new(connectionString))
        {

            connection.Open();
            command = new($@"SELECT * FROM [Cars] 
                                        WHERE Model = @Cr", connection);
            command.Parameters.Add("@Cr", System.Data.SqlDbType.NVarChar).Value = model;
            reader = command.ExecuteReader();
            List<Car> mCARS = new();
            while (reader.Read())
            {
                Car car = new Car();
                car.Id = int.Parse(reader["Id"].ToString()!);
                car.Marka = reader["Marka"].ToString()!;
                car.Model = reader["Model"].ToString()!;
                mCARS.Add(car);
            }

            return mCARS;
        }
    }

    public static void cm()
    {
        var builder = new ConfigurationBuilder();
        builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        var configuration = builder.Build();
        connectionString = configuration["ConnectionString"]!;
    }
}
