using System;
using System.Collections.Generic;

namespace ZadTel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "exit")
                {
                    foreach (var n in names)
                    {
                        Console.WriteLine($"{n.Key} -> {n.Value}");
                    }
                    break;
                }
                string name = input[0];
                string phone = (input[1]);

                if (!names.ContainsKey(name))
                {
                    names.Add(name, phone);
                }
                else
                {
                    names[name] = phone;
                }
            }
        }
    }
}
