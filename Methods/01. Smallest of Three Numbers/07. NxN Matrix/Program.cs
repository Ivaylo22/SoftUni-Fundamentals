using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NxNMatrix(number);
        }

        static void NxNMatrix(int input) {
            for (int i = 0; i < input; i++)
            {
                for (int y = 0; y < input; y++)
                {
                    Console.Write($"{input} ");
                }
                Console.WriteLine();
            }
        }
    }
}
