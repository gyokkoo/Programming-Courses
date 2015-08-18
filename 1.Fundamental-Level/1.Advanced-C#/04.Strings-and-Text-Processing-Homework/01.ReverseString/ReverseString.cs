using System;
using System.Text;
/*
Write a program that reads a string from the console, reverses it and prints the result back at the console.
 */
class ReverseString
{
    static void Main()
    {
        Console.Title = "Problem 1.	Reverse String";
        Console.WriteLine("Enter a string.");

        string str = Console.ReadLine();

        Console.WriteLine(StringReverse(str));
    }

    static string StringReverse(string str)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }

        return sb.ToString();
    }
}