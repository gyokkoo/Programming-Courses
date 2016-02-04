namespace Theatre.Core.IO
{
    using System;

    using Theatre.Contracts;

    public class ConsoleInputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
