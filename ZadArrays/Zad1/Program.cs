using System;
using System.Linq;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                string[] COMMAND = Console.ReadLine().Split();
                switch (COMMAND[0].ToLower())
                {
                    case "reverse":
                        Array.Reverse(arr);
                        break;
                    case "distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "replace":
                        int index = int.Parse(COMMAND[1]);
                        string newWord = COMMAND[2];
                        arr[index] = newWord;
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
