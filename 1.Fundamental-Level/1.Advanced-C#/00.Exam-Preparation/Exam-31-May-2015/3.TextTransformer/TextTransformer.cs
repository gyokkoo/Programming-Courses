namespace _3.TextTransformer
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class TextTransformer
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            StringBuilder textBuilder = new StringBuilder();
            while (line != "burp")
            {
                textBuilder.Append(line);
                line = Console.ReadLine();
            }

            string text = Regex.Replace(textBuilder.ToString(), @"\s+", " ");

            MatchCollection matches = Regex.Matches(text, @"([$%&'])([^$%&']+)\1");
            foreach (Match match in matches)
            {
                char specialSymbol = match.Value[0];
                string realText = match.Groups[2].Value;

                StringBuilder result = new StringBuilder();
                for (int i = 0; i < realText.Length; i++)
                {
                    char letter = realText[i];
                    if (i % 2 == 0)
                    {
                        result.Append((char)(letter + (specialSymbol - 35)));
                    }
                    else
                    {
                        result.Append((char)(letter - (specialSymbol - 35)));
                    }
                }

                Console.Write(result + " ");
            }
        }
    }
}
