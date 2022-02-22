using System;
using System.Collections.Generic;

namespace ZadNechetniSr
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!wordDictionary.ContainsKey(word.ToLower()))
                {
                    wordDictionary.Add(word.ToLower(), 1);
                }
                else
                {
                    wordDictionary[word.ToLower()]++;
                }
            }
            var results = new List<string>();
            foreach (var pair in wordDictionary)
            {
                if (pair.Value % 2 != 0)
                {
                    results.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
