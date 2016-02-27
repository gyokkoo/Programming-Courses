namespace _04.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while (line != "END")
            {
                line = Regex.Replace(line, @"\+", " ");
                line = Regex.Replace(line, @"%20", " ");
                line = Regex.Replace(line, @"\s+", " ");

                var dictionary = new Dictionary<string, List<string>>();

                Regex regex = new Regex(@"([^=&?\r\n]*)\s*=\s*([^=&?\r\n]*)");
                MatchCollection matches = regex.Matches(line);

                foreach (Match match in matches)
                {
                    string key = match.Groups[1].ToString().Trim();
                    string value = match.Groups[2].ToString().Trim();

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new List<string>();
                    }

                    dictionary[key].Add(value);
                }

                foreach (var pair in dictionary)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }

                Console.WriteLine();
                line = Console.ReadLine();
            }
        }
    }
}