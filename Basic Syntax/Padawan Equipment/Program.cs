using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double sum = 0;

            sum = lightsaberPrice * Math.Ceiling(count*1.10) + beltsPrice * (count - count/6) + robesPrice * count;

            if (money >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else {
                Console.WriteLine($"John will need {sum-money:f2}lv more.");
            }
        }
    }
}
