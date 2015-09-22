using System;
/*
Write a program that takes an input in the form of a string and transforms each of its characters 
at even position to its uppercase representation. 
Note that the string indexation is zero-based (of course, we are programmers) 
and the number zero is even.
Input:
Byrzo che sireneto izbega!
Output:
ByRzO ChE SiReNeTo iZbEgA!
*/
class UppercaseChars
{
    static void Main()
    {
        Console.Title = "Problem 2.	Uppercase Chars at Even Positions";

        string str = Console.ReadLine();

        Console.WriteLine(UppercaseCharsAtEvenPosition(str));
    }

    static string UppercaseCharsAtEvenPosition(string str)
    {
        char[] arrayOfChars = str.ToCharArray();

        for (int i = 0; i < arrayOfChars.Length; i++)
        {
            if (i % 2 == 0)
            {
                arrayOfChars[i] = char.ToUpper(arrayOfChars[i]);
            }
        }

        string uppercasedStr = new string(arrayOfChars);

        return uppercasedStr;
    }
}