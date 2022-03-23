using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{GetResult(a,b):f2}");
        }

        static double GetResult(int a, int b) {
            double resultA = 1;
            double resultB = 1;

            for (int i = 1; i <= a; i++)
            {
                resultA *= i;
            }
            for (int i = 1; i <= b; i++)
            {
                resultB *= i;
            }
            return resultA/ resultB;
        }
    }
}
