using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_By_Age
{
    internal class Program
    {
        public static object List { get; private set; }

        class Person 
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public Person(string name, string iD, int age)
            {
                Name = name;
                ID = iD;
                Age = age;
            }

            public override string ToString()
            {
                return ($"{Name} with ID: {ID} is {Age} years old.");
            }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();
            while (input!= "End")
            {
                string[] tokens = input.Split(" ");
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);
                Person person = new Person(name, id, age);
                people.Add(person);
                input = Console.ReadLine();
            }
            List<Person> sortedList = people.OrderBy(person => person.Age).ToList();
            Console.WriteLine(String.Join("\n", sortedList));
        }
    }
}
