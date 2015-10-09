using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class QueryMess
{
    static void Main()
    {
        string line = Console.ReadLine();

        while (line != "END")
        {
            var dict = new Dictionary<string, List<string>>();

            line = Regex.Replace(line, @"\+", " ");
            line = Regex.Replace(line, @"%20", " ");
            line = Regex.Replace(line, @"\s+", " ");

            Regex regex = new Regex(@"([^&?\r\n]*)=([^&?\r\n]*)");
            MatchCollection matches = regex.Matches(line);

            foreach (Match match in matches)
            {
                string key = match.Groups[1].ToString().Trim();
                string value = match.Groups[2].ToString().Trim();

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<string>());
                }
                dict[key].Add(value);

            }

            foreach (var pair in dict)
            {
                Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
            }
            Console.WriteLine();

            line = Console.ReadLine();
        }
    }
}