using System;
using System.Linq;
using System.Collections.Generic;
/*
 */
class NightLife
{
    static void Main()
    {
        Console.Title = "Problem 8.	Night Life";

        var clubs = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();


        while (true)
        {
            string line = Console.ReadLine();
            string[] data;

            if (line != "END")
            {
                data = line.Split(';');
                string city = data[0];
                string venue = data[1];
                string performer = data[2];

                if (!clubs.ContainsKey(city))
                {
                    SortedSet<string> performers = new SortedSet<string>();
                    performers.Add(performer);

                    SortedDictionary<string, SortedSet<string>> venues = new SortedDictionary<string, SortedSet<string>>();
                    venues.Add(venue, performers);

                    clubs.Add(city, venues);
                }
                else if (clubs.ContainsKey(city))
                {
                    if (!clubs[city].ContainsKey(venue))
                    {
                        SortedSet<string> performers = new SortedSet<string>();
                        performers.Add(performer);

                        clubs[city].Add(venue, performers);
                    }
                    else if (clubs[city].ContainsKey(venue))
                    {
                        clubs[city][venue].Add(performer);
                    }
                }
            }
            else
            {
                break;
            }
        }

        foreach (var pair1 in clubs)
        {
            Console.WriteLine(pair1.Key);
            foreach (var pair2 in pair1.Value)
            {
                Console.WriteLine("->{0}: {1}", pair2.Key, string.Join(", ", pair2.Value));
            }
        }
    }
}