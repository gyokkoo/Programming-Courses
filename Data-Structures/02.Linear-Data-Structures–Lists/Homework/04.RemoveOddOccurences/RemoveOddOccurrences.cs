namespace _04.RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveOddOccurrences
    {
        public static void Main()
        {
            string[] lineArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = lineArgs.Select(int.Parse).ToList();
            List<int> resultNumbers = new List<int>(numbers);

            foreach (int number in numbers)
            {
                int occurrences = numbers.Count(x => x == number);

                if (occurrences % 2 == 1)
                {
                    resultNumbers.Remove(number);
                }
            }

            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}
