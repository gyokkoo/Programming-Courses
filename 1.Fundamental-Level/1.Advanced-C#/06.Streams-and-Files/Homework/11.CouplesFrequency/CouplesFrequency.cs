namespace _11.CouplesFrequency
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CouplesFrequency
    {
        public static void Main()
        {
            var couplesFrequency = new Dictionary<string, int>();
            string[] numbers = Console.ReadLine().Split();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                string currentCouple = numbers[i] + " " + numbers[i + 1];

                if (!couplesFrequency.ContainsKey(currentCouple))
                {
                    couplesFrequency.Add(currentCouple, 0);
                }

                couplesFrequency[currentCouple]++;
            }

            int sum = couplesFrequency.Sum(x => x.Value);
            foreach (var pair in couplesFrequency)
            {
                Console.WriteLine("{0} -> {1:F2}%", pair.Key, (double)pair.Value / sum * 100);
            }
        }
    }
}
