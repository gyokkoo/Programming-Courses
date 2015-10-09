using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractHyperlinks
{
    static void Main()
    {
        string line = Console.ReadLine();

        StringBuilder textBuilder = new StringBuilder();

        while (line != "END")
        {
            textBuilder.Append(line);
            line = Console.ReadLine();
        }

        string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>";
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(textBuilder.ToString());

        foreach (Match match in matches)
        {
            for (int i = 1; i <= 3; i++)
            {
                if (match.Groups[i].Length > 0)
                {
                    Console.WriteLine(match.Groups[i]);
                }
            }
        }
    }
}
