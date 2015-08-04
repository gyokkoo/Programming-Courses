using System;
using System.Linq;
/*
Write a program to sort an array of numbers and then print them back on the console. 
The numbers should be entered from the console on a single line, separated by a space. 
Refer to the examples for problem 1.
Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
Hint: To understand the sorting process better you may use a visual aid, e.g. Visualgo
 */
class SelectionSortNumbers
{
    static void Main()
    {
        Console.Title = "Problem 2.	Sort Array of Numbers Using Selection Sort";
        Console.WriteLine("Enter numbers on a single line, separated by a space.");

        Console.Write("Enter order  ---> ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if(arr[j] < arr[min])
                {
                    min = j;
                }
                swap(arr, i, min);
            }
        }

        string sortedNums = string.Join(" ", arr);
        Console.WriteLine("Sorted order ---> {0}", sortedNums);
    }
    static void swap (int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
