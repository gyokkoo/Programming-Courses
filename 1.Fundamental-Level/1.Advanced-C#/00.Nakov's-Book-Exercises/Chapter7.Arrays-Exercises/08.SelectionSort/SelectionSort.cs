using System;
using System.Linq;
/*
Sorting an array means to arrange its elements in an increasing (or decreasing) order. 
Write a program, which sorts an array using the algorithm "selection sort". 
 */
class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter an array of numbers in a single line, seperated by a space.");
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        SelectionSortNumbers(nums);

        Console.WriteLine("The numbers after sorting -> {0}", string.Join(" ", nums));
    }

    static void SelectionSortNumbers(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[min])
                {
                    min = j;
                }
                swap(nums, i, min);
            }
        }
    }

    static void swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
