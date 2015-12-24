namespace SOLIDLogger.Appenders
{
    using System;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(IFormatter formatter)
            : base(formatter)
        {
        }

        public override void Append(string message, ReportLevel level, DateTime date)
        {
            string output = this.Formatter.Format(message, level, date);
            Console.WriteLine(output);
        }
    }
}
