using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] arr2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] arr3 = new string[100];
            int k = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j]) {
                        arr3[k] = arr2[i];
                        k++;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", arr3));
        }
    }
}
