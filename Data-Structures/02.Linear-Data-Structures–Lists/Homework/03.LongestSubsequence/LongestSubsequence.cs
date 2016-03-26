namespace _03.LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSubsequence
    {
        public static void Main()
        {
            string[] lineArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = lineArgs.Select(int.Parse).ToList();

            List<int> lngestSubsequence = GetLongestSubsequence(numbers);

            Console.WriteLine(string.Join(" ", lngestSubsequence));
        }

        private static List<int> GetLongestSubsequence(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("The list is empty.");
            }

            int longestSequenceElement = numbers[0];
            int longestSequenceCount = 1;
            int currentSequenceCount = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentSequenceCount++;
                }
                else
                {
                    currentSequenceCount = 1;
                }

                if (currentSequenceCount > longestSequenceCount)
                {
                    longestSequenceCount = currentSequenceCount;
                    longestSequenceElement = numbers[i];
                }
            }

            var result = new List<int>();
            for (int i = 0; i < longestSequenceCount; i++)
            {
                result.Add(longestSequenceElement);
            }

            return result;
        } 
    }
}
