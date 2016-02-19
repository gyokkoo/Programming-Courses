namespace _02.MatchPhoneNumber
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            const string Pattern = @"\+359\s2\s\d{3}\s\d{4}|\+359-2-\d{3}-\d{4}\b";

            List<string> phoneNumbers = new List<string>
                                            {
                                                "+359 2 222 2222",
                                                "+359-2-222-2222",
                                                "359-2-222-2222",
                                                "+359/2/222/2222",
                                                "+359-2 222 2222",
                                                "+359 2-222-2222",
                                                "+359-2-222-222",
                                                "+359-2-222-22222"
                                            };

            Regex regex = new Regex(Pattern);

            foreach (var number in phoneNumbers)
            {
                Console.Write("Is \"{0}\" a valid phone number ? -> ", number);
                Console.WriteLine(regex.IsMatch(number));
            }
        }
    }
}