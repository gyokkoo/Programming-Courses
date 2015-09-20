using System;
using System.Collections.Generic;
/*
Being a nerd means writing programs about night clubs instead of actually going to ones. Spiro is a nerd and he decided to sum	arize some info about the most popular night clubs around the world. 
He's come up with the following structure – he'll summarize the data by city, where each city will have a list of venues and each venue will have a list of performers. Help him finish the program, so he can stop staring at the computer screen and go get himself a cold beer.
You'll receive the input from the console. There will be an arbitrary number of lines until you receive the string "END". Each line will contain data in format: "city;venue;performer". If either city, venue or performer don't exist yet in the database, add them. If either the city and/or venue already exist, update their info.
Cities should remain in the order in which they were added, venues should be sorted alphabetically and performers should be unique (per venue) and also sorted alphabetically.
Print the data by listing the cities and for each city its venues (on a new line starting with "->") and performers (separated by comma and space). Check the examples to get the idea. And grab a beer when you're done, you deserve it. Spiro is buying.
Input	
Sofia;Biad;Preslava
Pernik;Stadion na mira;Vinkel
New York;Statue of Liberty;Krisko
Oslo;everywhere;Behemoth
Pernik;Letishteto;RoYaL
Pernik;Stadion na mira;Bankin
Pernik;Stadion na mira;Vinkel
END	
Output
Sofia
->Biad: Preslva
Pernik
->Letishteto: RoYaL
->Stadion na mira: Bankin, Vinkel
NewYork
->Statue of Liberty: Krisko
Oslo
->everywhere: Behemoth
 */
class NightLife
{
    static void Main()
    {
        Console.Title = "Problem 8.	Night Life";

        var clubs = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        FillClubsInformation(clubs);

        foreach (var city in clubs)
        {
            Console.WriteLine(city.Key);
            foreach (var items in city.Value)
            {
                Console.WriteLine("->{0}: {1}", items.Key, string.Join(", ", items.Value));
            }
        }
    }

    static void FillClubsInformation(Dictionary<string, SortedDictionary<string, SortedSet<string>>> clubs)
    {
        string[] inputLine = Console.ReadLine().Split(';');

        while (inputLine[0] != "END")
        {
            string city = inputLine[0];
            string venue = inputLine[1];
            string performer = inputLine[2];

            if (!clubs.ContainsKey(city))
            {
                var performersCollection = new SortedSet<string>();
                performersCollection.Add(performer);

                var venuesColletions = new SortedDictionary<string, SortedSet<string>>();
                venuesColletions.Add(venue, performersCollection);

                clubs.Add(city, venuesColletions);
            }
            else if (clubs.ContainsKey(city))
            {
                if (!clubs[city].ContainsKey(venue))
                {
                    var performersCollection = new SortedSet<string>();
                    performersCollection.Add(performer);

                    clubs[city].Add(venue, performersCollection);
                }
                else
                {
                    clubs[city][venue].Add(performer);
                }
            }

            inputLine = Console.ReadLine().Split(';');
        }
    }
}