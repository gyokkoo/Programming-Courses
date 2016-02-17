namespace _05.ReverseNumber
{
    using System;
    using System.Linq;

    public class ReverseNumber
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double reversed = GetReversedNumber(number);

            Console.WriteLine(reversed);
        }

        private static double GetReversedNumber(double number)
        {
            string numberAsString = number.ToString().TrimStart('-');
            string reversedNumberAsString = new string(numberAsString.Reverse().ToArray());

            double reversedNumber = double.Parse(reversedNumberAsString);

            if (number < 0)
            {
                reversedNumber = -reversedNumber;
            }

            return reversedNumber;
        }
    }
}