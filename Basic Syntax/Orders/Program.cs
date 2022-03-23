using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double fullSum = 0;
            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                double sum = days * count * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
                fullSum += sum;
            }
            Console.WriteLine($"Total: ${fullSum:f2}");
        }
    }
}
