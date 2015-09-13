using System;
using System.Linq;
/*
Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers. 
Find those K consecutive elements in the array, which have maximal sum. 
 */
class ConsecutiveMaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter two integers numbers N and K (K<N) and array of N integers.");

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter array with N elements, seperated by a space.");
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int currSum = 0;
        int bestSum = 0;

        for (int i = 0; i < n - k + 1; i++)
        {
            for (int j = i; j < k; j++)
            {
                currSum += nums[j];
                if (bestSum < currSum)
                {
                    bestSum = currSum;
                }
            }
            currSum = 0;
        }

        Console.WriteLine("The best K consecutive sum of array with N elements is: {0}", bestSum);
    }
}