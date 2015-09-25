using System;
/*
Write a program to find how many times a given string appears in a given text as substring. 
The text is given at the first input line. The search string is given at the second input line. 
The output is an integer number. Please ignore the character casing. 
Overlapping between occurrences is allowed. Examples:
Input	                                                                            
Welcome to the Software University (SoftUni)! Welcome to programming. Programming is wellness for developers, said Maxwell.
wel	
Output
4
 */
class CountSubstringOccurrences
{
    static void Main()
    {
        Console.Title = "Problem 3.	Count Substring Occurrences";

        string text = Console.ReadLine().ToLower();
        string searchString = Console.ReadLine().ToLower();

        int countOccurrences = 0;

        for (int i = 0; i <= text.Length - searchString.Length; i++)
        {
            if (searchString == text.Substring(i, searchString.Length))
            {
                countOccurrences++;
            }
        }

        Console.WriteLine(countOccurrences);
    }
}