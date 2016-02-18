namespace _06.Palindromes
{
    using System;
    using System.Collections.Generic;

    public class Palindromes
    {
        public static void Main()
        {
            char[] empyEntries = { ' ', ',', '.', '?', '!' };
            string[] words = Console.ReadLine().Split(empyEntries, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> palindromes = new SortedSet<string>();

            foreach (string word in words)
            {
                if (IsPalyndrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }

        private static bool IsPalyndrome(string word)
        {
            if (word.Length == 1)
            {
                return true;
            }

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}