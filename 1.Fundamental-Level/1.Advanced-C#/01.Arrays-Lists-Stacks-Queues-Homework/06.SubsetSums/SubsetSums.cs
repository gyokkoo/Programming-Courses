using System;
using System.Linq;
using System.Collections.Generic;
/*
Write a program that reads from the console a number N and an array of integers given on a single line. 
Your task is to find all subsets within the array which have a sum equal to N and print them on the console (the order of printing is not important). 
Find only the unique subsets by filtering out repeating numbers first. 
In case there aren't any subsets with the desired sum, print "No matching subsets." 
Examples: 
Input                   Output
-2
-5 4 92 0 928 1 -1 4	-5 + 4 + -1 = -2
                        -5 + 4 + 0 + -1 = -2
 */
class SubsetSums
{
    static void Main()
    {
        Console.Title = "Problem 6.	Subset Sums";
        Console.WriteLine("Enter a number N and an array of integers, on a single line.");

        Console.Write("N = ");
        int targetSum = int.Parse(Console.ReadLine());

        Console.WriteLine("Ener an array of integers:");
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool isFound = false;

        Console.WriteLine("The unique subsets with sum {0} are:", targetSum);

        int numOfSubsets = 1 << arrayOfNumbers.Length;
        for (int i = 0; i < numOfSubsets; i++)
        {
            List<int> subset = new List<int>();
            int index = arrayOfNumbers.Length - 1;
            int bitMask = i;

            while (bitMask > 0)
            {
                if ((bitMask & 1) == 1)
                {
                    subset.Add(arrayOfNumbers[index]);
                }

                bitMask = bitMask >> 1;
                index--;
            }

            if ((subset.Sum() == targetSum) && (subset.Count != 0))
            {
                isFound = true;
                Console.WriteLine("{0} = {1}", string.Join(" + ", subset), targetSum);
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}