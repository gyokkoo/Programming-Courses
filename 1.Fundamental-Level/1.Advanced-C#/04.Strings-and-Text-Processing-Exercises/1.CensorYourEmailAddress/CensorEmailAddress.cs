using System;
/*
Input:
 pesho.peshev@email.bg
My name is Pesho Peshev. I am from Sofia, my email is: pesho.peshev@email.bg (not pesho.peshev@email.com). Test: pesho.meshev@email.bg, pesho.peshev@email.bg
Output:
 My name is Pesho Peshev. I am from Sofia, my email is: ************@email.bg (not pesho.peshev@email.com). Test: pesho.meshev@email.bg, ************@email.bg

 */
class CensorEmailAddress
{
    static void Main()
    {
        Console.Title = "Problem 1. Censor Your Email Address";

        string correctEmail = Console.ReadLine();
        string text = Console.ReadLine();

        int indexOfDomainStart = correctEmail.IndexOf('@');

        string username = correctEmail.Substring(0, indexOfDomainStart);
        string domain = correctEmail.Substring(indexOfDomainStart, (correctEmail.Length - username.Length));
       
        string replacementString = new string('*', username.Length) + domain;

        text = text.Replace(correctEmail, replacementString );

        Console.WriteLine("\nOutput:");
        Console.WriteLine(text);
    }
}