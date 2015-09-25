using System;
/*
You have some text that contains your email address. You’re sick of spammers, so you want to hide it. ]
You decide to replace all characters in it with asterisks ('*') except the domain. Assume the email address 
will always be in format [username]@[domain]; you’ll need to replace username with asterisks of equal 
length and keep the domain unchanged. 
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

        string censoredEmail = new string('*', username.Length) + domain;

        text = text.Replace(correctEmail, censoredEmail);

        Console.WriteLine(text);
    }   
}