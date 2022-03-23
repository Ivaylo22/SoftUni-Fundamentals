using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isFound = false;
            for (int i = 0; i < arr.Length; i++) {
                int sumLeft = 0;
                int sumRight = 0;
                int currentIndex = i;
                if (currentIndex >= 1)
                {
                    for (int j = currentIndex - 1; j >= 0; j--)
                    {
                        sumLeft += arr[j];
                    }
                }
                else {
                    sumLeft = 0;
                }
                if (currentIndex <= arr.Length - 1)
                {
                    for (int k = currentIndex + 1; k < arr.Length; k++)
                    {
                        sumRight += arr[k];
                    }
                }
                else {
                    sumRight = 0;
                }
                if (sumLeft == sumRight) {
                    Console.WriteLine(currentIndex);
                    isFound = true;
                    break;
                }
            }
            if (!isFound) {
                Console.WriteLine("no");
            }
        }
    }
}
