using System;
using System.Linq;
using System.Collections.Generic;
/*
Write a program that reads some text from the console and counts the occurrences of each character in it. 
Print the results in alphabetical (lexicographical) order. Examples:
 */
class CountSymbols
{
    static void Main()
    {
        Console.Title = "Problem 6.	Count Symbols";
        Console.WriteLine("Enter some text.");

        char[] text = Console.ReadLine().ToCharArray();

        var symbolsDictionary = new SortedDictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if(!symbolsDictionary.ContainsKey(text[i]))
            {
                symbolsDictionary.Add(text[i], text.Count(x => x == text[i]));
            }
        }

        foreach (var symbol in symbolsDictionary)
        {
            Console.WriteLine("{0}: {1} time/s", symbol.Key, symbol.Value);
        }
    }
}