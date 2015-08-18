using System;
/*
Write a program that reads from the console a string of maximum 20 characters. 
If the length of the string is less than 20, the rest of the characters should be filled with *. 
Print the resulting string on the console.
Examples:
Input	                            Output
Welcome to SoftUni!	Welcome to      SoftUni!*    
 */
class StringLength
{
    static void Main()
    {
        Console.Title = "Problem 2.	String Length";

        Console.WriteLine("Enter a string.");
        string str = Console.ReadLine();

        string output = str;

        if (str.Length < 20)
        {
            output = str + new string('*', 20 - str.Length);
        }
        else if (str.Length > 20)
        {
            output = str.Substring(0, 20);
        }

        Console.WriteLine(output);
    }
}