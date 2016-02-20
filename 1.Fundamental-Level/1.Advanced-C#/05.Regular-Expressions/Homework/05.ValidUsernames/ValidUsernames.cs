namespace _05.ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            char[] spliChars = { ' ', '/', '\\', '(', ')' };
            string[] usernames = Console.ReadLine().Split(spliChars, StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();

            Regex regex = new Regex(@"\b[a-zA-Z]\w{2,25}\b");
            foreach (var username in usernames)
            {
                if (regex.IsMatch(username))
                {
                    validUsernames.Add(username);
                }
            }

            int maxSum = 0;
            int index = 0;
            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                int currentSum = validUsernames[i].Length + validUsernames[i + 1].Length;
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    index = i;
                }
            }

            Console.WriteLine(validUsernames[index]);
            Console.WriteLine(validUsernames[index + 1]);
        }
    }
}
