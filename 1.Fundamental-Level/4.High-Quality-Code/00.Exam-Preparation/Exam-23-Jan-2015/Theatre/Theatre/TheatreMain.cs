namespace Theatre
{
    using Core;
    using Core.IO;
    using Data;

    public class TheatreMain
    {
        public static void Main()
        {
            var database = new PerformanceDatabase();
            var reader = new ConsoleInputReader();
            var writer = new ConsoleOutputWriter();

            var engine = new Engine(database, reader, writer);
            engine.Run();
        }
    }
}