namespace HotelBookingSystem.Models
{
    using System;

    using HotelBookingSystem.Contracts;

    public class Booking : IDatabaseEntity
    {
        private DateTime endBookDate;
        private decimal totalPrice;

        public Booking(User client, DateTime startBookDate, DateTime endBookDate, decimal totalPrice, string comments)
        {
            this.Client = client;
            this.StartBookDate = startBookDate;
            this.EndBookDate = endBookDate;
            this.TotalPrice = totalPrice;
            this.Comments = comments;
        }

        public int Id { get; set; }

        public User Client { get; private set; }

        public string Comments { get; private set; }

        public DateTime StartBookDate { get; private set; }

        public DateTime EndBookDate
        {
            get
            {
                return this.endBookDate;
            }

            private set
            {
                if (value < this.StartBookDate)
                {
                    throw new ArgumentException(
                        "The date range is invalid.");
                }

                this.endBookDate = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return this.totalPrice;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "The total price must not be less than 0.");
                }

                this.totalPrice = value;
            }
        }
    }
}