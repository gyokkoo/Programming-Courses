using System;
/*
Write a method that returns the last digit of a given integer as an English word. 
Test the method with different input values. Ensure you name the method properly. 
 */

class LastDigitOfNumber
{
    static void Main()
    {
        Console.Title = "Problem 2.	Last Digit of Number";
        Console.WriteLine("Enter an integer number.");

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(GetLastDigitAsWord(number));
    }

    static string GetLastDigitAsWord(int number)
    {
        string[] digitAsWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int index = number % 10;

        return digitAsWords[index];
    }
}