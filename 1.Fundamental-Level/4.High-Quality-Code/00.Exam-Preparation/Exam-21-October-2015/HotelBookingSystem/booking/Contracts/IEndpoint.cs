namespace HotelBookingSystem.Contracts
{
    using System.Collections.Generic;

    public interface IEndpoint
    {
        string ControllerName { get; }

        string ActionName { get; }

        IDictionary<string, string> Parameters { get; }
    }
}