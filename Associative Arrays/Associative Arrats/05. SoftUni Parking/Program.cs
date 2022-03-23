using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> licenses = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            int br = 0;

            while (br < numberOfCommands)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(" ").ToArray();
                string command = tokens[0];
                string name = tokens[1];

                if (command == "register")
                {
                    string car = tokens[2];
                    RegisterVehicle(licenses, name, car);
                }
                else 
                {
                    UnregisterVehicle(licenses, name);
                }
                br++;
            }

            foreach (var pair in licenses)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }

            static void RegisterVehicle(Dictionary<string, string> licenses, string name, string car) 
            {
                if (!licenses.ContainsKey(name))
                {
                    licenses.Add(name, car);
                    Console.WriteLine($"{name} registered {car} successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {car}");
                }
            }

            static void UnregisterVehicle(Dictionary<string, string> licenses, string name) 
            {
                if (licenses.ContainsKey(name))
                {
                    licenses.Remove(name);
                    Console.WriteLine($"{name} unregistered successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: user {name} not found");
                }
            }
        }
    }
}
