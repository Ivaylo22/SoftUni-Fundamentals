using System;
using System.Linq;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ")
                .ToArray();

            string command = Console.ReadLine();
            int blacklistedCount = 0;
            int lostCount = 0;


            while (command != "Report")
            {
                string[] commands = command.Split();
                string action = commands[0];

                if (action == "Blacklist")
                {
                    bool isBlacklisted = false;
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == commands[1])
                        {
                            Console.WriteLine($"{names[i]} was blacklisted.");
                            names[i] = "Blacklisted";
                            isBlacklisted = true;
                            blacklistedCount++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (!isBlacklisted)
                    {
                        Console.WriteLine($"{commands[1]} was not found.");
                    }
                }

                else if (action == "Error")
                {
                    int index = int.Parse(commands[1]);
                    if (index >=0 && index < names.Length && names[index] != "Lost" && names[index] != "Blacklisted")
                    {
                        Console.WriteLine($"{names[index]} was lost due to an error.");
                        names[index] = "Lost";
                        lostCount++; 

                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }

                else if (action == "Change")
                {
                    int index = int.Parse(commands[1]);
                    string newName = commands[2];

                    if (index >= 0 && index < names.Length)
                    {
                        Console.WriteLine($"{names[index]} changed his username to {newName}.");
                        names[index] = newName;
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Blacklisted names: {blacklistedCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
