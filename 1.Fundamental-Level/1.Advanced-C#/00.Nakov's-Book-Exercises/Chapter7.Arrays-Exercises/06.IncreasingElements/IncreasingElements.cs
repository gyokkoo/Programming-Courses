using System;
using System.Linq;
using System.Collections.Generic;
/*
Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. 
It is not necessary the elements to be consecutively placed. 
E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}. 
 */
class IncreasingElements
{
    static void Main()
    {
        Console.WriteLine("Enter array of integers in a single line, separated by a cmoma.");

        char[] emptySpaces = { ' ', ',', '{', '}' };
        int[] nums = Console.ReadLine().Split(emptySpaces, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        PrintLIS(nums);
    }

    static void PrintLIS(int[] nums)
    {
        string[] paths = new string[nums.Length];
        int[] sizes = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            sizes[i] = 1;
            paths[i] = nums[i] + " ";
        }

        int maxLength = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j] && sizes[i] < sizes[j] + 1)
                {
                    sizes[i] = sizes[j] + 1;
                    paths[i] = paths[j] + nums[i] + " ";

                    if (maxLength < sizes[i])
                    {
                        maxLength = sizes[i];
                    }
                }
            }
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (sizes[i] == maxLength)
            {
                Console.Write(paths[i] + " ");
            }
        }
        Console.WriteLine();
    }
}