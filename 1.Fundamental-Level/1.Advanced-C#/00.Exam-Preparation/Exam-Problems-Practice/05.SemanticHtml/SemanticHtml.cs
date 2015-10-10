using System;
using System.Linq;
using System.Text.RegularExpressions;

class SemanticHtml
{
    static void Main()
    {
        string line = Console.ReadLine();

        string[] semanticTags = { "main", "header", "nav", "article", "section", "aside", "footer" };
        string openTagPattern = @"<div.*?\b((id|class)\s*=\s*""(.*?)"").*?>";
        Regex users = new Regex(openTagPattern);
        string closeTagPattern = @"<\/div>\s.*?(\w+)\s*-->";
        Regex closers = new Regex(closeTagPattern);

        while (line != "END")
        {
            MatchCollection openMatches = users.Matches(line);
            foreach (Match match in openMatches)
            {
                string attrName = match.Groups[1].Value;
                string attrValue = match.Groups[3].Value;

                if (semanticTags.Contains(attrValue))
                {
                    string replaceTag = Regex.Replace(match.ToString(), "div", word => attrValue);
                    replaceTag = Regex.Replace(replaceTag, attrName, "");
                    replaceTag = Regex.Replace(replaceTag, "\\s*>", ">");
                    replaceTag = Regex.Replace(replaceTag, "\\s{2,}", " ");
                    line = Regex.Replace(line, match.ToString(), replaceTag);
                }
            }

            MatchCollection closeMatches = closers.Matches(line);
            foreach (Match match in closeMatches)
            {
                string commentValue = match.Groups[1].Value;
                if (semanticTags.Contains(commentValue))
                {
                    line = Regex.Replace(line, match.ToString(), string.Format("</" + commentValue + ">"));
                }
            }

            Console.WriteLine(line);
            line = Console.ReadLine();
        }
    }
}
