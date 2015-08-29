using System;
using System.Collections.Generic;

class PrimeFactorization
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        List<long> primeMultiples = new List<long>();

        long divisor = 2;

        long number = n;
        while(number >= 2)
        {
            if(number % divisor == 0)
            {
                primeMultiples.Add(divisor);
                number = number / divisor;
            }
            else
            {
                divisor++;
                while(!isPrime(divisor) && (number < Math.Sqrt(number)))
                {
                    divisor++;
                }
            }
        }

        Console.Write("{0} = ", n);
        Console.WriteLine(string.Join(" * ", primeMultiples));
    }

    static bool isPrime(long number)
    {
        bool isPrime = true;
        if (number == 0 || number == 1)
        {
            isPrime = false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }
        return isPrime;
    }
}