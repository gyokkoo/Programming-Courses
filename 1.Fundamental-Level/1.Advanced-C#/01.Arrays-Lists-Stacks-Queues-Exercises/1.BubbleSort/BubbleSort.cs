using System;
using System.Linq;
/*
Write a program to sort an array of integer numbers and then print them back on the console. 
The numbers should be entered from the console on a single line, separated by a space. 
Print the sorted array in the following format: “[element1, element2… elementN]”.
*/
class BubbleSort
{
    static void Main()
    {
        Console.Title = "Problem 1. Sort Array of Numbers Using Bubble Sort";

        Console.WriteLine("Enter numbers on a singe line, separated by a space.");
        Console.Write("Enter order  ---> ");

        int[] arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < arrNumbers.Length; i++)
        {
            BubbleSortStep(arrNumbers);
        }

        Console.Write("Sorted order ---> ");
        Console.WriteLine(string.Join(" ", arrNumbers));       
    }

    static int[] BubbleSortStep(int[] arrNumbers)
    {
        int temp = arrNumbers[0];
        for (int i = 1; i <= arrNumbers.Length - 1; i++)
        {
            if (arrNumbers[i - 1] > arrNumbers[i])
            {
                temp = arrNumbers[i - 1];
                arrNumbers[i - 1] = arrNumbers[i];
                arrNumbers[i] = temp;
            }
        }
        return arrNumbers;
    }
}