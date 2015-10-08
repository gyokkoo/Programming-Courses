using System;
using System.Linq;
using System.Numerics;

class ArraySlider
{
    static void Main()
    {
        char[] emptyEntries = { ' ', '\t' };

        BigInteger[] numbers = Console.ReadLine()
            .Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries)
            .Select(BigInteger.Parse)
            .ToArray();

        string line = Console.ReadLine();
        long curIndex = 0;
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
                curIndex = (curIndex + offset) % numbers.Length;

                numbers[curIndex] = numbers[curIndex] * operand;
            }
            else if (operation == "+")
            {
                curIndex = (curIndex + offset) % numbers.Length;
                numbers[curIndex] = numbers[curIndex] + operand;
            }
            else if (operation == "/")
            {
                curIndex = (curIndex + offset) % numbers.Length;
                numbers[curIndex] = numbers[curIndex] / operand;
            }
            else if (operation == "-")
            {
                curIndex = (curIndex + offset) % numbers.Length;
                numbers[curIndex] = numbers[curIndex] - operand >= 0 ? numbers[curIndex] - operand : 0;
                if (numbers[curIndex] < 0)
                {
                    numbers[curIndex] = 0;
                }
            }
            else if (operation == "&")
            {
                curIndex = (curIndex + offset) % numbers.Length;
                numbers[curIndex] = numbers[curIndex] & operand;
            }
            else if (operation == "|")
            {
                curIndex = (curIndex + offset) % numbers.Length;
                numbers[curIndex] = numbers[curIndex] | operand;
            }
            else if (operation == "^")
            {
                curIndex = (curIndex + offset) % numbers.Length;
                numbers[curIndex] = numbers[curIndex] ^ operand;
            }
            line = Console.ReadLine();
        }

        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }

}
