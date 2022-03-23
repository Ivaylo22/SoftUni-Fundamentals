using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double> productPrices = new Dictionary<string, double>();
            Dictionary<string, int> productCount = new Dictionary<string, int>();
            Dictionary<string, double> productSums = new Dictionary<string, double>();


            while (input != "buy")
            {
                string[] tokens = input.Split(" ").ToArray();
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                int count = int.Parse(tokens[2]);

                if (!productPrices.ContainsKey(product))
                {
                    productPrices.Add(product, price);
                    productCount.Add(product, count);
                    productSums.Add(product, 0);
                }
                else
                {
                    productPrices[product] = price;
                    productCount[product] += count;
                }

                productSums[product] = productPrices[product] * productCount[product];
                input = Console.ReadLine();
            }
            foreach (var product in productSums)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
            }
        }
    }
}
