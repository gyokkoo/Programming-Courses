namespace Theatre.Models
{
    using System;

    public class Performance : IComparable<Performance>
    {
        public Performance(
            string theatreName, 
            string performances, 
            DateTime startDate, 
            TimeSpan duration, 
            decimal ticketPrice)
        {
            this.TheatreName = theatreName;
            this.Performances = performances;
            this.StartDate = startDate;
            this.Duration = duration;
            this.TicketPrice = ticketPrice;
        }

        public string TheatreName { get; private set; }

        public string Performances { get; private set; }

        public DateTime StartDate { get; private set; }

        public TimeSpan Duration { get; private set; }

        public decimal TicketPrice { get; private set; }

        int IComparable<Performance>.CompareTo(Performance otherPerformance)
        {
            int tmp = this.StartDate.CompareTo(otherPerformance.StartDate);
            return tmp;
        }
    }
}
