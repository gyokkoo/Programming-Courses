namespace Logger
{
    using System;
    using System.Collections.Generic;

    using Contracts;

    public class Logger : ILogger
    {
        private readonly List<IAppender> appenders; 

        public Logger(params IAppender[] appenders)
        {
            this.appenders = new List<IAppender>();

            foreach (var appender in appenders)
            {
                this.AddAppender(appender);
            }
        }

        public IAppender Appender { get; set; }

        public void AddAppender(IAppender appender)
        {
            this.appenders.Add(appender);
        }

        public void Info(string message)
        {
            this.Log(message, ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.Log(message, ReportLevel.Warn);
        }

        public void Error(string message)
        {
            this.Log(message, ReportLevel.Error);
        }

        public void Critical(string message)
        {
            this.Log(message, ReportLevel.Critical);
        }

        public void Fatal(string message)
        {
            this.Log(message, ReportLevel.Fatal);
        }

        private void Log(string message, ReportLevel level)
        {
            DateTime date = DateTime.Now;
            foreach (var appender in this.appenders)
            {
                appender.Append(date, level, message);
            }
        }
    }
}