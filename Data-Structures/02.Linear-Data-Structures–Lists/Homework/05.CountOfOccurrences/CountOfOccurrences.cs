namespace _05.CountOfOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfOccurrences
    {
        public static void Main()
        {
            string[] lineArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = lineArgs.Select(int.Parse).ToList();
            List<int> distinctNumbers = numbers.Distinct().ToList();

            distinctNumbers.Sort();

            foreach (var number in distinctNumbers)
            {
                Console.WriteLine("{0} -> {1} times", number, numbers.Count(x => x == number));
            }
        }
    }
}