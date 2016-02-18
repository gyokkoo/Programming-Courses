namespace _03.CountSubstringOccurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string searchString = Console.ReadLine().ToLower();

            int occurrenceCount = 0;

            for (int i = 0; i <= text.Length - searchString.Length; i++)
            {
                if (searchString == text.Substring(i, searchString.Length))
                {
                    occurrenceCount++;
                }
            }

            Console.WriteLine(occurrenceCount);
        }
    }
}