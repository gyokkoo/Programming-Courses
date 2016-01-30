namespace _03.ArrayTest
{
    using System;
    using System.Linq;

    public class ArrayTest
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] stringParams = command.Split(ArgumentsDelimiter);
                int[] args = new int[2];

                string commandType = stringParams[0];
                if (commandType.Equals("add") ||
                    commandType.Equals("subtract") ||
                    commandType.Equals("multiply"))
                {
                    args[0] = int.Parse(stringParams[1]) - 1;
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, commandType, args);
                }
                else if (stringParams[0].Equals("lshift"))
                {
                    ArrayShiftLeft(array);
                }
                else if (stringParams[0].Equals("rshift"))
                {
                    ArrayShiftRight(array);
                }

                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine();
            }
        }

        private static void PerformAction(long[] arr, string action, int[] args)
        {
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                default:
                    throw new InvalidOperationException("Invalid command.");
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
