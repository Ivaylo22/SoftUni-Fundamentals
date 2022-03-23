using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] token = input.Split();
                string action = token[0];

                if (action == "Add")
                {
                    wagons.Add(int.Parse(token[1]));
                }
                else 
                {
                    int peopleToAdd = int.Parse(action);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + peopleToAdd <= maxCapacity) { 
                            wagons[i] += peopleToAdd;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
