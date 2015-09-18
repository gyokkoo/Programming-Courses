using System;
using System.Collections.Generic;
/*
Write a program that takes as input two lists of integers and joins them. 
The result should hold all numbers from the first list, and all numbers from the second list, 
without repeating numbers, and arranged in increasing order. The input and output lists
are given as integers, separated by a space, each list at a separate line. Do not use LINQ!
Use only arrays and lists.  
 */
class JoinLists
{
    static void Main()
    {
        Console.Title = "Problem 2. Join Lists";

        SortedSet<int> joinedList = new SortedSet<int>();

        Console.WriteLine("Enter two lists of integers, seperated by a space.");

        List<int> firstList = new List<int>();
        string[] firstInputLineArr = Console.ReadLine().Split(' ');
        for (int i = 0; i < firstInputLineArr.Length; i++)
        {
            firstList.Add(int.Parse((firstInputLineArr[i])));

            int currentNumber = firstList[i];

            if (!joinedList.Contains(currentNumber))
            {
                joinedList.Add(currentNumber);
            }
        }

        List<int> secondList = new List<int>();
        string[] secondInputLineArr = Console.ReadLine().Split(' ');
        for (int i = 0; i < secondInputLineArr.Length; i++)
        {
            secondList.Add(int.Parse((secondInputLineArr[i])));

            int currentNumber = secondList[i];

            if (!joinedList.Contains(currentNumber))
            {
                joinedList.Add(currentNumber);
            }
        }

        Console.WriteLine("The joined list:");
        foreach (int number in joinedList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}