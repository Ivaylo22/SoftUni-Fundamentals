using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    public class Student 
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public double grade { get; set; }

        public override string ToString()
        {
            return ($"{firstName} {lastName}: {grade:f2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] tokens = Console.ReadLine().Split (" ");
                string firstName = tokens[0];
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            List<Student> sortedArticles = students.OrderByDescending(x => x.grade).ToList();

            Console.WriteLine(string.Join("\n", sortedArticles));
        }
    }
}
