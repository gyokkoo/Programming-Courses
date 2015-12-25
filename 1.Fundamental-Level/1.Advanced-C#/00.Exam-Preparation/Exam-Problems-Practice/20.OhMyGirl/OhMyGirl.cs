namespace _20.OhMyGirl
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public class OhMyGirl
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string line = Console.ReadLine();

            StringBuilder text = new StringBuilder();
            while (line != "END")
            {
                line = Regex.Replace(line, "\\s+", " ");
                text.Append(line);
                line = Console.ReadLine();
            }

            string pattern = BuildPattern(key) + "(.{2,6}?)" + BuildPattern(key);
            MatchCollection matches = Regex.Matches(text.ToString(), pattern);
            foreach (Match match in matches)
            {
                Console.Write(match.Groups[1]);
            }
        }

        private static string BuildPattern(string key)
        {
            const string digitRegex = "[0-9]*";
            const string lowerLetterRegex = "[a-z]*";
            const string upperLetterRegex = "[A-Z]*";

            StringBuilder pattern = new StringBuilder();
            if (IsSpecial(key[0]))
            {
                pattern.Append("\\" + key[0]);
            }
            else
            {
                pattern.Append(key[0]);
            }

            for (int i = 1; i < key.Length - 1; i++)
            {
                if (char.IsDigit(key[i]))
                {
                    pattern.Append(digitRegex);
                }
                else if (char.IsLower(key[i]))
                {
                    pattern.Append(lowerLetterRegex);
                }
                else if (char.IsUpper(key[i]))
                {
                    pattern.Append(upperLetterRegex);
                }
                else if (IsSpecial(key[i]))
                {
                    pattern.Append("\\" + key[i]);
                }
                else
                {
                    pattern.Append(key[i]);
                }
            }

            if (IsSpecial(key[key.Length - 1]))
            {
                pattern.Append("\\" + key[key.Length - 1]);
            }
            else
            {
                pattern.Append(key[key.Length - 1]);
            }

            return pattern.ToString(); ;
        }

        private static bool IsSpecial(char c)
        {
            if (c == '[' || c == ']' || c == '(' || c == ')' ||
                c == '+' || c == '.' || c == '*')
            {
                return true;
            }

            return false;
        }
    }
}
