using System;
using System.Linq;
/*
This problem is from the Java Basics exam (8 February 2015). 
You may check your solution here.
https://judge.softuni.bg/Contests/Practice/Index/69#1
 */

class LettersChangeNumbers
{
    static void Main()
    {
        char[] emptyEntries = { ' ', '\t' };
        string[] strSequence = Console.ReadLine().Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries);

        double sum = 0;

        for (int i = 0; i < strSequence.Length; i++)
        {
            char firstLetter = strSequence[i].First();
            char secondLetter = strSequence[i].Last();
            double number = double.Parse(strSequence[i].Substring(1, strSequence[i].Length - 2));

            number = FirstLetterOperations(firstLetter, number);
            number = LastLetterOperations(secondLetter, number);

            sum += number;
        }

        Console.WriteLine("{0:F2}", sum);
    }

    static double LastLetterOperations(char secondLetter, double number)
    {
        if (char.IsUpper(secondLetter))
        {
            number -= secondLetter - 64;
        }
        else if (char.IsLower(secondLetter))
        {
            number += secondLetter - 96;
        }

        return number;
    }

    static double FirstLetterOperations(char firstLetter, double number)
    {
        if (char.IsUpper(firstLetter))
        {
            number /= firstLetter - 64;
        }
        else if (char.IsLower(firstLetter))
        {
            number *= firstLetter - 96;
        }

        return number;
    }
}