using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] topInteger = new int[arr.Length];
            int topIntegerIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                bool isTopInteger = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];
                    if (nextNum >= currentNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topInteger[topIntegerIndex] = currentNum;
                    topIntegerIndex++;
                }
            }
            for (int i = 0; i < topIntegerIndex; i++) {
                Console.Write($"{topInteger[i]} ");
            }
        }
    }
}
