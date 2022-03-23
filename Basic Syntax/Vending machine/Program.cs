using System;

namespace Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();
            double balance = 0;
            while (coin != "Start") {
                if (coin != "0.1" && coin != "0.2" && coin != "0.5" && coin != "1" && coin != "2")
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                else { 
                    balance += double.Parse(coin);
                }
                coin = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End") {
                if (product == "Nuts")
                {
                    if (balance >= 2.0)
                    {
                        balance -= 2.0;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (balance >= 0.7)
                    {
                        balance -= 0.7;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (balance >= 1.5)
                    {
                        balance -= 1.5;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (balance >= 0.8)
                    {
                        balance -= 0.8;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (balance >= 1.0)
                    {
                        balance -= 1.0;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {balance:f2}");
        }
    }
} 
