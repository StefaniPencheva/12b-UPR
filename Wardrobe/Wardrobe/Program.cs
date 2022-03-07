using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> clothesColor = new Dictionary<string, string>();
            Dictionary<string, int> clothesCount = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split(); 

                if (input[0] == "Show")
                {
                    break;
                }

                switch (input[0])
                {
                    case "AddColor":
                        {
                            string clothe = input[1];
                            string color = input[2];
                            if (clothe.StartsWith("t"))
                            {
                                if (!clothesColor.ContainsKey(clothe))
                                {
                                    clothesColor.Add(clothe, color);
                                    clothesCount.Add(clothe, 1);
                                }
                                else
                                {
                                    clothesColor[clothe] = color;
                                    clothesCount[clothe] += 1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                            }
                            break;
                        }
                    case "AddQuantity":
                        {
                            string clothe = input[1];
                            int count = int.Parse(input[2]); 
                            if (clothesColor.ContainsKey(clothe))
                            {
                                clothesCount[clothe] += count;
                            }
                            break;
                        }
                    case "Remove":
                        {
                            string clothe = input[1];
                            int count = int.Parse(input[2]);

                            if (clothesCount.ContainsKey(clothe))
                            {
                                if (count >= clothesCount[clothe])
                                {
                                    Console.WriteLine("Not enough quantity!");
                                }
                                else
                                {
                                    clothesCount[clothe] -= count;
                                }
                            }
                            break;
                        }
                    case "Empty":
                        {
                            foreach (var clothe in clothesCount)
                            {
                                clothesCount[clothe.Key] = 0;
                            }
                            foreach (var clothe in clothesColor)
                            {
                                clothesColor[clothe.Key] = "blank";
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            int grandTotal = 0;

            foreach (var clothe in clothesCount)
            {
                string clotherName=clothe.Key;
                int clotheCount = clothe.Value;
                string clotheColor = clothesColor[clotherName];

                Console.WriteLine($"{clotherName}: {clotheColor} - {clotheCount}");

                grandTotal += clotheCount;
            }
            Console.WriteLine($"Grand Total: {grandTotal}");

        }
    }
}
