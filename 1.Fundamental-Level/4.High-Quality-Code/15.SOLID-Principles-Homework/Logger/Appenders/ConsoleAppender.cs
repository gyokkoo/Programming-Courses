namespace Logger.Appenders
{
    using System;

    using Contracts;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(DateTime date, ReportLevel level, string message)
        {
            string output = this.Layout.Format(date, level, message);

            if (level >= this.ReportLevel)
            {
                Console.WriteLine(output);
            }
        }
    }
}