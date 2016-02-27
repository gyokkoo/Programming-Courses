namespace _13.SumOfAllValues
{
    using System;
    using System.Text.RegularExpressions;

    public class SumOfAllValues
    {
        public static void Main()
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();
            double valuesSum = 0;

            Match keyMatch = Regex.Match(keyString, @"^([a-zA-Z_]+)\d.*\d([a-zA-Z_]+)$");
            if (keyMatch.Success)
            {
                string startKey = keyMatch.Groups[1].Value;
                string endKey = keyMatch.Groups[2].Value;

                string pattern = $"{startKey}(.*?){endKey}";
                MatchCollection valueMatches = Regex.Matches(textString, pattern);
                foreach (Match match in valueMatches)
                {
                    double value;
                    if (double.TryParse(match.Groups[1].Value, out value))
                    {
                        valuesSum += value;
                    }
                }
            }
            else if (!keyMatch.Success)
            {
                Console.WriteLine("<p>A key is missing</p>");
                return;
            }

            valuesSum = valuesSum % 1 == 0 ? (int)valuesSum : Math.Round(valuesSum, 2);
            if (valuesSum != 0)
            {
                Console.WriteLine($"<p>The total value is: <em>{valuesSum}</em></p>");
            }
            else
            {
                Console.WriteLine("<p>The total value is: <em>nothing</em></p>");
            }
        }
    }
}