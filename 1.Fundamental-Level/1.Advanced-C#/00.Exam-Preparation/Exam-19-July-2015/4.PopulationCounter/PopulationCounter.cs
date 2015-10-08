using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main()
    {
        var data = new Dictionary<string, Dictionary<string, long>>();
        string line = Console.ReadLine();

        while (line != "report")
        {
            string[] inputArr = line.Split('|');
            string city = inputArr[0];
            string country = inputArr[1];
            int population = int.Parse(inputArr[2]);

            if (!data.ContainsKey(country))
            {
                data[country] = new Dictionary<string, long>();

            }

            data[country].Add(city, population);

            line = Console.ReadLine();
        }

        var sorted = data.OrderByDescending(c => c.Value.Sum(s => s.Value));

        foreach (var pair in sorted)
        {
            Console.WriteLine("{0} (total population: {1})",
                pair.Key, pair.Value.Sum(s => s.Value));
            foreach (var innerPair in pair.Value.OrderByDescending(c => c.Value))
            {
                Console.WriteLine("=>{0}: {1}", innerPair.Key, innerPair.Value);
            }
        }
    }
}
