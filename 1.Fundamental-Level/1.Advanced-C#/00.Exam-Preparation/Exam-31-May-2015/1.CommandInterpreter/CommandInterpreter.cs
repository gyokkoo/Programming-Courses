using System;
using System.Linq;
using System.Collections.Generic;
class CommandInterpreter
{
    static void Main()
    {
        char[] emptyEntries = new char[] { ' ' };
        List<string> collections = Console.ReadLine().Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries).ToList();

        string commandLine = Console.ReadLine();

        while (commandLine != "end")
        {
            string[] commandArr = commandLine.Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = commandArr[0]; 
            if(command == "reverse")
            {
                int start = int.Parse(commandArr[2]);
                int count = int.Parse(commandArr[4]);

                if (start >= collections.Count || count > collections.Count || start < 0 || count < 0 || start + count > collections.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    collections.Reverse(start, count);
                }
            }
            else if (command == "sort")
            {
                int start = int.Parse(commandArr[2]);
                int count = int.Parse(commandArr[4]);

                if (start >= collections.Count || count > collections.Count || start < 0 || count < 0 || start + count > collections.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    collections.Sort(start, count, StringComparer.InvariantCulture);
                }
            }
            else if (command == "rollLeft")
            {
                int count = int.Parse(commandArr[1]);
                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    rollLeft(collections, count);
                }
            }
            else if (command == "rollRight")
            {
                int count = int.Parse(commandArr[1]);
                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    rollRight(collections, count);
                }
            }

            commandLine = Console.ReadLine();
        }

        Console.WriteLine("[" + string.Join(", " , collections) + "]");
    }

    static void rollRight(List<string> list, int count)
    {
        int numberOfRolls = count % list.Count;
        var elementsToMove = list.Skip(list.Count - numberOfRolls)
                                 .Take(numberOfRolls)
                                 .ToArray();
        list.InsertRange(0, elementsToMove);
        list.RemoveRange(list.Count - numberOfRolls, numberOfRolls);
    }

    static void rollLeft(List<string> list, int count)
    {
        int numberOfRolls = count % list.Count;
        var elementsToMove = list.Take(numberOfRolls).ToArray();
        list.AddRange(elementsToMove);
        list.RemoveRange(0, numberOfRolls);
    }
}
