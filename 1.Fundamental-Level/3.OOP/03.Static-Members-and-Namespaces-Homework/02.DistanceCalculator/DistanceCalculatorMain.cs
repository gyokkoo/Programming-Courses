using System;
using _01.Point3D;

public class DistanceCalculatorMain
{
    public static void Main()
    {
        Console.Title = "Problem 2.	Distance Calculator";

        Point3D firstPoint = new Point3D(2, 4, 6);
        Point3D secondPoint = new Point3D(1, 3, 5);

        Console.WriteLine("The distance bettwen the two points is: {0:F5}", 
            DistanceCalculator.CalculateDistance(firstPoint, secondPoint));
    }
}
