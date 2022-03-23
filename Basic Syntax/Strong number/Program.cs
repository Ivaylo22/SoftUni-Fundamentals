using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long facturialSum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char currCh = number[i];
                int currDigit = (int)currCh - 48;

                long currentDigitFacturial = 1;
                for (int r = currDigit; r > 1; r--) {
                    currentDigitFacturial *= r;
                }
                facturialSum += currentDigitFacturial;
            }
            if (facturialSum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else {
                Console.WriteLine("no");
            }
        }
    }
}
