namespace _07.LettersChangeNumbers
{
    using System;
    using System.Linq;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            char[] emptyEntries = { ' ', '\t' };
            string[] strSequence = Console.ReadLine().Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            foreach (string str in strSequence)
            {
                char firstLetter = str.First();
                char lastLetter = str.Last();
                double number = double.Parse(str.Substring(1, str.Length - 2));

                number = FirstLetterOperations(firstLetter, number);
                number = LastLetterOperations(lastLetter, number);

                sum += number;
            }

            Console.WriteLine("{0:F2}", sum);
        }

        private static double LastLetterOperations(char lastLetter, double number)
        {
            if (char.IsUpper(lastLetter))
            {
                number -= lastLetter - 64;
            }
            else if (char.IsLower(lastLetter))
            {
                number += lastLetter - 96;
            }

            return number;
        }

        private static double FirstLetterOperations(char firstLetter, double number)
        {
            if (char.IsUpper(firstLetter))
            {
                number /= firstLetter - 64;
            }
            else if (char.IsLower(firstLetter))
            {
                number *= firstLetter - 96;
            }

            return number;
        }
    }
}