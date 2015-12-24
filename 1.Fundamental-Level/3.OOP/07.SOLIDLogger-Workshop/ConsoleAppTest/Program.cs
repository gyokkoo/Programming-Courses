namespace ConsoleAppTest
{
    using SOLIDLogger;
    using SOLIDLogger.Appenders;
    using SOLIDLogger.Formatters;
    using SOLIDLogger.Interfaces;

    public class Program
    {
        public static void Main()
        {
            IFormatter formatter = new SampleFormatter();
            FileAppender appender = new FileAppender("file.txt", formatter);

            Logger logger = new Logger(appender);

            int a = 10;
            try
            {
                logger.Critical("a cannot be 10");
                logger.Warn("a cannot be even");
            }
            finally
            {
                appender.Close();
            }
        }
    }
}
