namespace _03.ExtractHyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ExtractHyperlinks
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            StringBuilder htmlText = new StringBuilder();
            while (line != "END")
            {
                htmlText.AppendLine(line);
                line = Console.ReadLine();
            }

            Regex regex = new Regex(@"<a[^<>]*href\s*=\s*[""](.*?)[""]|<a[^<>]*href\s*=\s*['](.*?)[']|<a[^<>]*href\s*=\s*([^<>\s]*)");
            MatchCollection matches = regex.Matches(htmlText.ToString());
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
}
