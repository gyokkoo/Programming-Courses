using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

/*
Write a program to find all increasing sequences inside an array of integers. 
The integers are given on a single line, separated by a space. 
Print the sequences in the order of their appearance in the input array, each at a single line. 
Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. 
If several sequences have the same longest length, print the left-most of them. Examples:
Input	                Output
2 3 4 1 50 2 3 4 5	    2 3 4
                        1 50
                        2 3 4 5
                        Longest: 2 3 4 5
 */
class LongestSequence
{
    static void Main()
    {
        Console.Title = "Problem 5.	Longest Increasing Sequence";
        Console.WriteLine("Enter an array of integers, in a single line, separated by a space.");

        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> sequenceList = new List<int>();
        int[] lonestSequence = new int[arrayOfNumbers.Length];

        sequenceList.Add(arrayOfNumbers[0]);

        int longestListCount = 0;
        bool isOnlyOneSequence = true;

        Console.WriteLine("The sequences are:");

        for (int i = 1; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i - 1] < arrayOfNumbers[i])
            {
                sequenceList.Add(arrayOfNumbers[i]);
            }
            else
            {
                Console.WriteLine(string.Join(" ", sequenceList.ToArray()));

                if (longestListCount < sequenceList.Count)
                {
                    lonestSequence = sequenceList.ToArray();
                    longestListCount = sequenceList.Count;
                }

                sequenceList.Clear();
                sequenceList.Add(arrayOfNumbers[i]);
                isOnlyOneSequence = false;
            }

            if (i == arrayOfNumbers.Length - 1)
            {
                Console.WriteLine(string.Join(" ", sequenceList.ToArray()));

                if (longestListCount < sequenceList.Count)
                {
                    lonestSequence = sequenceList.ToArray();
                    longestListCount = sequenceList.Count;
                }
            }

            if (isOnlyOneSequence)
            {
                lonestSequence = sequenceList.ToArray();
            }
        }

        Console.Write("Longest: ");
        Console.WriteLine(string.Join(" ", lonestSequence));
    }
}