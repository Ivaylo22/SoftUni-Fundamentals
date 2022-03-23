using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(FindMin(a, b, c)) ;
        }

        static double FindMin(double a, double b, double c) {
            return Math.Min(Math.Min(b,c),a);
        }
    }
}
