using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] myArray = new int[number];
            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
                sum += myArray[i];
            }

            Console.WriteLine(String.Join(" ", myArray));
            Console.WriteLine(sum);
        }
    }
}
