namespace HotelBookingSystem.Core.IO
{
    using System;

    using HotelBookingSystem.Contracts;

    public class ConsoleInputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
