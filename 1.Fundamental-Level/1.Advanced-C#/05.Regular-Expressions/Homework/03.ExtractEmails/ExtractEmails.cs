namespace _03.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"\b[a-zA-Z0-9]+[\.\-_\w]+[a-zA-Z0-9]+@[a-zA-Z]+[a-zA-Z\-\.]*\.{1,}[a-zA-Z\-\.]+\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
