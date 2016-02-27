namespace _4.ArrayTest
{
    using System;
    using System.Linq;

    public class ArraysMain
    {
        public static void Main()
        {
            long sizeOfArray = long.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            while (true)
            {
                string[] lineArgs = Console.ReadLine().Split(' ');
                string command = lineArgs[0];

                if (command == "stop")
                {
                    break;
                }

                long[] args = new long[2];

                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    args[0] = long.Parse(lineArgs[1]);
                    args[1] = long.Parse(lineArgs[2]);

                    PerformAction(array, command, args);
                }
                else
                {
                    if (command.Equals("lshift"))
                    {
                        ArrayShiftLeft(array);
                    }
                    else if (command.Equals("rshift"))
                    {
                        ArrayShiftRight(array);
                    }
                }

                PrintArray(array);
                Console.WriteLine();
            }
        }

        private static void PerformAction(long[] array, string action, long[] args)
        {
            long pos = args[0] - 1;
            long value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstElement;
        }

        private static void PrintArray(long[] array)
        {
            foreach (long number in array)
            {
                Console.Write(number + " ");
            }
        }
    }
}