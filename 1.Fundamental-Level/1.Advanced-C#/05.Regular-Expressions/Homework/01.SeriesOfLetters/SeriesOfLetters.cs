namespace _01.SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                string pattern = $@"{text[i]}+";
                string replacement = text[i].ToString();

                Regex regex = new Regex(pattern);
                text = regex.Replace(text, replacement);
            }

            Console.WriteLine(text);
        }
    }
}