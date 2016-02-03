namespace HotelBookingSystem.Views.Rooms
{
    using System.Text;

    using HotelBookingSystem.Infrastructure;
    using HotelBookingSystem.Models;

    public class Book : View
    {
        public Book(Booking booking)
            : base(booking)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var booking = this.Model as Booking;
            viewResult.AppendFormat("Room booked from {0:dd.MM.yyyy} to {1:dd.MM.yyyy} for ${2:F2}.", booking.StartBookDate, booking.EndBookDate, booking.TotalPrice).AppendLine();
        }
    }
}