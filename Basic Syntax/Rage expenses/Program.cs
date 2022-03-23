using System;

namespace Rage_expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            int headsetCount = count /2;
            int mouseCount = count /3;
            int keyboardCount = count /6;
            int displayCount = count /12;

            double expenses = headset * headsetCount + mouse * mouseCount + keyboard * keyboardCount + display * displayCount;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
