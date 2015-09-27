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

        for (int i = 0; i < text.Length; i++)
        {
            string pattern = string.Format(@"{0}+", text[i]);
            string replacement = text[i].ToString();

            Regex regex = new Regex(pattern);

            text = regex.Replace(text, replacement);
        }

        Console.WriteLine(text);
    }
}