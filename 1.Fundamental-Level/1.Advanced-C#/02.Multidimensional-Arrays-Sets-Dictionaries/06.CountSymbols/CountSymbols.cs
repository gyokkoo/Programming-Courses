namespace _06.CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class CountSymbols
    {
        public static void Main()
        {
            var symbolsCount = new SortedDictionary<char, int>();

            string text = Console.ReadLine();
            foreach (char symbol in text)
            {
                if (!symbolsCount.ContainsKey(symbol))
                {
                    symbolsCount.Add(symbol, 1);
                }
                else
                {
                    symbolsCount[symbol]++;
                }
            }

            foreach (var pair in symbolsCount)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}