using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        class Vehicle 
        {
            public string TypeOfVehicle { get; set; }
            public string ModelOfVehicle { get; set; }
            public string ColorOfVehicle { get; set; }
            public int HorsePower { get; set; }

            public Vehicle(string typeOfVehicle, string modelOfVehicle, string colorOfVehicle, int horsePower)
            {
                this.TypeOfVehicle = typeOfVehicle;
                this.ModelOfVehicle = modelOfVehicle;
                this.ColorOfVehicle = colorOfVehicle;
                this.HorsePower = horsePower;
            }
        }
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();


            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                int horsePower = int.Parse(tokens[3]);
                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);
                if (type == "car")
                {
                    cars.Add(vehicle);
                }
                else
                {
                    trucks.Add(vehicle);
                }

                input = Console.ReadLine();
            }
            string input2 = Console.ReadLine();
            while (input2 != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (input2 == vehicle.ModelOfVehicle)
                    {
                        Console.WriteLine($"Type: {char.ToUpper(vehicle.TypeOfVehicle[0]) + vehicle.TypeOfVehicle.Substring(1)}");
                        Console.WriteLine($"Model: {vehicle.ModelOfVehicle}");
                        Console.WriteLine($"Color: {vehicle.ColorOfVehicle}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }
                input2 = Console.ReadLine();
            }
            double sumCars = 0;
            double sumTrucks = 0;
            double averageCars = 0;
            double averageTrucks = 0;

            foreach (Vehicle car in cars)
            {
                sumCars += car.HorsePower;
            }
            foreach (Vehicle truck in trucks)
            {
                sumTrucks += truck.HorsePower;
            }
            averageCars = sumCars / cars.Count;
            averageTrucks = sumTrucks / trucks.Count;

            if (cars.Count >0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
