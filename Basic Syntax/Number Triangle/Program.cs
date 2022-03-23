using System;

namespace Number_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++) /*  тук row беше < от n,а трябва да е  <= от n.  */

            {
                /// беше излишно да слагаш тук да ти принтира първата цифра.
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();/// новият ред беше извън цикълът.
            }
        }
    }
}
