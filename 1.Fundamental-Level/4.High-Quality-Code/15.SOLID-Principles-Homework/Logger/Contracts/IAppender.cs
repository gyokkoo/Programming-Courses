namespace Logger.Contracts
{
    using System;

    public interface IAppender
    {
        ILayout Layout { get; set; }

        void Append(DateTime date, ReportLevel level, string message);
    }
}