namespace _01.SumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAndAverage
    {
        public static void Main()
        {
            string[] lineArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();
            foreach (string numberAsString in lineArgs)
            {
                int number;
                if (int.TryParse(numberAsString, out number))
                {
                    numbers.Add(number);
                }
            }

            if (numbers.Any())
            {
                long sum = numbers.Sum();
                double average = numbers.Average();
                Console.WriteLine($"sum={sum}; Average={average}");
            }
            else
            {
                Console.WriteLine("Sum=0; Average=0");
            }
        }
    }
}
