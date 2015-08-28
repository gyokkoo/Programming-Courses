using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        Console.Title = "Problem 3.	Extract Emails";

        string text = Console.ReadLine();
        Regex pattern = new Regex(@"[\w-.]*@\w[-.\w]*\.\w+");
        MatchCollection matches = pattern.Matches(text);

        pattern = new Regex("^[a-zA-Z]");

        foreach (Match m in matches)
        {   
            var result = pattern.Match(m.Groups[0].Value);
            if(result.Success)
            {
                Console.WriteLine(m.Groups[0].Value);
            }
        }
    }
}
