namespace HotelBookingSystem.Data
{
    using HotelBookingSystem.Contracts;

    using Models;

    public class HotelBookingSystemData : IHotelBookingSystemData
    {
        public HotelBookingSystemData()
        {
            this.UsersRepository = new UserRepository();
            this.VenuesRepository = new Repository<Venue>();
            this.RoomsRepository = new Repository<Room>();
            this.BookingsRepository = new Repository<Booking>();
        }

        public IUserRepository UsersRepository { get; private set; }

        public IRepository<Venue> VenuesRepository { get; private set; }

        public IRepository<Room> RoomsRepository { get; private set; }

        public IRepository<Booking> BookingsRepository { get; private set; }
    }
}
