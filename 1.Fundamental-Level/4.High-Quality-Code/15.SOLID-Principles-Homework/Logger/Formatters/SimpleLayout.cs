namespace Logger.Formatters
{
    using System;
    using Contracts;

    public class SimpleLayout : ILayout
    {
        public string Format(DateTime date, ReportLevel level, string message)
        {
            return $"{date} - {level} - {message}";
        }
    }
}