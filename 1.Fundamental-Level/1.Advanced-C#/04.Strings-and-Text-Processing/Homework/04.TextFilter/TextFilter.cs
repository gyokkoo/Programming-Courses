namespace _04.TextFilter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            char[] emptyEntries = { ' ', ',' };
            string[] bannedWords = Console.ReadLine().Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}