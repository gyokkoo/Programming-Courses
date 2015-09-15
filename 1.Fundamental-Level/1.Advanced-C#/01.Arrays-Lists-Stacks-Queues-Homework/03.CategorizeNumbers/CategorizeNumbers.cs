using System;
using System.Collections.Generic;
using System.Linq;
/*
Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets, 
one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. 
Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). 
Examples:
Input	                            Output
1.2 -4 5.00 12211 93.003 4 2.2	    [1.2, 93.003, 2.2] -> min: 1.2, max: 93.003, sum: 96.403, avg: 32.13
                                    [-4, 5, 12211, 4] - > min: -4, max: 12211, sum: 12216, avg: 3054.00
 
 */
class CategorizeNumbers
{
    static void Main()
    {
        Console.Title = "Problem 3.	Categorize Numbers and Find Min / Max / Average";
        Console.WriteLine("Enter floating-point numbers, on a single line, seperated by a space.");

        double[] arrayOfNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        List<double> roundNumbers = new List<double>();
        List<double> floatingPointNumbers = new List<double>();

        for (int i = 0; i < arrayOfNums.Length; i++)
        {
            if (IsRoundNumber(arrayOfNums[i]))
            {
                roundNumbers.Add(arrayOfNums[i]);
            }
            else
            {
                floatingPointNumbers.Add(arrayOfNums[i]);
            }
        }

        string firstGroup = string.Join(", ", floatingPointNumbers);
        string secondGroup = string.Join(", ", roundNumbers);

        Console.WriteLine("The categorized numbers:");

        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", firstGroup, floatingPointNumbers.Min(),
            floatingPointNumbers.Max(), floatingPointNumbers.Sum(), floatingPointNumbers.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", secondGroup, roundNumbers.Min(),
            roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average());
    }

    static bool IsRoundNumber(double number)
    {
        bool isRoundNumber = false;
        if (number % 1 == 0)
        {
            isRoundNumber = true;
        }
        else if (number % 1 != 0)
        {
            isRoundNumber = false;
        }

        return isRoundNumber;
    }
}