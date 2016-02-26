namespace _3.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToUpper();

            MatchCollection matches = Regex.Matches(text, @"(\D+)(\d+)");
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                string symbols = match.Groups[1].ToString();
                int number = int.Parse(match.Groups[2].ToString());
                for (int i = 0; i < number; i++)
                {
                    result.Append(symbols);
                }
            }

            int uniqueSymbolCount = result.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}", uniqueSymbolCount);
            Console.WriteLine(result.ToString());
        }
    }
}
