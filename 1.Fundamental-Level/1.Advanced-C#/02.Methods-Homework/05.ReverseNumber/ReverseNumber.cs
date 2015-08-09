using System;
using System.Linq;
/*
Write a method that reverses the digits of a given floating-point number.
 */
class ReverseNumber
{
    static void Main()
    {
        Console.Title = "Problem 5.	Reverse Number";
        Console.WriteLine("Enter floating-point number.");

        double number = double.Parse(Console.ReadLine());

        double reversed = GetReversedNumber(number);
        Console.WriteLine(reversed);
    }

    static double GetReversedNumber(double number)
    {
        char[] numberAsCharArr = number.ToString().TrimStart('-').ToCharArray();

        Array.Reverse(numberAsCharArr);
        string reversedNumberAsString = new string(numberAsCharArr);

        double reversedNumber = double.Parse(reversedNumberAsString);

        if (number < 0)
        {
            reversedNumber = -reversedNumber;
        }

        return reversedNumber;
    }
}