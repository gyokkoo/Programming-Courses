namespace _02.LastDigitOfNumber
{
    using System;

    public class LastDigitOfNumber
    {
        public static void Main()
        {
            Console.WriteLine(GetLastDigitAsWord(512));
            Console.WriteLine(GetLastDigitAsWord(1024));
            Console.WriteLine(GetLastDigitAsWord(12309));
        }

        private static string GetLastDigitAsWord(int number)
        {
            string[] digitAsWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int index = number % 10;

            string lastDigitAsWord = digitAsWords[index];

            return lastDigitAsWord;
        }
    }
}