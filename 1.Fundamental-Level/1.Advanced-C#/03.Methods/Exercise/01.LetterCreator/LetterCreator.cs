namespace _01.LetterCreator
{
    using System;

    public class LetterCreator
    {
        public static void Main()
        {
            string sender = Console.ReadLine();
            string receiver = Console.ReadLine();

            DateTime time = DateTime.Today;

            PrintLetter(receiver, sender, time);
        }

        private static void PrintLetter(string sender, string receiver, DateTime time)
        {
            Console.WriteLine("Dear {0},", receiver);
            Console.WriteLine("I hope I find you in good health.");
            Console.WriteLine("I need to inform you that the cheese has run away.");
            Console.WriteLine("Sincerely, {0}", sender);
            Console.WriteLine(time.ToString("d"));
        }
    }
}