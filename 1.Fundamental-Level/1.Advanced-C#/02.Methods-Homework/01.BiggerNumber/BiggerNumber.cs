using System;
/*
Write a method GetMax() with two parameters that returns the larger of two integers. 
Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().
 */
class BiggerNumber
{
    static void Main()
    {
        Console.Title = "Problem 1.	Bigger Number";
        Console.WriteLine("Enter two integers, each on a separate line.");

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int maxNumber = int.MinValue;

        if (firstNumber >= secondNumber)
        {
            maxNumber = firstNumber;
        }
        else
        {
            maxNumber = secondNumber;
        }

        return maxNumber;
    }
}