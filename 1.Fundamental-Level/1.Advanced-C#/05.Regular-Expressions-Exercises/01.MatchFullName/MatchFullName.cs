using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*
Write a regular expression to match a valid full name. A valid full name consists of two words, 
each word starts with a capital letter and contains only lowercase letters afterwards; 
each word should be at least two letters long; 
the two words should be separated by a single space. 
To help you out, we've outlined several steps:
•	Use an online regex tester like https://regex101.com/ 
•	Check out how to use character sets (denoted with square brackets - "[]")
•	Specify that you want two words with a space between them (the space character ' ', and not any whitespace symbol)
•	For each word, specify that it should begin with an uppercase letter using a character set. 
The desired characters are in a range – from 'A' to 'Z'.
•	For each word, specify that what follows the first letter are only lowercase letters, 
one or more – use another character set and the correct quantifier.
•	To prevent capturing of letters across new lines, put "\b" at the beginning and at the end of your regex. ]
This will ensure that what precedes and what follows the match is a word boundary (like a new line).
In order to check your regex, use these values for reference (paste all of them in the Test String field):

Match ALL of these      	Match NONE of these
Ivan Ivanov	                ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan	Ivanov
 */

class MatchFullName
{
    static void Main()
    {
        Console.Title = "Problem 1.	Match Full Name";

        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        List<string> names = new List<string>()
        {
            "Ivan Ivanov",
            "ivan ivanov",
            "Ivan ivanov",
            "ivan Ivanov",
            "IVan Ivanov",
            "Ivan IvAnov",
            "Ivan  Ivanov"
        };

        Regex regex = new Regex(pattern);

        foreach (var name in names)
        {
            Console.Write("Is \"{0}\" correct name ? -> ", name);
            Console.WriteLine(regex.IsMatch(name));
        }
    }
}