namespace Theatre.Core.IO
{
    using System;

    using Theatre.Contracts;

    public class ConsoleOutputWriter : IOutputWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}