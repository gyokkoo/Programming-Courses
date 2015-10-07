using System;
using System.Text;
using System.Text.RegularExpressions;

class TextTransformer
{
    static void Main()
    {
        string line = Console.ReadLine();

        StringBuilder gibberishSb = new StringBuilder();

        while (line != "burp")
        {
            gibberishSb.Append(line);
            line = Console.ReadLine();
        }

        string text = Regex.Replace(gibberishSb.ToString(), "\\s+", " ");
        Regex pattern = new Regex(@"([$%&'])([^$%&']+)\1");
        MatchCollection matches = pattern.Matches(text);

        foreach (Match match in matches)
        {
            string output = match.Groups[2].Value;
            int weight = GetWeightFromSymbol(match.Groups[1].Value);
            StringBuilder currentWord = new StringBuilder();

            for (int i = 0; i < output.Length; i++)
            {
                char resultSymbol;
                if (i % 2 == 0)
                {
                    resultSymbol = (char)(output[i] + weight);
                }
                else
                {
                    resultSymbol = (char)(output[i] - weight);
                }
                currentWord.Append(resultSymbol);
            }
            Console.Write(currentWord + " ");
        }
    }

    static int GetWeightFromSymbol(string specialSymbol)
    {
        switch (specialSymbol)
        {
            case "$":
                return 1;
            case "%":
                return 2;
            case "&":
                return 3;
            case "'":
                return 4;
            default:
                return 0;
        }
    }
}