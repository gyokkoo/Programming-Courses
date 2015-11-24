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

        Console.WriteLine("Etner 10 numbers in range [{0}...{1}]", start, end);
        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.Write("Enter number {0} -> ", i + 1);
                ReadNumber(start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("The number format is not correct! \nPlease try again.");
                i--;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is not in the given range {0} < number < {1}! \nPlease try again.",
                    start, end);
                i--;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number! \nPlease try again.");
                i--;
            }
        }

        Console.WriteLine("Congratulations! You successfully entered 10 numbers in range [{0}...{1}]",
            start, end);
    }

    private static void ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}
