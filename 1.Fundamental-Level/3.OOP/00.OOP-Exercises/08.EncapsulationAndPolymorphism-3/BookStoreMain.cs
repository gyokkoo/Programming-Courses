using _08.EncapsulationAndPolymorphism_3.Engine;
using _08.EncapsulationAndPolymorphism_3.UI;

namespace _08.EncapsulationAndPolymorphism_3
{
    public class BookStoreMain
    {
        public static void Main()
        {
            ConsoleRenderer renderer = new ConsoleRenderer();
            ConsoleInputHandler inputHandler = new ConsoleInputHandler();
            BookStoreEngine engine = new BookStoreEngine(renderer, inputHandler);

            engine.Run();
        }
    }
}
