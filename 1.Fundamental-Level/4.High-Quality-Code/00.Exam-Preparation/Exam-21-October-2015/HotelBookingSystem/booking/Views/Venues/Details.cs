namespace HotelBookingSystem.Views.Venues
{
    using System.Linq;
    using System.Text;

    using HotelBookingSystem.Infrastructure;
    using HotelBookingSystem.Models;

    public class Details : View
    {
        public Details(Venue venue)
            : base(venue)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var venue = this.Model as Venue;
            viewResult.AppendLine(venue.Name)
                .AppendFormat("Located at {0}", venue.Address).AppendLine()
                .AppendFormat("Description: {0}", venue.Description).AppendLine();
            if (!venue.Rooms.Any())
            {
                viewResult.AppendFormat("No rooms are currently available.");
            }
            else
            {
                viewResult.AppendLine("Available rooms:");
                foreach (var room in venue.Rooms)
                {
                    viewResult.AppendFormat(" * {0} places (${1:F2} per day)", room.Places, room.PricePerDay).AppendLine();
                }
            }
        }
    }
}