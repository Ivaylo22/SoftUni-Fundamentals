using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            List<int> secondPlayer = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                if (firstPlayer.First() > secondPlayer.First())
                {
                    int winningCard = firstPlayer.First();
                    int losingCard = secondPlayer.First();
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.Add(losingCard);
                    firstPlayer.Add(winningCard);
                }
                else if (firstPlayer.First() < secondPlayer.First())
                {
                    int winningCard = secondPlayer.First();
                    int losingCard = firstPlayer.First();
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                    secondPlayer.Add(losingCard);
                    secondPlayer.Add(winningCard);
                }
                else if (firstPlayer.First() == secondPlayer.First()) {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
            }
            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");

            }
        }
    }
}
