namespace _4.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, long>>();

            string line = Console.ReadLine();
            while (line != "report")
            {
                string[] lineParams = line.Split('|');

                string city = lineParams[0];
                string country = lineParams[1];
                long population = int.Parse(lineParams[2]);

                if (!data.ContainsKey(country))
                {
                    data[country] = new Dictionary<string, long>();
                }

                data[country].Add(city, population);

                line = Console.ReadLine();
            }

            var sortedData = data.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var pair in sortedData)
            {
                Console.WriteLine("{0} (total population: {1})", pair.Key, pair.Value.Values.Sum());

                var sortedInnerData = pair.Value.OrderByDescending(x => x.Value);
                foreach (var innerPair in sortedInnerData)
                {
                    Console.WriteLine("=>{0}: {1}", innerPair.Key, innerPair.Value);
                }
            }
        }
    }
}