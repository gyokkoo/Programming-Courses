namespace HotelBookingSystem.Controllers
{
    using System;
    using System.Linq;

    using Contracts;
    using Infrastructure;
    using Models;

    public class RoomsController : Controller
    {
        public RoomsController(IHotelBookingSystemData data, User user)
            : base(data, user)
        {
        }

        public IView Add(int venueId, int places, decimal pricePerDay)
        {
            this.Authorize(Roles.VenueAdmin);

            var venue = this.Data.VenuesRepository.Get(venueId);
            if (venue == null)
            {
                return this.NotFound(
                    $"The venue with ID {venueId} does not exist.");
            }

            var newRoom = new Room(places, pricePerDay);
            venue.Rooms.Add(newRoom);

            this.Data.RoomsRepository.Add(newRoom);

            return this.View(newRoom);
        }

        public IView AddPeriod(int roomId, DateTime startDate, DateTime endDate)
        {
            this.Authorize(Roles.VenueAdmin);

            var room = Data.RoomsRepository.Get(roomId);
            if (room == null)
            {
                return this.NotFound(
                    $"The room with ID {roomId} does not exist.");
            }

            room.AvailableDates.Add(new AvailableDate(startDate, endDate));

            return this.View(room);
        }

        public IView ViewBookings(int id)
        {
            // this.Authorize(Roles.User, Roles.VenueAdmin);
            this.Authorize(Roles.VenueAdmin);

            var room = this.Data.RoomsRepository.Get(id);
            if (room == null)
            {
                return this.NotFound($"The room with ID {id} does not exist.");
            }

            return this.View(room.Bookings);
        }

        public IView Book(int roomId, DateTime startDate, DateTime endDate, string comments)
        {
            this.Authorize(Roles.User, Roles.VenueAdmin);
            var room = this.Data.RoomsRepository.Get(roomId);
            if (room == null)
            {
                return this.NotFound($"The room with ID {roomId} does not exist.");
            }

            var availablePeriod = room
                .AvailableDates
                .FirstOrDefault(d => d.StartDate <= startDate && d.EndDate >= endDate);

            if (availablePeriod == null)
            {
                throw new ArgumentException(string.Format(
                    "The room is not available to book in the period {0:dd.MM.yyyy} - {1:dd.MM.yyyy}.",
                    startDate, 
                    endDate));
            }

            decimal totalPrice = (endDate - startDate).Days * room.PricePerDay;

            var booking = new Booking(this.CurrentUser, startDate, endDate, totalPrice, comments);
            room.Bookings.Add(booking);
            this.CurrentUser.Bookings.Add(booking);
            this.UpdateRoomAvailability(startDate, endDate, room, availablePeriod);

            return this.View(booking);
        }

        private void UpdateRoomAvailability(DateTime startDate, DateTime endDate, Room room, AvailableDate availablePeriod)
        {
            room.AvailableDates.Remove(availablePeriod);
            var periodBeforeBooking = startDate - availablePeriod.StartDate;
            if (periodBeforeBooking > TimeSpan.Zero)
            {
                room.AvailableDates.Add(new AvailableDate(availablePeriod.StartDate, availablePeriod.StartDate.Add(periodBeforeBooking)));
            }

            var periodAfterBooking = availablePeriod.EndDate - endDate;
            if (periodAfterBooking > TimeSpan.Zero)
            {
                room.AvailableDates.Add(new AvailableDate(availablePeriod.EndDate.Subtract(periodAfterBooking), availablePeriod.EndDate));
            }
        }
    }
}
