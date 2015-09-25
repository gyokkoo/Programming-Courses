using System;
using System.Text;
/*
Write a program that reads a string from the console, reverses it and prints the result back at the console.
 */

class ReverseString
{
    static void Main()
    {
        Console.Title = "Problem 1.	Reverse String";

        Console.WriteLine("Enter a string.");
        string inputString = Console.ReadLine();

        string reversedString = StringReverse(inputString);

        Console.WriteLine(reversedString);
    }

    static string StringReverse(string inputString)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            sb.Append(inputString[i]);
        }

        string reversedString = sb.ToString();

        return reversedString;
    }
}