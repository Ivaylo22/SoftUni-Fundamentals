using System;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(.+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1";
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    Console.WriteLine($"Password: {match.Groups[2]}{match.Groups[3]}{match.Groups[4]}{match.Groups[5]}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
