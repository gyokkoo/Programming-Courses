using System;
using System.Linq;

/*
Write a method that reverses the digits of a given floating-point number.
Input	    Output
256         652
123.45      54.321
0.12	    21
 */
class ReverseNumber
{
    static void Main()
    {
        Console.Title = "Problem 5.	Reverse Number";

        Console.WriteLine("Enter floating-point number.");
        double number = double.Parse(Console.ReadLine());

        double reversed = GetReversedNumber(number);

        Console.WriteLine("The reversed number is: {0}", reversed);
    }

    static double GetReversedNumber(double number)
    {
        string numberAsString = number.ToString().TrimStart('-');
        string reversedNumberAsString = new string(numberAsString.Reverse().ToArray());

        double reversedNumber = double.Parse(reversedNumberAsString);

        if (number < 0)
        {
            reversedNumber = -reversedNumber;
        }

        return reversedNumber;
    }
}