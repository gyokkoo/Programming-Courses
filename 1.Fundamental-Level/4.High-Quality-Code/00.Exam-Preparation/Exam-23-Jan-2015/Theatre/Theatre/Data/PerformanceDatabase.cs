namespace Theatre.Data
{
    using System;
    using System.Collections.Generic;

    using Theatre.Contracts;
    using Theatre.Exceptions;
    using Theatre.Models;

    public class PerformanceDatabase : IPerformanceDatabase
    {
        private readonly SortedDictionary<string, SortedSet<Performance>> performances;

        public PerformanceDatabase()
        {
            this.performances = new SortedDictionary<string, SortedSet<Performance>>();   
        }

        public void AddTheatre(string theathre)
        {
            if (this.performances.ContainsKey(theathre))
            {
                throw new DuplicateTheatreException("Duplicate theatre");
            }

            this.performances[theathre] = new SortedSet<Performance>();
        }

        public IEnumerable<string> ListTheatres()
        {
            var theatres = this.performances.Keys;

            return theatres;
        }

        public void AddPerformance(
            string theathre, 
            string performance, 
            DateTime startDate, 
            TimeSpan duration, 
            decimal ticketPrice)
        {
            if (!this.performances.ContainsKey(theathre))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }

            var allPerformances = this.performances[theathre];

            var endDate = startDate + duration;
            if (Check(allPerformances, startDate, endDate))
            {
                throw new TimeDurationOverlapException("Time/duration overlap");
            }

            var theatrePerformance = new Performance(theathre, performance, startDate, duration, ticketPrice);
            allPerformances.Add(theatrePerformance);
        }

        public IEnumerable<Performance> ListAllPerformances()
        {
            var theatres = this.performances.Keys;

            var allPerformances = new List<Performance>();
            foreach (var theatre in theatres)
            {
                var performance = this.performances[theatre];
                allPerformances.AddRange(performance);
            }

            return allPerformances;
        }

        public IEnumerable<Performance> ListPerformances(string theatreName)
        {
            if (!this.performances.ContainsKey(theatreName))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }

            return this.performances[theatreName];
        }

        private static bool Check(
            IEnumerable<Performance> performances, 
            DateTime startDate, 
            DateTime endDate)
        {
            foreach (var p in performances)
            {
                var start = p.StartDate;
                var end = p.StartDate + p.Duration;

                var isOverlapping = (start <= startDate && startDate <= end) || 
                    (start <= endDate && endDate <= end) || 
                    (startDate <= start && start <= endDate) || 
                    (startDate <= end && end <= endDate);
                if (isOverlapping)
                {
                    return true;
                }
            }

            return false;
        }
    }
}