namespace _1.CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            List<string> collection =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            string commandLine = Console.ReadLine();
            while (commandLine != "end")
            {
                string[] commandParams = commandLine.Split();
                string command = commandParams[0];

                string commandResult = string.Empty;
                switch (command)
                {
                    case "reverse":
                        {
                            int start = int.Parse(commandParams[2]);
                            int count = int.Parse(commandParams[4]);
                            commandResult = ExecuteReverseCommand(collection, start, count);
                            break;
                        }

                    case "sort":
                        {
                            int start = int.Parse(commandParams[2]);
                            int count = int.Parse(commandParams[4]);
                            commandResult = ExecuteSortCommand(collection, start, count);
                            break;
                        }

                    case "rollLeft":
                        {
                            int count = int.Parse(commandParams[1]);
                            commandResult = ExecuteRollLeftCommand(collection, count);
                            break;
                        }

                    case "rollRight":
                        {
                            int count = int.Parse(commandParams[1]);
                            commandResult = ExecuteRollRightCommand(collection, count);
                            break;
                        }

                    default:
                        throw new ArgumentException("Invalid command");
                }

                if (commandResult == "Invalid input parameters.")
                {
                    Console.WriteLine(commandResult);
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", collection));
        }

        private static string ExecuteRollLeftCommand(IList<string> collection, int count)
        {
            if (count < 0)
            {
                return "Invalid input parameters.";
            }

            for (int i = 0; i < count % collection.Count; i++)
            {
                string firstElement = collection[0];
                for (int j = 0; j < collection.Count - 1; j++)
                {
                    collection[j] = collection[j + 1];
                }

                collection[collection.Count - 1] = firstElement;
            }

            return string.Empty;
        }

        private static string ExecuteRollRightCommand(IList<string> collection, int count)
        {
            if (count < 0)
            {
                return "Invalid input parameters.";
            }

            for (int i = 0; i < count % collection.Count; i++)
            {
                string lastElement = collection[collection.Count - 1];
                for (int j = collection.Count - 1; j >= 1; j--)
                {
                    collection[j] = collection[j - 1];
                }

                collection[0] = lastElement;
            }

            return string.Empty;
        }

        private static string ExecuteSortCommand(List<string> collection, int start, int count)
        {
            if (start < 0 || collection.Count <= start ||
                count < 0 || collection.Count < count ||
                collection.Count < start + count)
            {
                return "Invalid input parameters.";
            }

            collection.Sort(start, count, StringComparer.InvariantCulture);

            return string.Empty;
        }

        private static string ExecuteReverseCommand(List<string> collection, int start, int count)
        {
            if (start < 0 || collection.Count <= start ||
                count < 0 || collection.Count < count ||
                collection.Count < start + count)
            {
                return "Invalid input parameters.";
            }

            collection.Reverse(start, count);

            return string.Empty;
        }
    }
}