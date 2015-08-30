using System;
using System.Collections.Generic;
using System.Linq;

class SieveOfEratosthenes
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        bool[] primes = new bool[number + 1];

        for (int i = 2; i < Math.Sqrt(primes.Length); i++)
        {
            if (primes[i] == false)
            {
                for (int j = i * i; j < primes.Length; j += i)
                {
                    primes[j] = true;
                }
            }
        }

        List<int> primesList = new List<int>();

        for (int i = 2; i < primes.Length; i++)
        {
            if (!primes[i])
            {
                primesList.Add(i);
            }
        }

        Console.WriteLine(string.Join(", ", primesList));
    }
}