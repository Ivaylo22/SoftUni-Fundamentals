using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArrays = int.Parse(Console.ReadLine());

            int[] arr1 = new int[numberOfArrays];
            int[] arr2 = new int[numberOfArrays];

            for (int row = 1; row <= numberOfArrays; row++) {
                int[] currentRowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = currentRowData[0];
                int secondNumber = currentRowData[1];

                if (row % 2 != 0)
                {
                    arr1[row - 1] = firstNumber;
                    arr2[row - 1] = secondNumber;
                }
                else {
                    arr1[row - 1] = secondNumber;
                    arr2[row - 1] = firstNumber;
                }
            }
            Console.WriteLine(string.Join(' ', arr1));
            Console.WriteLine(string.Join(' ', arr2));

        }
    }
}
