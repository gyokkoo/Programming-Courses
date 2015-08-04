using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{
    static void Main()
    {
        Console.Title = "Problem 7.	* Sorted Subset Sums";
        Console.WriteLine("Enter a number N and an array of integers, on a single line.");

        Console.Write("N = ");
        int targetSum = int.Parse(Console.ReadLine());

        Console.WriteLine("Ener an array of integers:");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool isFound = false;

        List<List<int>> unsorted = new List<List<int>>();

        Console.WriteLine("The unique sorted subsets with sum {0} are:", targetSum);

        int numOfSubsets = 1 << numbers.Length;
        for (int i = 0; i < numOfSubsets; i++)
        {
            List<int> subset = new List<int>();
            int index = numbers.Length - 1;
            int bitMask = i;

            while (bitMask > 0)
            {
                if ((bitMask & 1) == 1)
                {
                    subset.Add(numbers[index]);
                }

                bitMask = bitMask >> 1;
                index--;
            }

            if ((subset.Sum() == targetSum) && (subset.Count != 0))
            {
                isFound = true;
                subset.Sort();
                unsorted.Add(subset);
            }
        }

        List<List<int>> result = unsorted.OrderBy(x => x.Count).ThenBy(x => x.ElementAt(0)).ToList();

        if (isFound)
        {
            foreach (List<int> list in result)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", list), targetSum);
            }
        }
        else
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}
