using System;
/*
Write a method which takes an array of any type and sorts it. 
Use bubble sort or selection sort (your own implementation). 
You may re-use your code from a previous homework and modify it. 
Use a generic method (read in Internet about generic methods in C#). 
Make sure that what you're trying to sort can be sorted – your method should work with numbers,
strings, dates, etc., but not necessarily with custom classes like Student.
 */
class NumberCalculations
{
    static void Main()
    {
        Console.Title = "Problem 6.	Number Calculations";

        Console.WriteLine("Enter an array of double numbers, separated by a space.");
        string[] doubleInput = Console.ReadLine().Split(' ');
        double[] doubleNums = new double[doubleInput.Length];

        for (int i = 0; i < doubleNums.Length; i++)
        {
            doubleNums[i] = double.Parse(doubleInput[i]);
        }

        Console.WriteLine("Minimum -> {0}, Maximum -> {1}, Average -> {2}, Sum -> {3}, Product -> {4}",
            GetMin(doubleNums), GetMax(doubleNums), GetAverage(doubleNums), GetSum(doubleNums), GetProdcut(doubleNums));


        Console.WriteLine("Enter an array of decimal numbers, separated by a space.");
        string[] decimalInput = Console.ReadLine().Split(' ');
        decimal[] decimalNums = new decimal[decimalInput.Length];

        for (int i = 0; i < decimalNums.Length; i++)
        {
            decimalNums[i] = decimal.Parse(decimalInput[i]);
        }

        Console.WriteLine("Minimum -> {0}, Maximum -> {1}, Average -> {2}, Sum -> {3}, Product -> {4}",
                   GetMin(decimalNums), GetMax(decimalNums), GetAverage(decimalNums), GetSum(decimalNums), GetProdcut(decimalNums));
    }

    static double GetProdcut(double[] doubleNums)
    {
        double product = 1;
        for (int i = 0; i < doubleNums.Length; i++)
        {
            product *= doubleNums[i];
        }
        return product;
    }
    static decimal GetProdcut(decimal[] decimalNums)
    {
        decimal product = 1;
        for (int i = 0; i < decimalNums.Length; i++)
        {
            product *= decimalNums[i];
        }
        return product;
    }

    static double GetSum(double[] doubleNums)
    {
        double sum = 0;
        for (int i = 0; i < doubleNums.Length; i++)
        {
            sum += doubleNums[i];
        }
        return sum;
    }
    static decimal GetSum(decimal[] decimalNums)
    {
        decimal sum = 0;
        for (int i = 0; i < decimalNums.Length; i++)
        {
            sum += decimalNums[i];
        }
        return sum;
    }

    static double GetAverage(double[] doubleNums)
    {
        double average = GetSum(doubleNums) / doubleNums.Length;
        return average;
    }
    static decimal GetAverage(decimal[] decimalNums)
    {
        decimal average = GetSum(decimalNums) / decimalNums.Length;
        return average;
    }

    static double GetMax(double[] doubleNums)
    {
        double max = double.MinValue;
        for (int i = 0; i < doubleNums.Length; i++)
        {
            if (doubleNums[i] > max)
                max = doubleNums[i];
        }
        return max;
    }
    static decimal GetMax(decimal[] decimalNums)
    {
        decimal max = decimal.MinValue;
        for (int i = 0; i < decimalNums.Length; i++)
        {
            if (decimalNums[i] > max)
                max = decimalNums[i];
        }
        return max;
    }

    static double GetMin(double[] doubleNums)
    {
        double min = double.MaxValue;
        for (int i = 0; i < doubleNums.Length; i++)
        {
            if (doubleNums[i] < min)
                min = doubleNums[i];
        }
        return min;
    }
    static decimal GetMin(decimal[] decimalNums)
    {
        decimal min = decimal.MaxValue;
        for (int i = 0; i < decimalNums.Length; i++)
        {
            if (decimalNums[i] < min)
                min = decimalNums[i];
        }
        return min;
    }
}