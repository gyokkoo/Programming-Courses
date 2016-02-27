namespace _05.SemanticHtml
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SemanticHtml
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            string[] semanticTags = { "main", "header", "nav", "article", "section", "aside", "footer" };

            while (line != "END")
            {
                Regex openTag = new Regex(@"<(div).*((id|class)\s*=\s*""(.*?)"").*>");
                Regex closeTag = new Regex(@"<\/(div)>.*(<!--\s*(\w+)\s*-->)");

                if (openTag.IsMatch(line))
                {
                    Match match = openTag.Match(line);
                    string nonSemantic = match.Value;
                    string semantic = match.Value;
                    string tag = match.Groups[4].Value;

                    if (semanticTags.Contains(tag))
                    {
                        semantic = semantic.Replace(match.Groups[1].Value, tag);
                        semantic = semantic.Replace(match.Groups[2].Value, string.Empty);
                        semantic = Regex.Replace(semantic, "\\s*>", ">");
                        semantic = Regex.Replace(semantic, "\\s+", " ");
                        line = line.Replace(nonSemantic, semantic);
                    }
                }
                else if (closeTag.IsMatch(line))
                {
                    Match match = closeTag.Match(line);
                    string nonSemantic = match.Value;
                    string semantic = match.Value;

                    semantic = semantic.Replace(match.Groups[1].Value, match.Groups[3].Value);
                    semantic = semantic.Replace(match.Groups[2].Value, string.Empty);
                    semantic = Regex.Replace(semantic, "\\s+", " ").Trim();
                    line = line.Replace(nonSemantic, semantic);
                }

                Console.WriteLine(line);
                line = Console.ReadLine();
            }
        }
    }
}