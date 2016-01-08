namespace ArraySlider_MySolution
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class ArraySlider
    {
        public static void Main()
        {
            BigInteger[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            string command = Console.ReadLine();
            long currentIndex = 0;
            while (command != "stop")
            {
                string[] commandParams = command.Split(' ');
                long offset = long.Parse(commandParams[0]) % numbers.Length;
                string operation = commandParams[1];
                long operand = long.Parse(commandParams[2]);

                if (offset < 0)
                {
                    offset += numbers.Length;
                }

                currentIndex = (currentIndex + offset) % numbers.Length;

                PerformOperation(operation, numbers, currentIndex, operand);

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        private static void PerformOperation(string operation, BigInteger[] numbers, long currentIndex, long operand)
        {
            switch (operation)
            {
                case "&":
                    numbers[currentIndex] &= operand;
                    break;
                case "|":
                    numbers[currentIndex] |= operand;
                    break;
                case "^":
                    numbers[currentIndex] ^= operand;
                    break;
                case "+":
                    numbers[currentIndex] += operand;
                    break;
                case "-":
                    numbers[currentIndex] -= operand;
                    break;
                case "*":
                    numbers[currentIndex] *= operand;
                    break;
                case "/":
                    numbers[currentIndex] /= operand;
                    break;
                default:
                    throw new ArgumentException("Unknown command.");
            }

            if (numbers[currentIndex] < 0)
            {
                numbers[currentIndex] = BigInteger.Zero;
            }
        }
    }
}
