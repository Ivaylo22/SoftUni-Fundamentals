using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(CalculateNumberVowels(word));
        }

        static int CalculateNumberVowels(string word) { 
            char[] vowels = new char[] { 'a', 'e', 'u', 'i', 'o'};
            int vowelsCount = 0;
            foreach (char ch in word) {
                if (vowels.Contains(Char.ToLower(ch)))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
