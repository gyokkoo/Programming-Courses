using System;
using System.Linq;
/*
Write a program, which finds the most frequently occurring element in an array. 
Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times). 
 */
class MostFrequentlyElement
{
    static void Main()
    {
        Console.WriteLine("Enter array of integers in a single line, separated by a comma.");

        char[] emptySpaces = { ' ', ',', '{', '}' };
        int[] nums = Console.ReadLine().Split(emptySpaces, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Array.Sort(nums);

        int mostFrequentCount = 0;
        int currFrequentCount = 1;
        int mostFrequentElement = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] == nums[i])
            {
                currFrequentCount++;
            }
            else
            {
                if (mostFrequentCount < currFrequentCount)
                {
                    mostFrequentCount = currFrequentCount;
                    mostFrequentElement = nums[i - 1];
                }
                currFrequentCount = 1;
            }
        }

        Console.WriteLine("Most frequently occuring element -> {0} ({1} times)", mostFrequentElement, mostFrequentCount);
    }
}