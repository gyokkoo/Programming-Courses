using System;
/*
Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
If an invalid number or non-number text is entered, the method should throw an exception. 
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
If the user enters an invalid number, let the user to enter again.
*/
public class EnterNumbers
{
    static void Main()
    {
        Console.Title = "Problem 2.	Enter Numbers";

        int start = 1;
        int end = 100;
        int previuousNumber = 0;

        Console.WriteLine("Enter 10 numbers in range ({0}...{1})", start, end);

        previuousNumber = ReadFirstNumber(start, end);

        for (int i = 1; i < 10; i++)
        {
            try
            {
                Console.Write("Enter number {0} -> ", i + 1);
                previuousNumber = ReadNumber(previuousNumber, start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("The number format is not correct! \nPlease try again.");
                i--;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is not in the given range {0} < number < {1} or is smaller than the previuous number! \nPlease try again.",
                    start, end);
                i--;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number! \nPlease try again.");
                i--;
            }
        }

        Console.WriteLine("Congratulations! You successfully entered 10 numbers in range ({0}...{1})",
            start, end);
    }

    private static int ReadNumber(int previousNumber, int start, int end)
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= start || number >= end || number <= previousNumber)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }

    private static int ReadFirstNumber(int start, int end)
    {
        Console.Write("Enter number 1 -> ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 1 || number >= 100)
        {
            Console.WriteLine("The number is not in the given range {0} < number < {1} or is smaller than the previuous number! \nPlease try again.",
    start, end);
        }

        return number;
    }
}
