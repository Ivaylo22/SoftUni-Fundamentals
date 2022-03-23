using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> mines = new Dictionary<string, int>();

            while (input != "stop")
            {
                string mine = input;
                int value = int.Parse(Console.ReadLine());
                if (mines.ContainsKey(mine))
                {
                    mines[mine] += value;
                }
                else
                {
                    mines.Add(mine, value);
                }
                input = Console.ReadLine();
            }

            foreach (var item in mines)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
