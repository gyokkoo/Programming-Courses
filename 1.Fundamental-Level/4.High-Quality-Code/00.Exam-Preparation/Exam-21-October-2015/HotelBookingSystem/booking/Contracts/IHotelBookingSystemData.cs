namespace HotelBookingSystem.Contracts
{
    using HotelBookingSystem.Models;

    public interface IHotelBookingSystemData
    {
        IUserRepository UsersRepository { get; }

        IRepository<Venue> VenuesRepository { get; }

        IRepository<Room> RoomsRepository { get; }

        IRepository<Booking> BookingsRepository { get; }
    }
}