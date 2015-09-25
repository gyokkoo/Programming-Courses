using System;
using System.Collections.Generic;
/*
Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and 
prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots,
question marks and exclamation marks as word delimiters. 
Print only unique palindromes, sorted lexicographically.
Example:
Input	                                    Output
Hi,exe? ABBA! Hog fully a string. Bob   	a, ABBA, exe
 */
class Palindromes
{
    static void Main()
    {
        Console.Title = "Problem 6.	Palindromes";

        char[] empyEntries = { ' ', ',', '.', '?', '!' };
        string[] words = Console.ReadLine().Split(empyEntries, StringSplitOptions.RemoveEmptyEntries);

        SortedSet<string> palyndromes = new SortedSet<string>();

        for (int i = 0; i < words.Length; i++)
        {
            if (isPalyndrome(words[i]))
            {
                palyndromes.Add(words[i]);
            }
        }

        Console.WriteLine(string.Join(", ", palyndromes));
    }

    static bool isPalyndrome(string word)
    {
        if (word.Length == 1)
        {
            return true;
        }

        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}