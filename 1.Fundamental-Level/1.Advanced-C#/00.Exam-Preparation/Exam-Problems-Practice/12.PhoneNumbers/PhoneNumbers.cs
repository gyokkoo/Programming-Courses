namespace _12.PhoneNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class PhoneNumbers
    {
        public static void Main()
        {
            var phoneNumbers = new Dictionary<string, string>();
            StringBuilder textBuilder = new StringBuilder();
            string line = Console.ReadLine();
            while (line != "END")
            {
                textBuilder.Append(line);
                line = Console.ReadLine();
            }

            Regex regex = new Regex(@"([A-Z]+[a-zA-Z]*)[^\+a-zA-Z]*?([\+]*[0-9][\(\)\/\.\-\s\d]*[0-9])");
            MatchCollection matches = regex.Matches(textBuilder.ToString());
            foreach (Match match in matches)
            {
                string name = match.Groups[1].Value;
                string number = match.Groups[2].Value;
                number = Regex.Replace(number, @"[\(\)\/\.\-\s]+", string.Empty);

                phoneNumbers.Add(name, number);
            }

            string result = GetResult(phoneNumbers);
            Console.WriteLine(result);
        }

        private static string GetResult(Dictionary<string, string> phoneNumbers)
        {
            var result = new StringBuilder();
            if (phoneNumbers.Any())
            {
                result.Append("<ol>");
                foreach (var phoneNumber in phoneNumbers)
                {
                    result.AppendFormat("<li><b>{0}:</b> {1}</li>", phoneNumber.Key, phoneNumber.Value);
                }

                result.Append("</ol>");
            }
            else
            {
                result.Append("<p>No matches!</p>");
            }

            return result.ToString();
        }
    }
}