namespace HotelBookingSystem.Models
{
    using System;
    using System.Collections.Generic;

    using HotelBookingSystem.Contracts;

    public class Room : IDatabaseEntity
    {
        private int places;
        private decimal pricePerDay;

        public Room(int places, decimal pricePerDay)
        {
            this.Places = places;
            this.PricePerDay = pricePerDay;
            this.Bookings = new List<Booking>();
            this.AvailableDates = new List<AvailableDate>();
        }

        public int Id { get; set; }

        public int Places
        {
            get
            {
                return this.places;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "The places must not be less than 0.");
                }

                this.places = value;
            }
        }

        public decimal PricePerDay
        {
            get
            {
                return this.pricePerDay;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "The price per day must not be less than 0.");
                }

                this.pricePerDay = value;
            }
        }

        public ICollection<AvailableDate> AvailableDates { get; private set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}