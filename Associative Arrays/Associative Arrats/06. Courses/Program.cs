using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                List<string> listOfStudents = new List<string>();
                string[] tokens = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string course = tokens[0];
                string nameOfStudent = tokens[1];
                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, listOfStudents);
                    listOfStudents.Add(nameOfStudent);
                }
                else
                {
                    courses[course].Add(nameOfStudent);
                }

                input = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                for (int i = 0; i < course.Value.Count; i++)
                {
                    Console.WriteLine($"-- {course.Value[i]}");
                }
            }
        }
    }
}
