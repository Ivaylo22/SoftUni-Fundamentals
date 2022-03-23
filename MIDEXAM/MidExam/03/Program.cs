using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split("&")
                .ToList();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] tokens = input.Split(" | ");
                string action = tokens[0];

                if (action == "Add Book")
                {
                    string nameToAdd = tokens[1];

                    if (!books.Contains(nameToAdd))
                    {
                        books.Insert(0, nameToAdd);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                else if (action == "Take Book")
                {
                    string bookToTake = tokens[1];
                    if (books.Contains(bookToTake))
                    {
                        books.Remove(bookToTake);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                else if (action == "Swap Books")
                {
                    string bookOne = tokens[1];
                    string bookTwo = tokens[2];

                    if (books.Contains(bookOne) && books.Contains(bookTwo))
                    {
                        int indexOne = books.IndexOf(bookOne);
                        int indexTwo = books.IndexOf(bookTwo);

                        books[indexOne] = bookTwo;
                        books[indexTwo] = bookOne;
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                else if (action == "Insert Book")
                {
                    string nameToInsert = tokens[1];
                    if (!books.Contains(nameToInsert))
                    {
                        books.Add(nameToInsert);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                else if (action == "Check Book")
                {
                    int index = int.Parse(tokens[1]);

                    if (index >=0 && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", books));

        }
    }
}
