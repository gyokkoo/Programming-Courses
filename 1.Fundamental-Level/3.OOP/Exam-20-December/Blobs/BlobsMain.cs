namespace Blobs
{
    using Engine;
    using Engine.Factories;
    using Engine.Interfaces;
    using IO;
    using IO.Interfaces;

    public class BlobsMain
    {
        public static void Main()
        {
            IInputReader reader = new ConsoleReader();
            IOutputWriter writer = new ConsoleWriter();
            IGameData data = new GameData();
            IBlobFactory blobFactory = new BlobFactory();

            IRunnable engine = new GameEngine(reader, writer, data, blobFactory);
            engine.Run();
        }
    }
}
