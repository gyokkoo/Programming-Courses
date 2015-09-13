using System;
using System.Linq;
/*
Write a program, which finds a subsequence of numbers with maximal sum. 
E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11
 */
class MaxSumSubsequence
{
    static void Main()
    {
        Console.WriteLine("Enter array of integers in a single line, separated by a comma.");

        char[] emptySpaces = { ' ', ',', '{', '}' };
        int[] nums = Console.ReadLine().Split(emptySpaces, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int curSum = 0;
        int maxSum = 0;

        for (int j = 0; j < nums.Length; j++)
        {
            curSum += nums[j];
            if (maxSum < curSum)
            {
                maxSum = curSum;
            }
            else if (curSum < 0)
            {
                curSum = 0;
            }
        }

        Console.WriteLine(maxSum);
    }
}