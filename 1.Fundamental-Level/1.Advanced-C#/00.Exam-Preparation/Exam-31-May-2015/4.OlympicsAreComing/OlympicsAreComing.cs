namespace _4.OlympicsAreComing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class OlympicsAreComing
    {
        public static void Main()
        {
            var data = new Dictionary<string, List<string>>();

            string line = Console.ReadLine();
            while (line != "report")
            {
                line = Regex.Replace(line, "\\s+", " ");
                string[] lineParams = line.Split('|');

                string player = lineParams[0].Trim();
                string country = lineParams[1].Trim();

                if (!data.ContainsKey(country))
                {
                    data[country] = new List<string>();
                }

                data[country].Add(player);

                line = Console.ReadLine();
            }

            var sortedData = data.OrderByDescending(x => x.Value.Count);
            foreach (var pair in sortedData)
            {
                Console.WriteLine(
                    "{0} ({1} participants): {2} wins",
                    pair.Key,
                    pair.Value.Distinct().Count(),
                    pair.Value.Count);
            }
        }
    }
}