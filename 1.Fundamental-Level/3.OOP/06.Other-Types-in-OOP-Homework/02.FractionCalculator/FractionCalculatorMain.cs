using System;

namespace _02.FractionCalculator
{
    public class FractionCalculatorMain
    {
        public static void Main(string[] args)
        {
            Console.Title = "Problem 2.	Fraction Calculator";

            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);

            Fraction result = fraction1 + fraction2;

            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}
