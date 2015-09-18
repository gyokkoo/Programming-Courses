using System;
using System.Linq;
/*
Write a program to sort an array of integer numbers and then print them back on the console. 
The numbers should be entered from the console on a single line, separated by a space. 
Print the sorted array in the following format: “[element1, element2… elementN]”.

Condition: Do not use the built-in sorting method, you should write the logic yourself. 
Use the bubble sort algorithm. 

Input:        
6 5 4 10 -3 120 4
Output:
[-3, 4, 4, 5, 6, 10, 120]
*/
class BubbleSort
{
    static void Main()
    {
        Console.Title = "Problem 1. Sort Array of Numbers Using Bubble Sort";

        Console.WriteLine("Enter numbers on a singe line, separated by a space.");

        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
        {
            BubbleSortStep(arrayOfNumbers);
        }

        Console.WriteLine("The numbers in sorted order:");
        Console.WriteLine("[" + string.Join(", ", arrayOfNumbers) + "]");
    }

    static void BubbleSortStep(int[] arrayOfNumbers)
    {
        for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
        {
            int j = i + 1;
            if (arrayOfNumbers[i] > arrayOfNumbers[j])
            {
                SwapElementsInArray(i, j, arrayOfNumbers);
            }
        }
    }

    static void SwapElementsInArray(int i, int j, int[] arrayOfNumbers)
    {
        int exchangeValue = arrayOfNumbers[i];
        arrayOfNumbers[i] = arrayOfNumbers[j];
        arrayOfNumbers[j] = exchangeValue;
    }
}