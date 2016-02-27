namespace _23.CouplesFrequency
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CouplesFrequency
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int totalNumberOfCouples = numbers.Length - 1;
            var coupleFrequencies = new Dictionary<string, int>();
            for (int i = 1; i < numbers.Length; i++)
            {
                string currentCouple = string.Format("{0} {1}", numbers[i - 1], numbers[i]);
                if (!coupleFrequencies.ContainsKey(currentCouple))
                {
                    coupleFrequencies.Add(currentCouple, 0);
                }

                coupleFrequencies[currentCouple]++;
            }

            foreach (var coupleFrequency in coupleFrequencies)
            {
                double frequency = coupleFrequency.Value * 100.0 / totalNumberOfCouples;
                Console.WriteLine("{0} -> {1:F2}%", coupleFrequency.Key, frequency);
            }
        }
    }
}