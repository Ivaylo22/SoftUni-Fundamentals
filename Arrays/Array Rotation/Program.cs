using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int firstValue = arr[0];
                for (int j= 0; j <= arr.Length - 2; j++) {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = firstValue;
            }
            // 1 2 3 4
            // 2 3 4 1
            Console.WriteLine(string.Join(' ', arr));

        }
    }
}
