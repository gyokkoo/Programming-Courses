using System;
using System.Text.RegularExpressions;
/*
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Input	                    Output
aaaaabbbbbcdddeeeedssaa 	abcdedsa
 */
class SeriesOfLetters
{
    static void Main()
    {
        Console.Title = "Problem 1.	Series of Letters";

        string text = Console.ReadLine();
        Regex regex = new Regex(@"(.)\1+");

        Console.WriteLine(regex.Replace(text, "$1"));
    }
}