using System;
/*
Write a program that converts a string to a sequence of C# Unicode character literals. Examples:
Input       	Output
Hi!	            \u0048\u0069\u0021

 */
class UnicodeCharacters
{
    static void Main()
    {
        Console.Title = "Problem 5.	Unicode Characters";

        Console.WriteLine("Enter a string.");
        string str = Console.ReadLine();

        foreach (var ch in str)
        {
            Console.Write("\\u{0:x4}", (int)ch);
        }
        Console.WriteLine();
    }
}