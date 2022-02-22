using System;
using System.Collections.Generic;

namespace MinZad
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "stop")
                {
                    foreach (var product in products)
                    {
                        Console.WriteLine($" (product.Key)-> (product.value)");
                    }
                    break;

                }
                string productName = input;

                int quantity = int.Parse(Console.ReadLine()); 
                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, quantity);
                }
                else
                {
                    products[productName] += quantity;
                }
            }
        }
    }
}
