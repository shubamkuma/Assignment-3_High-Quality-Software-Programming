using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_vehicle
{
    using Assignment_3_vehicle;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create instances of vehicles
            Vehicle car = new Car("Civic", "Honda", 2020, 50, 5, "Gasoline", "Automatic", false);
            Vehicle truck = new Truck("F-150", "Ford", 2018, 100, 3, "Pickup", true);
            Vehicle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2019, 80, 1000, "Gasoline", true);

            // Display details of vehicles
            Console.WriteLine("Car Details:");
            car.DisplayDetails();

            Console.WriteLine("\nTruck Details:");
            truck.DisplayDetails();

            Console.WriteLine("\nMotorcycle Details:");
            motorcycle.DisplayDetails();

            // Create an instance of RentalAgency
            RentalAgency agency = new RentalAgency(3);

            // Add vehicles to the fleet
            agency.AddVehicle(car, 0);
            agency.AddVehicle(truck, 1);
            agency.AddVehicle(motorcycle, 2);

            // Rent a vehicle
            agency.RentVehicle(car);

            // Display total revenue
            Console.WriteLine($"\nTotal Revenue: {agency.TotalRevenue:C}");
        }
    }
}