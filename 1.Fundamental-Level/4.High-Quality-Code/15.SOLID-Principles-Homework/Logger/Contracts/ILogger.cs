namespace Logger.Contracts
{
    public interface ILogger
    {
        IAppender Appender { get; set; }

        void AddAppender(IAppender appender);

        void Info(string message);

        void Warn(string message);

        void Error(string message);

        void Critical(string message);

        void Fatal(string message);
    }
}