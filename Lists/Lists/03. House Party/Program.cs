using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];
                if (command[2] == "not")
                {
                    notGoing(guests, name);
                }
                else if(command[2] != "not")
                {
                    going(guests, name);                   
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }

        static void going(List<string> guests, string nameToAdd)
        {
            if (!guests.Contains(nameToAdd))
            {
                guests.Add(nameToAdd);
            }
            else
            {
                Console.WriteLine($"{nameToAdd} is already in the list!");
            }
        }

        static void notGoing(List<string> guests, string nameToRemove) 
        {
            if (guests.Contains(nameToRemove)) 
            { 
            guests.Remove(nameToRemove);
            }
            else
            {
                Console.WriteLine($"{nameToRemove} is not in the list!");
            }
        }
    }
}
 