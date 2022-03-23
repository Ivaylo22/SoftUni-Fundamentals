using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string power = Console.ReadLine();
            int bomb;
            int power1;
            int sum = 0;
            int[] lineSplit = line.Split().Select(int.Parse).ToArray();
            int[] powerSplit = power.Split().Select(int.Parse).ToArray();
            bomb = powerSplit[0];
            power1 = powerSplit[1];

            for (int i = 0; i < lineSplit.Length; i++)
            {

                if (lineSplit[i] == bomb)
                {
                    lineSplit[i] = 0;
                    for (int j = 1; j <= power1; j++)
                    {

                        if (i - j >= 0)
                        {
                            lineSplit[i - j] = 0;
                        }
                        if (i + j <= lineSplit.Length - 1)
                        {
                            lineSplit[i + j] = 0;
                        }
                    }
                }

            }
            foreach (var number in lineSplit)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}