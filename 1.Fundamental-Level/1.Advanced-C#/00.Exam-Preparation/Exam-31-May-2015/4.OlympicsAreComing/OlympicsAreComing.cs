using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class OlympicsAreComing
{
    static void Main()
    {
        var data = new Dictionary<string, List<string>>();

        string line = Console.ReadLine();

        while (line != "report")
        {
            string[] names = line.Split('|');
            string athlete = names[0];
            string country = names[1];

            athlete = Regex.Replace(athlete, @"\s{2,}", " ").Trim();
            country = Regex.Replace(country, @"\s{2,}", " ").Trim();

            if (!data.ContainsKey(country))
            {
                data.Add(country, new List<string>());
            }
            data[country].Add(athlete);
            line = Console.ReadLine();
        }

        var orderedData = data.OrderByDescending(x => x.Value.Count);

        foreach (var keyValuePair in orderedData)
        {
            Console.WriteLine("{0} ({1} participants): {2} wins",
                          keyValuePair.Key,
                          keyValuePair.Value.Distinct().Count(),
                          keyValuePair.Value.Count);
        }
    }
}
