using System;
using System.Linq;
/*
Write a program to find a sequence of neighbor numbers in an array, 
which has a sum of certain number S. 
Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}.
 */
class CertainSumArr
{
    static void Main()
    {
        Console.WriteLine("Enter array of integers in a single line, separated by a comma.");

        char[] emptySpaces = { ' ', ',', '{', '}' };
        int[] nums = Console.ReadLine().Split(emptySpaces, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.Write("S = ");
        int sum = int.Parse(Console.ReadLine());

        int curSum = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length - 1; j++)
            {
                curSum += nums[j];

                if (curSum > sum)
                {
                    curSum = 0;
                }
                else if (curSum == sum)
                {
                    startIndex = i;
                    endIndex = j;
                    break;
                }
            }
            curSum = 0;
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}