﻿namespace _07.SortedSubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortedSubsetSums
    {
        public static void Main()
        {
            int targetSum = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var allCombinations = new List<List<int>>();

            bool isFound = false;
            for (int i = 0; i < Math.Pow(2, numbers.Length); i++)
            {
                List<int> combinations = new List<int>();
                for (int j = 0; j < numbers.Length; j++)
                {
                    int bitwiseMask = 1 << (numbers.Length - j - 1);
                    if ((i & bitwiseMask) != 0)
                    {
                        combinations.Add(numbers[j]);
                    }
                }

                if (combinations.Sum() == targetSum && combinations.Count != 0)
                {
                    isFound = true;
                    combinations.Sort();
                    allCombinations.Add(combinations);
                }
            }

            allCombinations = allCombinations.OrderBy(x => x.Count).ThenBy(x => x.ElementAt(0)).ToList();

            HashSet<string> result = new HashSet<string>();

            if (isFound)
            {
                foreach (var list in allCombinations)
                {
                    result.Add(string.Format("{0} = {1}", string.Join(" + ", list), targetSum));
                }
            }
            else
            {
                result.Add("No matching subsets.");
            }

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}