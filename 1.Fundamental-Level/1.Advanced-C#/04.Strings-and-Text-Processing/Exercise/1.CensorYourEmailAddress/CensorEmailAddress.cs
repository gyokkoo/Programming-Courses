namespace _1.CensorYourEmailAddress
{
    using System;

    public class CensorEmailAddress
    {
        public static void Main()
        {
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
}