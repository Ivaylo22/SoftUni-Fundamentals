using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string company = tokens[0];
                string ID = tokens[1];
                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                    companies[company].Add(ID);
                }
                else
                {
                    if (!companies[company].Contains(ID))
                    {
                        companies[company].Add(ID);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
