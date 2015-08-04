using System;
using System.Linq;
using System.Collections.Generic;
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

        int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> tempList = new List<int>();
        int[] lonestSequence = new int[inputArr.Length];

        tempList.Add(inputArr[0]);

        int longestListCount = 0;
        bool isOnlyOneSequence = true;

        Console.WriteLine("The sequences are:");

        for (int i = 1; i < inputArr.Length; i++)
        {
            if (inputArr[i - 1] < inputArr[i])
            {
                tempList.Add(inputArr[i]);
            }
            else
            {
                Console.WriteLine(string.Join(" ", tempList.ToArray()));

                if (longestListCount < tempList.Count)
                {
                    lonestSequence = tempList.ToArray();
                    longestListCount = tempList.Count;
                }

                tempList.Clear();
                tempList.Add(inputArr[i]);
                isOnlyOneSequence = false;
            }

            if (i == inputArr.Length - 1)
            {
                Console.WriteLine(string.Join(" ", tempList.ToArray()));

                if (longestListCount < tempList.Count)
                {
                    lonestSequence = tempList.ToArray();
                    longestListCount = tempList.Count;
                }
            }

            if (isOnlyOneSequence)
            {
                lonestSequence = tempList.ToArray();
            }
        }

        Console.Write("Longest: ");
        Console.WriteLine(string.Join(" ", lonestSequence));
    }
}