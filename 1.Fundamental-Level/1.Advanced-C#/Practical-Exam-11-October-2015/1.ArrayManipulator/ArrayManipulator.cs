using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] commandArgs = command.Split(' ');

            if (commandArgs[0] == "exchange")
            {
                int splitIndex = int.Parse(commandArgs[1]);
                if (splitIndex >= 0 && splitIndex < numbers.Length)
                {
                    ExchangeElementsByGivenIndex(numbers, splitIndex);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (commandArgs[0] == "max")
            {
                if (commandArgs[1] == "even")
                {
                    int maxEvenIndex = GetMaxEvenIndex(numbers);
                    if (maxEvenIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxEvenIndex);
                    }
                }
                else if (commandArgs[1] == "odd")
                {
                    int maxOddIndex = GetMaxOddIndex(numbers);
                    if (maxOddIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxOddIndex);
                    }
                }
            }
            else if (commandArgs[0] == "min")
            {
                if (commandArgs[1] == "even")
                {
                    int minEvenIndex = GetMinEvenIndex(numbers);
                    if (minEvenIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minEvenIndex);
                    }
                }
                else if (commandArgs[1] == "odd")
                {
                    int minOddIndex = GetMinOddIndex(numbers);
                    if (minOddIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minOddIndex);
                    }
                }
            }
            else if (commandArgs[0] == "first")
            {
                if (commandArgs[2] == "even")
                {
                    int count = int.Parse(commandArgs[1]);
                    PrintFirstEvenNums(numbers, count);
                }
                else if (commandArgs[2] == "odd")
                {
                    int count = int.Parse(commandArgs[1]);
                    PrintFirstOddNums(numbers, count);
                }
            }
            else if (commandArgs[0] == "last")
            {
                if (commandArgs[2] == "even")
                {
                    int count = int.Parse(commandArgs[1]);
                    PrintLastEvenNums(numbers, count);
                }
                else if (commandArgs[2] == "odd")
                {
                    int count = int.Parse(commandArgs[1]);
                    PrintLastOddNums(numbers, count);
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }

    private static void PrintLastOddNums(int[] numbers, int count)
    {
        List<int> oddNumbers = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 1)
            {
                oddNumbers.Add(numbers[i]);
            }
        }
        List<int> output = new List<int>();
        if (count < 0 || count > numbers.Length)
        {
            Console.WriteLine("Invalid count");
        }
        else
        {
            if (count >= oddNumbers.Count)
            {
                count = oddNumbers.Count;
            }
            for (int i = oddNumbers.Count - count; i < oddNumbers.Count; i++)
            {
                output.Add(oddNumbers[i]);
            }
            Console.WriteLine("[{0}]", string.Join(", ", output));
        }
    }

    private static void PrintLastEvenNums(int[] numbers, int count)
    {
        List<int> evenNumbers = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumbers.Add(numbers[i]);
            }
        }
        List<int> output = new List<int>();
        if (count < 0 || count >= numbers.Length)
        {
            Console.WriteLine("Invalid count");
        }
        else
        {
            if (count > evenNumbers.Count)
            {
                count = evenNumbers.Count;
            }
            for (int i = evenNumbers.Count - count; i < evenNumbers.Count; i++)
            {
                output.Add(evenNumbers[i]);
            }
            Console.WriteLine("[{0}]", string.Join(", ", output));
        }
    }


    private static void PrintFirstOddNums(int[] numbers, int count)
    {
        if (count < 0 || count >= numbers.Length)
        {
            Console.WriteLine("Invalid count");
        }
        else
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }
            List<int> output = new List<int>();


            if (oddNumbers.Count < count)
            {
                count = oddNumbers.Count;
            }
            for (int i = 0; i < count; i++)
            {
                output.Add(oddNumbers[i]);
            }

            Console.WriteLine("[{0}]", string.Join(", ", output));
        }
    }

    private static void PrintFirstEvenNums(int[] numbers, int count)
    {
        if (count < 0 || count > numbers.Length)
        {
            Console.WriteLine("Invalid count");
        }
        else
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            List<int> output = new List<int>();


            if (evenNumbers.Count < count)
            {
                count = evenNumbers.Count;
            }
            for (int i = 0; i < count; i++)
            {
                output.Add(evenNumbers[i]);
            }
            Console.WriteLine("[{0}]", string.Join(", ", output));
        }
    }

    private static int GetMinOddIndex(int[] numbers)
    {
        int minEvenIndex = -1;
        int minEvenNumber = int.MaxValue;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] % 2 == 1)
            {
                int currNumber = numbers[i];
                if (minEvenNumber > currNumber)
                {
                    minEvenNumber = currNumber;
                    minEvenIndex = i;
                }
            }
        }
        return minEvenIndex;
    }

    private static int GetMinEvenIndex(int[] numbers)
    {
        int minOddInex = -1;
        int minOddNumber = int.MaxValue;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] % 2 == 0)
            {
                int currNumber = numbers[i];
                if (minOddNumber > currNumber)
                {
                    minOddNumber = currNumber;
                    minOddInex = i;
                }
            }
        }
        return minOddInex;
    }

    private static int GetMaxOddIndex(int[] numbers)
    {
        int maxOddIndex = -1;
        int maxOddNumber = int.MinValue;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] % 2 == 1)
            {
                int currNumber = numbers[i];
                if (maxOddNumber < currNumber)
                {
                    maxOddNumber = currNumber;
                    maxOddIndex = i;
                }
            }
        }
        return maxOddIndex;
    }

    private static int GetMaxEvenIndex(int[] numbers)
    {
        int maxEvenIndex = -1;
        int maxEvenNumber = int.MinValue;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] % 2 == 0)
            {
                int currNumber = numbers[i];
                if (maxEvenNumber < currNumber)
                {
                    maxEvenNumber = currNumber;
                    maxEvenIndex = i;
                }
            }
        }
        return maxEvenIndex;
    }

    private static void ExchangeElementsByGivenIndex(int[] numbers, int splitIndex)
    {
        List<int> numbersList = numbers.ToList();
        int j = 0;
        for (int i = splitIndex + 1; i < numbers.Length; i++)
        {
            numbers[j] = numbersList[i];
            j++;
        }
        for (int i = 0; i <= splitIndex; i++)
        {
            numbers[j] = numbersList[i];
            j++;
        }
    }
}
