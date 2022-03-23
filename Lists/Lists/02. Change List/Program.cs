using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] token = input.Split();
                string action = token[0];

                if (action == "Delete")
                {
                    int numberToDo = int.Parse(token[1]);
                    numbersList.RemoveAll(x => x == numberToDo);
                }
                else if (action == "Insert")  
                {
                    int numberToDo = int.Parse(token[1]);
                    int indexToInsert = int.Parse(token[2]);
                    numbersList.Insert(indexToInsert, numberToDo);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbersList));

        }
    }
}
