using System;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGrades = int.Parse(Console.ReadLine());
            Dictionary<string, double> studentGrades = new Dictionary<string, double>();
            Dictionary<string, int> studentsNumberOfGrades = new Dictionary<string, int>();
            Dictionary<string, double> studentsFinal = new Dictionary<string, double>();


            for (int i = 0; i < numberOfGrades; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = grade;
                    studentsNumberOfGrades[name] = 1;
                }
                else
                {
                    studentGrades[name] += grade;
                    studentsNumberOfGrades[name]++;
                }

                studentsFinal[name] = studentGrades[name]/ studentsNumberOfGrades[name];
            }

            foreach (var student in studentsFinal)
            {
                if (student.Value >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value:f2}");
                }
            }
        }
    }
}
