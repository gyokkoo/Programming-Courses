using System;
using System.Linq;
/*
Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). 
The input strings are given as a single line, separated by a space. Examples:
Input                      Output
hi yes yes yes bye	       hi
                           yes yes yes
                           bye
 */
class SequencesEqualStrings
{
    static void Main()
    {
        Console.Title = "Problem 4.	Sequences of Equal Strings";
        Console.WriteLine("Enter an array of strings, in a single line, separated by a space.");

        string[] inputArr = Console.ReadLine().Split(' ').ToArray();

        Console.WriteLine("The sequences are:");

        for (int i = 0; i < inputArr.Length - 1; i++)
        {
            if (inputArr[i] != inputArr[i + 1])
            {
                Console.WriteLine(inputArr[i]);
            }
            else
            {
                Console.Write(inputArr[i] + " ");
            }
        }
        Console.WriteLine(inputArr[inputArr.Length - 1]);
    }
}
