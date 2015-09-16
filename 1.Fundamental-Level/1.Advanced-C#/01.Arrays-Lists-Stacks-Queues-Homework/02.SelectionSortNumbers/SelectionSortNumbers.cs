using System;
using System.Linq;
/*
Write a program to sort an array of numbers and then print them back on the console. 
The numbers should be entered from the console on a single line, separated by a space. 
Refer to the examples for problem 1.
Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
Hint: To understand the sorting process better you may use a visual aid, e.g. Visualgo
Input	            Output
6 5 4 10 -3 120 4	-3 4 4 5 6 10 120
10 9 8	            8 9 10
 */
class SelectionSortNumbers
{
    static void Main()
    {
        Console.Title = "Problem 2.	Sort Array of Numbers Using Selection Sort";
        Console.WriteLine("Enter numbers on a single line, separated by a space.");

        Console.Write("Enter order  ---> ");
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arrayOfNumbers.Length; j++)
            {
                if (arrayOfNumbers[j] < arrayOfNumbers[min])
                {
                    min = j;
                }
                SwapTwoElementsInArray(arrayOfNumbers, i, min);
            }
        }

        string sortedNums = string.Join(" ", arrayOfNumbers);
        Console.WriteLine("Sorted order ---> {0}", sortedNums);
    }

    static void SwapTwoElementsInArray(int[] arr, int i, int j)
    {
        int exchangeValue = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
