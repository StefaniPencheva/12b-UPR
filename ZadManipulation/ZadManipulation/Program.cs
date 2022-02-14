using System;
using System.Collections.Generic;
using System.Linq;

namespace ZadManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }
                if (int.TryParse(input, out int n) == true)
                {
                    nums.Sort();

                    Console.WriteLine(string.Join(" ", nums));
                }
                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "add":
                        {
                            int index = int.Parse(commands[1]);
                            int element = int.Parse(commands[2]);

                            if (!nums.Contains(element))
                            {
                                nums.Insert(index, element);
                            }
                            bool isInTheList = false;
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[1] == element)
                                {
                                    isInTheList = true;
                                    break;
                                }
                            }
                            if (isInTheList)
                            {
                                nums.Insert(index, element);
                            }
                            break;
                        }
                    case "contains":
                        {
                            int numberToSearch = int.Parse(commands[1]);
                            if (nums.Contains(numberToSearch))
                            {
                                Console.WriteLine(nums.IndexOf(numberToSearch));
                            }
                            else
                            {
                                Console.WriteLine("-1");
                            }
                            break;
                        }
                    case "remove":
                        {
                            int indexToRemove = int.Parse(commands[1]);
                            if (indexToRemove < 0 || indexToRemove >=nums.Count)
                            {
                                Console.WriteLine("Index is not correct!");
                            }
                            else
                            {
                                nums.RemoveAt(indexToRemove);
                            }
                            break;
                        }
                    case "swap":
                        {
                            int firstElement = int.Parse(commands[1]);
                            int indexOfFirstElement = nums.IndexOf(firstElement);

                            int secondElement = int.Parse(commands[2]);
                            int indexOfSecondElement = nums.IndexOf(secondElement);

                            int temp = firstElement;
                            nums[indexOfFirstElement] = secondElement;
                            nums[indexOfSecondElement] = temp;

                            break;
                        }
                    case "statistic":
                        {
                            Console.WriteLine(nums.Average());
                            Console.WriteLine(nums.Count);
                            break;
                        }
                }
            }
        }
    }
}
