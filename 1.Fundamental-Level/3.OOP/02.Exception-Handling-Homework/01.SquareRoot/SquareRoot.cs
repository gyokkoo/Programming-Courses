using System;
/*
Write a program that reads an integer number and calculates and prints its square root. 
If the number is invalid or negative, print "Invalid number". 
In all cases finally print "Good bye". Use try-catch-finally.
*/

public class SquareRoot
{
    static void Main()
    {
        Console.Title = "Problem 1.	Square Root";

        Console.Write("Enter an integer number: ");
        string inputNumber = Console.ReadLine();

        try
        {
            double number = double.Parse(inputNumber);
            double squareRoot = Sqrt(number);
            Console.WriteLine("sqrt({0}) = {1}", number, squareRoot);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (StackOverflowException)
        {
            Console.WriteLine("The number is too big for int32");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }

    private static double Sqrt(double value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        double sqrtNumber = Math.Sqrt(value);

        return sqrtNumber;
    }
}
