using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++;
            int c = ++b;
            Console.WriteLine(c);
        }
    }
}
