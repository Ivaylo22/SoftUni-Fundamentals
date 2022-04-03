using System;
using System.Linq;

namespace _01._String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Done")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = tokens[0];
                if (command == "Change")
                {
                    string charToChange = tokens[1];
                    string charToPlace = tokens[2];
                    text = text.Replace(charToChange, charToPlace);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string textToSearch = tokens[1];
                    if (text.Contains(textToSearch))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    
                }
                else if (command == "End")
                {
                    string substring = tokens[1];
                    if (text.EndsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    string charToSearch = tokens[1];
                    Console.WriteLine(text.IndexOf(charToSearch));
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int finalIndex = int.Parse(tokens[2]);
                    text = text.Substring(startIndex, finalIndex);
                    Console.WriteLine(text);
                }
                input = Console.ReadLine();
            }
        }
    }
}
