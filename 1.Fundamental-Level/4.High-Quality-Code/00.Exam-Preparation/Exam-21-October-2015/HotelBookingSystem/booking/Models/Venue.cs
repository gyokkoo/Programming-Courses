namespace HotelBookingSystem.Models
{
    using System;
    using System.Collections.Generic;

    using HotelBookingSystem.Contracts;
    using HotelBookingSystem.Utilities;

    public class Venue : IDatabaseEntity
    {
        private string name;
        private string address;

        public Venue(string name, string address, string description, User owner)
        {
            this.Name = name;
            this.Address = address;
            this.Description = description;
            this.Owner = owner;
            this.Rooms = new HashSet<Room>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < Constants.MinVenueNameLength)
                {
                    throw new ArgumentException(
                        $"The venue name must be at least {Constants.MinVenueNameLength} symbols long.");
                }

                this.name = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < Constants.MinVenueAddressLength)
                {
                    throw new ArgumentException(
                        $"The venue address must be at least {Constants.MinVenueAddressLength} symbols long.");
                }

                this.address = value;
            }
        }

        public string Description { get; set; }

        public User Owner { get; set; }

        public int Id { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}