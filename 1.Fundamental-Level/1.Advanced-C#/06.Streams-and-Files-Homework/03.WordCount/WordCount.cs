using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/*
Write a program that reads a list of words from the file words.txt and finds how many times each of the words 
is contained in another file text.txt. 
Matching should be case-insensitive.
Write the results in file results.txt. 
Sort the words by frequency in descending order. 
Use StreamReader in combination with StreamWriter.
 */
class WordCount
{
    static void Main()
    {
        Console.Title = "Problem 3.	Word Count";

        var wordsCountDictionary = new Dictionary<string, int>();
        StreamReader reader = new StreamReader("../../text.txt");
        char[] punctuationMarks = { ' ', ',', '.', '\r', '-', '\n', '?', '-' };
        string[] text = reader.ReadToEnd().Split(punctuationMarks, StringSplitOptions.RemoveEmptyEntries);
        reader.Close();

        StreamReader wordsReader = new StreamReader("../../words.txt");
        StreamWriter writer = new StreamWriter("../../result.txt");

        using (wordsReader)
        {
            string word = wordsReader.ReadLine();

            while (word != null)
            {
                wordsCountDictionary[word] = text.Count(x => x.ToLower() == word);
                word = wordsReader.ReadLine();
            }
        }

        using (writer)
        {
            foreach (var pair in wordsCountDictionary.OrderByDescending(x => x.Value))
            {
                writer.WriteLine("{0} - {1}", pair.Key, pair.Value);
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }
    }
}
