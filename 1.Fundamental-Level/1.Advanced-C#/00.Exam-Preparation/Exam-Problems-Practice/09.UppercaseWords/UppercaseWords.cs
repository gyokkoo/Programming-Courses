namespace _09.UppercaseWords
{
    using System;
    using System.Security;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UppercaseWords
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            Regex regex = new Regex(@"(?<![a-zA-Z])[A-Z]+(?![a-zA-Z])");
            while (line != "END")
            {
                MatchCollection matches = regex.Matches(line);

                int offset = 0;
                foreach (Match match in matches)
                {
                    string word = match.Value;
                    string reversed = Reverse(word);
                    if (reversed == word)
                    {
                        reversed = DoubleEachLetter(reversed);
                    }

                    int index = match.Index;
                    line = line.Remove(index + offset, word.Length);
                    line = line.Insert(index + offset, reversed);
                    offset += reversed.Length - word.Length;
                }

                Console.WriteLine(SecurityElement.Escape(line));
                line = Console.ReadLine();
            }
        }

        private static string DoubleEachLetter(string reversed)
        {
            StringBuilder result = new StringBuilder();
            foreach (char letter in reversed)
            {
                result.Append(new string(letter, 2));
            }

            return result.ToString();
        }

        private static string Reverse(string value)
        {
            StringBuilder result = new StringBuilder();
            for (int i = value.Length - 1; i >= 0; i--)
            {
                result.Append(value[i]);
            }

            return result.ToString();
        }
    }
}

