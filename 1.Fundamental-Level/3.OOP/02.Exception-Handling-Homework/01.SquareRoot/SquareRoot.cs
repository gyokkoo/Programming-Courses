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
            int number = int.Parse(inputNumber);
            int squareRoot = Sqrt(number);
            Console.WriteLine("sqrt({0}) = {1}", number, squareRoot);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
            //throw fe;
        }
        catch (ArgumentOutOfRangeException re)
        {
            Console.Error.WriteLine(re.Message);
            //throw re;
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }

    private static int Sqrt(int value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        int sqrtNumber = (int)Math.Sqrt(value);

        return sqrtNumber;
    }
}
