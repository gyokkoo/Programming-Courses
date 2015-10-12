using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class FourthProblem
{
    static void Main()
    {
        string line = Console.ReadLine();
        var dict = new Dictionary<string, Dictionary<string, long>>();
        while (line != "End")
        {
            try
            {
                line = line.Trim();
                string pattern = @"(.+) @(.+) (\d+) (\d+)";
                MatchCollection matches = Regex.Matches(line, pattern);
                foreach (Match match in matches)
                {
                    string venue = match.Groups[2].ToString().Trim();
                    string singer = match.Groups[1].ToString().Trim();
                    long ticketsPrice = long.Parse(match.Groups[3].ToString());
                    long ticketsCount = long.Parse(match.Groups[4].ToString());

                    if (!dict.ContainsKey(venue))
                    {
                        dict.Add(venue, new Dictionary<string, long>());

                        if (!dict[venue].ContainsKey(singer))
                        {
                            long income = ticketsCount * ticketsPrice;
                            dict[venue].Add(singer, income);
                        }
                        else
                        {
                            long income = ticketsCount * ticketsPrice;
                            dict[venue][singer] += income;
                        }
                    }
                    else
                    {
                        if (!dict[venue].ContainsKey(singer))
                        {
                            long income = ticketsCount * ticketsPrice;
                            dict[venue].Add(singer, income);
                        }
                        else
                        {
                            long income = ticketsCount * ticketsPrice;
                            dict[venue][singer] += income;
                        }
                    }
                }
                line = Console.ReadLine();
            }
            catch (Exception)
            {
                line = Console.ReadLine();
            }

        }
        foreach (var pair1 in dict)
        {
            var sortedDict = pair1.Value.OrderByDescending(x => x.Value);
            Console.WriteLine(pair1.Key);
            foreach (var pair2 in sortedDict)
            {
                Console.WriteLine("#  {0} -> {1}", pair2.Key, pair2.Value);
            }
        }
    }
}
