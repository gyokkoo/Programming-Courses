namespace HotelBookingSystem.Models
{
    using System;
    using System.Collections.Generic;

    using HotelBookingSystem.Contracts;
    using HotelBookingSystem.Utilities;

    public class User : IDatabaseEntity
    {
        private string username;
        private string passwordHash;

        public User(string username, string password, Roles role)
        {
            this.Username = username;
            this.PasswordHash = password;
            this.Role = role;
            this.Bookings = new List<Booking>();
        }

        public int Id { get; set; }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < Constants.MinUsernameLength)
                {
                    throw new ArgumentException(
                        $"The username must be at least {Constants.MinUsernameLength} symbols long.");
                }

                this.username = value;
            }
        }

        public string PasswordHash
        {
            get
            {
                return this.passwordHash;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < Constants.MinPasswordLength)
                {
                    throw new ArgumentException(
                        $"The password must be at least {Constants.MinPasswordLength} symbols long.");
                }

                this.passwordHash = HashUtilities.GetSha256Hash(value);
            }
        }

        public Roles Role { get; private set; }

        public ICollection<Booking> Bookings { get; private set; }
    }
}