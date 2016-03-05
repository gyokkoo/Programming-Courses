namespace _03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        private const string WordsFilePath = "../../words.txt";
        private const string TextFilePath = "../../text.txt";
        private const string ResultFilePath = "../../result.txt";

        private static readonly char[] SplitChars = { ' ', '!', '?', '.', ',', ':', '-', '_' };

        public static void Main()
        {
            var wordsCount = new Dictionary<string, int>();
            using (var reader = new StreamReader(WordsFilePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string word = line.ToLower();
                    wordsCount.Add(word, 0);
                    line = reader.ReadLine();
                }
            }

            using (var reader = new StreamReader(TextFilePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] lineWords = line.ToLower().Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in lineWords)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word]++;
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            var sortedWordsCount = wordsCount.OrderByDescending(x => x.Value);

            using (var writer = new StreamWriter(ResultFilePath))
            {
                foreach (var wordInfo in sortedWordsCount)
                {
                    Console.WriteLine("{0} - {1}", wordInfo.Key, wordInfo.Value);
                    writer.WriteLine("{0} - {1}", wordInfo.Key, wordInfo.Value);
                }
            }
        }
    }
}
