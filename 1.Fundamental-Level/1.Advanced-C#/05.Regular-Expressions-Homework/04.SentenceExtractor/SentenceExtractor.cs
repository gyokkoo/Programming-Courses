using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        Console.Title = "Problem 4.	Sentence Extractor";

        string keyword = Console.ReadLine();
        string text = Console.ReadLine();

        Regex regex = new Regex(@"\s*[A-Za-z,;'\""\s’–-]+[.?!]");
        MatchCollection matches = regex.Matches(text);
        regex = new Regex(string.Format((@"\b{0}\b"), keyword));

        foreach (Match m in matches)
	    {
            var result = regex.Match(m.Groups[0].Value);
            if(result.Success)
            {
                Console.WriteLine(m.Groups[0].Value);
            }
	    }
    }
}