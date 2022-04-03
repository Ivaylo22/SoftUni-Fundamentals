using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hero_Recruitment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = tokens[0];
                string heroName = tokens[1];

                if (command == "Enroll")
                {
                    if (heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                    else
                    {
                        heroes.Add(heroName,new List<string>());
                    }
                }

                else if (command == "Learn")
                {
                    string spellName = tokens[2];

                    if (!heroes.ContainsKey(heroName)) 
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (heroes[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} has already learnt {spellName}.");
                    }
                    else
                    {
                        heroes[heroName].Add(spellName);
                    }
                }

                else if (command == "Unlearn")
                {
                    string spellName = tokens[2];

                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (!heroes[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} doesn't know {spellName}.");
                    }
                    else 
                    { 
                        heroes[heroName].Remove(spellName);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Heroes");
            foreach (var hero in heroes) 
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");              
            }
        }
    }
}
