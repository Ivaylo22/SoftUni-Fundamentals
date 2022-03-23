using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double sum = 0;
            double pricePerOne = 0;


            if (type == "Students")
            {
                if (day == "Friday")
                {
                    pricePerOne = 8.45;
                }
                else if (day == "Saturday")
                {
                    pricePerOne = 9.80;
                }
                else if (day == "Sunday")
                {
                    pricePerOne = 10.46;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    pricePerOne = 10.90;
                }
                else if (day == "Saturday")
                {
                    pricePerOne = 15.60;
                }
                else if (day == "Sunday")
                {
                    pricePerOne = 16;
                }
            }
            else if (type == "Regular") {
                if (day == "Friday")
                {
                    pricePerOne = 15;
                }
                else if (day == "Saturday")
                {
                    pricePerOne = 20;
                }
                else if (day == "Sunday")
                {
                    pricePerOne = 22.50;
                }
            }
            sum = pricePerOne * count;

            if (type == "Students" && count >= 30)
            {
                sum = sum * 0.85;
            }
            else if (type == "Business" && count >= 100)
            {
                sum -= 10 * pricePerOne;
            }
            else if (type == "Regular" && 10 <= count && count<= 20) {
                sum = sum * 0.95;
            }

            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
