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
        Console.WriteLine("Enter two lists of integers, seperated by a space.");

        List<int> list = new List<int>();

        Console.Write("First list  ---> ");
        string firstInput = Console.ReadLine();
        string[] firstInputStrArr = firstInput.Split(' ');
        int[] firstNumsArr = new int[firstInputStrArr.Length];

        for (int i = 0; i < firstNumsArr.Length; i++)
        {
            firstNumsArr[i] = int.Parse(firstInputStrArr[i]);
            if (list.IndexOf(firstNumsArr[i]) == -1)
            {
                list.Add(firstNumsArr[i]);
            }
        }

        Console.Write("Second list ---> ");
        string secondInput = Console.ReadLine();
        string[] secondInputStrArr = secondInput.Split(' ');
        int[] secondNumsArr = new int[secondInputStrArr.Length];

        for (int i = 0; i < secondNumsArr.Length; i++)
        {
            secondNumsArr[i] = int.Parse(secondInputStrArr[i]);
            if (list.IndexOf(secondNumsArr[i]) == -1)
            {
                list.Add(secondNumsArr[i]);
            }
        }

        list.Sort();

        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}