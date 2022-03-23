using System;
using System.Linq;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (isDivisibleByEight(i) && isHoldingOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isDivisibleByEight(int number) {
            bool isDivisible = false;
            int lastDigit =0;
            int sum = 0;
            while (number != 0) {
                lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }
            if (sum % 8 == 0) { 
            isDivisible = true;
            }
            return isDivisible;
        }

        static bool isHoldingOddDigit(int number) {
            bool isHoldingOddDigit = false;
            int lastDigit = 0;
            int[] oddNumbers = new int[]{ 1, 3, 5, 7, 9};
            while (number != 0)
            {
                lastDigit = number % 10;
                if (oddNumbers.Contains(lastDigit)) {
                    isHoldingOddDigit = true;
                }
                number /= 10;
            }
            return isHoldingOddDigit;
        }
    }
}
