using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class OlympicsAreComing
{
    public static void Main()
    {
        var countries = new List<Country>();

        string line = Console.ReadLine();

        while (line != "report")
        {
            string[] names = line.Split('|');
            string athlete = names[0];
            string countryName = names[1];

            athlete = Regex.Replace(athlete, @"\s{2,}", " ").Trim();
            countryName = Regex.Replace(countryName, @"\s{2,}", " ").Trim();

            Country country = countries.FirstOrDefault(c => c.Name == countryName);
            
            if (country == null)
            {
                country = new Country(countryName);
                countries.Add(country);
            }

            country.AddRecord(athlete);
 
            line = Console.ReadLine();
        }

        var orderedCountries = countries.OrderByDescending(x => x.Wins);
        foreach (var orderedCountry in orderedCountries)
        {
            Console.WriteLine(
                "{0} ({1} participants): {2} wins",
                orderedCountry.Name,
                orderedCountry.CountOfParticipants,
                orderedCountry.Wins);

        }
    }

    public class Country
    {
        private HashSet<string> participants; 
        public Country(string name)
        {
            this.Name = name;
            this.participants = new HashSet<string>();
        }

        public string Name { get; private set; }

        public int Wins { get; private set; }

        public int CountOfParticipants
        {
            get
            {
                return this.participants.Count;
            }
        }

        public void AddRecord(string athleteName)
        {
            this.Wins++;
            this.participants.Add(athleteName);
        }
    }
}
