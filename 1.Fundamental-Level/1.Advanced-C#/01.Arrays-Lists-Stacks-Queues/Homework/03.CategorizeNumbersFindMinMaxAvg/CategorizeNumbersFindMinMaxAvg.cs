namespace _03.CategorizeNumbersFindMinMaxAvg
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategorizeNumbersFindMinMaxAvg
    {
        public static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            List<double> roundNumbers = new List<double>();
            List<double> floatingNumbers = new List<double>();

            foreach (var number in numbers)
            {
                if (number % 1 == 0)
                {
                    roundNumbers.Add(number);
                }
                else
                {
                    floatingNumbers.Add(number);
                }
            }

            CategorizeNumbers(floatingNumbers);
            CategorizeNumbers(roundNumbers);
        }

        private static void CategorizeNumbers(List<double> numbers)
        {
            var min = numbers.Min();
            var max = numbers.Max();
            var sum = numbers.Sum();
            var avg = numbers.Average();

            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg {4:F2}",
                string.Join(", ", numbers),
                min,
                max,
                sum,
                avg);
        }
    }
}
