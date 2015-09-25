using System;
/*
Write a program that takes a text and a string of banned words. 
All words included in the ban list should be replaced with asterisks "*", equal to the word's length. 
The entries in the ban list will be separated by a comma and space ", ".
 */
class TextFilter
{
    static void Main()
    {
        char[] emptyEntries = { ' ', ',' };
        string[] bannedWords = Console.ReadLine().Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries);

        string text = Console.ReadLine();

        for (int i = 0; i < bannedWords.Length; i++)
        {
            text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
        }

        Console.WriteLine("Output: \n" + text);
    }
}