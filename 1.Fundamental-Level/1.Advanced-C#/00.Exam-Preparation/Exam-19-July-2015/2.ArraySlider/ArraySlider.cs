namespace _2.ArraySlider
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class ArraySlider
    {
        public static void Main()
        {
            char[] emptyEntries = { ' ', '\t' };

            BigInteger[] numbers =
                Console.ReadLine()
                    .Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries)
                    .Select(BigInteger.Parse)
                    .ToArray();

            string line = Console.ReadLine();
            long currentIndex = 0;
            while (line != "stop")
            {
                string[] commandsArgs = line.Split();
                long offset = long.Parse(commandsArgs[0]) % numbers.Length;
                string operation = commandsArgs[1];
                long operand = long.Parse(commandsArgs[2]);
                if (offset < 0)
                {
                    offset += numbers.Length;
                }

                if (operation == "*")
                {
                    currentIndex = (currentIndex + offset) % numbers.Length;

                    numbers[currentIndex] = numbers[currentIndex] * operand;
                }
                else if (operation == "+")
                {
                    currentIndex = (currentIndex + offset) % numbers.Length;
                    numbers[currentIndex] = numbers[currentIndex] + operand;
                }
                else if (operation == "/")
                {
                    currentIndex = (currentIndex + offset) % numbers.Length;
                    numbers[currentIndex] = numbers[currentIndex] / operand;
                }
                else if (operation == "-")
                {
                    currentIndex = (currentIndex + offset) % numbers.Length;
                    numbers[currentIndex] = numbers[currentIndex] - operand >= 0 ? numbers[currentIndex] - operand : 0;
                    if (numbers[currentIndex] < 0)
                    {
                        numbers[currentIndex] = 0;
                    }
                }
                else if (operation == "&")
                {
                    currentIndex = (currentIndex + offset) % numbers.Length;
                    numbers[currentIndex] = numbers[currentIndex] & operand;
                }
                else if (operation == "|")
                {
                    currentIndex = (currentIndex + offset) % numbers.Length;
                    numbers[currentIndex] = numbers[currentIndex] | operand;
                }
                else if (operation == "^")
                {
                    currentIndex = (currentIndex + offset) % numbers.Length;
                    numbers[currentIndex] = numbers[currentIndex] ^ operand;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}
