namespace HotelBookingSystem.Views.Users
{
    using System.Linq;
    using System.Text;

    using HotelBookingSystem.Infrastructure;
    using HotelBookingSystem.Models;

    public class MyProfile : View
    {
        public MyProfile(User user)
            : base(user)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var user = this.Model as User;
            viewResult.AppendLine(user.Username);
            if (!user.Bookings.Any())
            {
                viewResult.AppendLine("You have not made any bookings yet.");
            }
            else
            {
                viewResult.AppendLine("Your bookings:");
                foreach (var booking in user.Bookings)
                {
                    viewResult.AppendFormat("* {0:dd.MM.yyyy} - {1:dd.MM.yyyy} (${2:F2})", booking.StartBookDate, booking.EndBookDate, booking.TotalPrice).AppendLine();
                }
            }
        }
    }
}