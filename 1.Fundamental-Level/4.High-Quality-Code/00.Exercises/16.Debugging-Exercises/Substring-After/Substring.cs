namespace Substring_After
{
    using System;

    public class Substring
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = i + jump + 1;

                    if (endIndex > text.Length)
                    {
                        jump = text.Length - i - 1;
                    }

                    string matchedString = text.Substring(i, jump + 1);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}