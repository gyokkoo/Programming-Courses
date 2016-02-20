namespace _08.UseYourChainsBuddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=<p>)(.*?)(?=</p>)";

            StringBuilder decryptedText = new StringBuilder();
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                string message = match.Value;
                message = Regex.Replace(message, @"[^a-z0-9]+", " ");
                message = Regex.Replace(message, @"\s+", " ");

                string decryptedMessage = GetDecryptedMessage(message);
                decryptedText.Append(decryptedMessage);
            }

            Console.WriteLine(decryptedText);
        }

        private static string GetDecryptedMessage(string message)
        {
            StringBuilder result = new StringBuilder();

            foreach (var letter in message)
            {
                if ('a' <= letter && letter <= 'm')
                {
                    result.Append((char)(letter + 13));
                }
                else if ('n' <= letter && letter <= 'z')
                {
                    result.Append((char)(letter - 13));
                }
                else
                {
                    result.Append(letter);
                }
            }

            return result.ToString();
        }
    }
}
