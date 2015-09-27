using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        Console.Title = "Problem 3.	Extract Emails";

        string text = Console.ReadLine();

        string pattern = @"\b[\w_.]+@[._\w]+\.\w+\b";

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}
