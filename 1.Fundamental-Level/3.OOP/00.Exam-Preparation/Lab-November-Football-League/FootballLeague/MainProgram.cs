using System;

namespace FootballLeague
{
    public class MainProgram
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while (line != "End")
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentException ax)
                {
                    Console.WriteLine(ax.Message);
                }
                catch (InvalidOperationException iox)
                {
                    Console.WriteLine(iox.Message);
                }

                line = Console.ReadLine();
            }
        }
    }
}
