namespace _25.Pyramid
{
    using System;
    using System.Collections.Generic;

    public class Pyramid
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> sequence = new List<int>();

            int previousNumber = int.Parse(Console.ReadLine().Trim());
            sequence.Add(previousNumber);

            for (int i = 1; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] numbersAsStrings = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int[] numbers = new int[numbersAsStrings.Length];
                for (int j = 0; j < numbersAsStrings.Length; j++)
                {
                    numbers[j] = int.Parse(numbersAsStrings[j]);
                }

                int minNumber = int.MaxValue;
                bool foundNumber = false;
                for (int j = 0; j < numbers.Length; j++)
                {
                    int currentNumber = numbers[j];
                    if (currentNumber < minNumber && currentNumber > previousNumber)
                    {
                        minNumber = currentNumber;
                        foundNumber = true;
                    }
                }

                if (foundNumber)
                {
                    sequence.Add(minNumber);
                    previousNumber = minNumber;
                }
                else
                {
                    previousNumber++;
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}