namespace HotelBookingSystem.Identity
{
    using System;

    public class AuthorizationFailedException : ArgumentException
    {
        public AuthorizationFailedException(string message) 
            : base(message)
        {
        }
    }
}
