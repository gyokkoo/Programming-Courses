namespace Logger.Contracts
{
    using System;

    public interface ILayout
    {
        string Format(DateTime date, ReportLevel level, string message);
    }
}
