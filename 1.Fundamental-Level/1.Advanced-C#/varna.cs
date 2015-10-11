using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ThirdProblem
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        List<string> doubleList = new List<string>();
        List<string> intList = new List<string>();

        StringBuilder text = new StringBuilder();
        while (inputLine != "//END_OF_CODE")
        {
            text.Append(inputLine);
            inputLine = Console.ReadLine();
        }

        string intPattern = @"int\s([\w+]*)";

        MatchCollection intMatches = Regex.Matches(text.ToString(), intPattern);
        foreach (Match match in intMatches)
        {
            intList.Add(match.Groups[1].ToString());
        }


        string doublePattern = @"double\s([\w+]*)";

        MatchCollection doubleMatches = Regex.Matches(text.ToString(), doublePattern);
        foreach (Match match in doubleMatches)
        {
            doubleList.Add(match.Groups[1].ToString());
        }

        if (doubleList.Count >= 1)
        {
            doubleList.Sort();
            Console.WriteLine("Doubles: {0}", string.Join(", ", doubleList));
        }
        else
        {
            Console.WriteLine("Doubles: None");
        }

        if (intList.Count >= 1)
        {
            intList.Sort();
            Console.WriteLine("Ints: {0}", string.Join(", ", intList));
        }
        else
        {
            Console.WriteLine("Ints: None");
        }
    }
}
