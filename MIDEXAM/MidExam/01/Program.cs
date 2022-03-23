using System;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= numberOfCities; i++)
            {
                string nameOfTheCity = Console.ReadLine();
                decimal earned = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());
                bool isRainy = false; ;

                if (i % 5 == 0)
                {
                    earned *= 0.9m;
                    isRainy = true;
                }
                else if (i % 3 == 0)
                {
                    if (!isRainy)
                    {
                        expenses *= 1.5m;
                    }
                }
                sum += earned - expenses;
                Console.WriteLine($"In {nameOfTheCity} Burger Bus earned {earned - expenses:f2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {sum:f2} leva.");
        }
    }
}
