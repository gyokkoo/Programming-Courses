using System;
using System.Linq;
using System.Collections.Generic;
/*
Write a program that reads some text from the console and counts the occurrences of each character in it. 
Print the results in alphabetical (lexicographical) order.
Input:
SoftUni rocks
Output:
 : 1 time/s
S: 1 time/s
U: 1 time/s
c: 1 time/s
f: 1 time/s
i: 1 time/s
k: 1 time/s
n: 1 time/s
o: 2 time/s
r: 1 time/s
s: 1 time/s
t: 1 time/s
 */
class CountSymbols
{
    static void Main()
    {
        Console.Title = "Problem 6.	Count Symbols";
        Console.WriteLine("Enter some text.");

        string text = Console.ReadLine();

        SortedDictionary<char, int> characterCountDictionary = new SortedDictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            char character = text[i];

            if (!characterCountDictionary.ContainsKey(character))
            {
                characterCountDictionary.Add(character, text.Count(x => x == character));
            }
        }

        foreach (var character in characterCountDictionary)
        {
            Console.WriteLine("{0}: {1} time/s", character.Key, character.Value);
        }
    }
}