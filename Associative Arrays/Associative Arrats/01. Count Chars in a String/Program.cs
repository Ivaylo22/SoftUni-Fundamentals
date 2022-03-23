using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .Where(c => c != ' ')
                .ToArray();

            Dictionary<char, int> charsPairs = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char charToSearch = input[i];
                if (charsPairs.ContainsKey(charToSearch))
                {
                    charsPairs[charToSearch]++;
                }
                else
                {
                    charsPairs.Add(charToSearch, 1);
                }
            }
            foreach (var pair in charsPairs)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
