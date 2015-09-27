using System;
using System.Text.RegularExpressions;
/*
Write a program that reads a keyword and some text from the console and prints all sentences from the text, containing that word. A sentence is any sequence of words ending with '.', '!' or '?'. 
Examples:
Input	
is
This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)	
Output 
This is my cat!
And this is my dog.
 */
class SentenceExtractor
{
    static void Main()
    {
        Console.Title = "Problem 4.	Sentence Extractor";

        string keyword = Console.ReadLine();
        string text = Console.ReadLine();

        string pattern = string.Format(@"(\b.*?\b{0}\b.*?[.?!])", keyword);

        MatchCollection sentences = Regex.Matches(text, pattern);

        foreach (Match item in sentences)
        {
            Console.WriteLine(item);
        }
    }
}