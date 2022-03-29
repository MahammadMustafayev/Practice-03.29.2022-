using System;
using Practice_03_29_2022_.Models;
namespace Practice_03_29_2022_
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Mercedes", "Amg", DateTime.UtcNow.AddHours(3));
            Bus bus = new Bus(60, DateTime.UtcNow.AddHours(4));
            Vehicle[] vehicles = new Vehicle[2];

            vehicles[0] = car;
            vehicles[1] = bus;

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ShowInfo());
            }

        }
    }
}
