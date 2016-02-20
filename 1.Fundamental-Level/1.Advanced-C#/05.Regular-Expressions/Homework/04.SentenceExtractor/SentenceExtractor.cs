namespace _04.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = $@"\b[^.?!]+\b{keyword}\b[^.?!]+[.?!]";

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}