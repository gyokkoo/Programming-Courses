using System;
using System.Linq;
/*
Write a program to read an array of numbers from the console, sort them and print them back on the console. 
The numbers should be entered from the console on a single line, separated by a space. 
Examples:
Input               	Output
6 5 4 10 -3 120 4   	-3 4 4 5 6 10 120
 */
class SortArrayOfNumbers
{
    static void Main()
    {
        Console.Title = "Problem 1.	Sort Array of Numbers";
        Console.WriteLine("Enter numbers on a single line, separated by a space.");

        Console.Write("Enter order  ---> ");
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(arrayOfNumbers);

        string sortedArr = string.Join(" ", arrayOfNumbers);
        Console.WriteLine("Sorted order ---> {0}", sortedArr);
    }
}
