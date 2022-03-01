using System;
using System.Collections.Generic;

namespace ZadPoluchavaneEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> emails = new Dictionary<string, int>();
            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "List")
                {
                    break;
                }
                if (command[0] == "Add")
                {
                    var name = command[1];
                    var email = command[2];
                    if (!emails.ContainsKey(name))
                    {
                        Console.WriteLine($"{emails} already exists.");
                    }
                    else
                    {
                        emails.Add(name, email);
                    }
                }
                if (command[0] == "Receive")
                {
                    var letters = input[1];
                    if (!emails.ContainsKey(letters && letters.Contains))
                }
            }
        }
    }
}
