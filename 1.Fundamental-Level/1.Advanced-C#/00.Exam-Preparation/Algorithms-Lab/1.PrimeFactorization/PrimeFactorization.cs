using System;
using System.Collections.Generic;

class PrimeFactorization
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        List<long> primesList = new List<long>();

        long n = number;

        while (number % 2 == 0)
        {
            primesList.Add(2);
            number /= 2;
        }

        long factor = 3;
        while (factor * factor <= number)
        {
            if (number % factor == 0)
            {
                primesList.Add(factor);
                number /= factor;
            }
            else
            {
                factor += 2;
            }
        }

        if (number > 1)
        {
            primesList.Add(number);
        }

        Console.Write("{0} = ", n);
        Console.WriteLine(string.Join(" * ", primesList));
    }
}