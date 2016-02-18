namespace _08.NightLife
{
    using System;
    using System.Collections.Generic;

    public class NightLife
    {
        public static void Main()
        {
            var clubs = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] lineArgs = line.Split(';');

                string city = lineArgs[0];
                string venue = lineArgs[1];
                string performer = lineArgs[2];

                if (!clubs.ContainsKey(city))
                {
                    clubs[city] = new SortedDictionary<string, SortedSet<string>>();
                    clubs[city][venue] = new SortedSet<string>();
                    clubs[city][venue].Add(performer);
                }
                else
                {
                    if (!clubs[city].ContainsKey(venue))
                    {
                        clubs[city][venue] = new SortedSet<string>();
                        clubs[city][venue].Add(performer);
                    }
                    else
                    {
                        clubs[city][venue].Add(performer);
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var pair in clubs)
            {
                Console.WriteLine(pair.Key);
                foreach (var innerPair in pair.Value)
                {
                    Console.WriteLine("->{0}: {1}", innerPair.Key, string.Join(", ", innerPair.Value));
                }
            }
        }
    }
}