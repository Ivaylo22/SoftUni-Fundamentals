using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractTwoIntegers(SumTwoIntegers(a,b),c));

        }

        static int SumTwoIntegers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static int SubtractTwoIntegers(int a, int b) {
            int result = a - b;
            return result;
        }
    }
}
