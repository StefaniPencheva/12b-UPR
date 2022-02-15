using System;
using System.Collections.Generic;
using System.Linq;

namespace ZadIzpit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Exit")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }
                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "delete":
                        {
                            int indexToRemove = int.Parse(commands[1]);
                             if (indexToRemove<0 || indexToRemove>nums.Count)
                            {
                             
                            }
                             else
                            {
                                nums.RemoveAt(indexToRemove);
                            }
                            break;
                        }
                    case "insert":
                        {
                            string element = commands[1];
                            int index = int.Parse(commands[2]);

                            if (!nums.Contains(element))
                            {
                                nums.Insert(index, element);
                            }
                            break;
                        }
                    case "swap":
                        {
                            string firstName = commands[1];
                            int indexOfFirstName = nums.IndexOf(firstName);
                            string secondName = commands[2];
                            int indexOfSecondName = nums.IndexOf(secondName);
                            if (nums.Contains(firstName) && nums.Contains(secondName))
                            {
                                string temp = firstName;
                                nums[indexOfFirstName] = secondName;
                                nums[indexOfSecondName] = temp;
                            }
                            break;
                        }
                    case "print":
                        {
                            if (input == "print")
                            {
                                Console.WriteLine(string.Join(" ", nums));
                            }
                            break;
                        }
                }
            }
        }
    }
}
