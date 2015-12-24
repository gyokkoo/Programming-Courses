namespace SOLIDLogger.Interfaces
{
    using System;

    public interface IAppender
    {
        IFormatter Formatter { get; set; }

        void Append(string msg, ReportLevel level, DateTime date);
    }
}
