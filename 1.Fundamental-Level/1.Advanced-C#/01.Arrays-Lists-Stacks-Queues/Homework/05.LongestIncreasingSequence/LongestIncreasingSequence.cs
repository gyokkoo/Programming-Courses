namespace _05.LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSequence
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> maxSequence = new List<int>();
            List<int> currentSequence = new List<int>();

            Console.Write(numbers[0] + " ");
            currentSequence.Add(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                int previousNumber = numbers[i - 1];
                int currentNumber = numbers[i];

                if (currentNumber > previousNumber && i != numbers.Length - 1)
                {
                    Console.Write(currentNumber + " ");
                    currentSequence.Add(currentNumber);
                }
                else if (currentNumber > previousNumber && i == numbers.Length - 1)
                {
                    Console.Write(currentNumber + " ");
                    currentSequence.Add(currentNumber);

                    if (currentSequence.Count > maxSequence.Count)
                    {
                        maxSequence.Clear();
                        maxSequence.AddRange(currentSequence);
                    }
                }
                else
                {
                    Console.Write(Environment.NewLine + currentNumber + " ");

                    if (currentSequence.Count > maxSequence.Count)
                    {
                        maxSequence.Clear();
                        maxSequence.AddRange(currentSequence);
                    }

                    currentSequence.Clear();
                    currentSequence.Add(currentNumber);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Longest: " + string.Join(" ", maxSequence));
        }
    }
}