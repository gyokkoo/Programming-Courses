using System;
/*
Write a program that creates a letter. 
It takes as input the sender and the receiver and prints a formatted output on the console.

Input
Gosho
Pesho
Output:
Input
Dear Gosho,
I hope I find you in good health.
I need to inform you that the cheese has run away.
Sincerely, Pesho
9/14/2015
*/

class LetterCreator
{
    static void Main() //В примера има грешка, местата на Пешо и Гошо трябва да са разменени.
    {
        Console.Title = "Problem 1.	Letter Creator";

        string sender = Console.ReadLine();
        string receiver = Console.ReadLine();

        DateTime time = DateTime.Today;

        PrintLetter(receiver, sender, time);
    }

    static void PrintLetter(string sender, string receiver, DateTime time)
    {
        Console.WriteLine("Dear {0},", receiver);
        Console.WriteLine("I hope I find you in good health.");
        Console.WriteLine("I need to inform you that the cheese has run away.");
        Console.WriteLine("Sincerely, {0}", sender);
        Console.WriteLine(time.ToString("d"));
    }
}

